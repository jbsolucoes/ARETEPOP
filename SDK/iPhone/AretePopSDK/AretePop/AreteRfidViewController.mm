//
//  AreteEarphoneRfidViewController.m
//  AreteEarphoneRfid
//
//  Created by Jinsung Yi on 13. 1. 25..
//  Copyright (c) 2013 PHYCHIPS. All rights reserved.
//
#import "EpcConverter.h"
#import "AreteRfidViewController.h"
#import "AudioMgr.h"
#import "TagViewController.h"
#import "InfoViewController.h"
#import "settingsController.h"
#import "RcpApi2.h"
#import <AVFoundation/AVAudioSession.h>
#import <CoreTelephony/CTCallCenter.h>
#import <CoreTelephony/CTCall.h>
#import <AudioToolBox/AudioServices.h>


@interface AreteRfidViewController()
{
    BOOL plugged;
    CTCallCenter *callCenter;
    BOOL tagRssiOn;
    AVAudioPlayer *readSound;
    BOOL playingSound;
    NSInteger encoding_type;
}
@property (nonatomic, strong, readwrite) TagViewController *tagViewController;
@property (nonatomic, strong, readwrite) InfoViewController *infoViewController;
@property (nonatomic, strong, readwrite) SettingsController *
settingsController;

@end

@implementation AreteRfidViewController
//@synthesize rcp = _rcp;
//@synthesize tagViewController =_tagViewController;
//@synthesize infoViewController = _infoViewController;
//@synthesize settingsController = _settingsController;

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Release any cached data, images, etc that aren't in use.
}

- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    if ([segue.identifier isEqualToString:@"segueTagTableView"])
    {
        self.tagViewController = segue.destinationViewController;
    }
    else if ([segue.identifier isEqualToString:@"segueSettings"])
    {
        [[RcpApi2 sharedInstance] stopReadTags];
        self.settingsController = segue.destinationViewController;
        self.settingsController.tagIDArray = self.tagViewController.tagIDArray;
    }
    //NSLog(@"%@",segue.identifier);
}

- (void)appWillTerminate:(NSNotification*) notification
{
    [[NSNotificationCenter defaultCenter] removeObserver:self];
    NSLog(@"appWillTerminate\n");
}

- (void)appDidEnterBackground:(NSNotification*) notification
{
    NSLog(@"appDidEnterBackground <\n");
    
    [[RcpApi2 sharedInstance] close];
    
    if(self.olSwitch.isOn)
    {
        [self.olSwitch setOn:NO];
    }
    
    [self displayClose];
    
    NSLog(@"appDidEnterBackground >\n");
}

#pragma mark - View lifecycle
- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view, typically from a nib.
    NSLog(@"viewDidLoad\n");
    
    NSString *soundFilePath = [[NSBundle mainBundle] pathForResource:@"read" ofType:@"caf"];
    
    // Converts the sound's file path to an NSURL object
    NSURL *soundURL = [[NSURL alloc] initFileURLWithPath: soundFilePath];
    readSound=[[AVAudioPlayer alloc] initWithContentsOfURL:soundURL  error:nil];
    [readSound prepareToPlay];
    // set it up and play
    [readSound setNumberOfLoops:0];
    [readSound setVolume:1.0f];
    [readSound setPan:1.0f];
    [readSound setDelegate:self];
    
    [[NSNotificationCenter defaultCenter]
        addObserver:self
        selector:@selector(appDidEnterBackground:)
        name:UIApplicationDidEnterBackgroundNotification
        object:nil];
    
    [[NSNotificationCenter defaultCenter]
     addObserver:self
     selector:@selector(appWillTerminate:)
     name:UIApplicationWillTerminateNotification
     object:nil];
    
    if(!callCenter)
    {
        __weak AreteRfidViewController *weakSelf = self;
        
        callCenter = [[CTCallCenter alloc]init];
        callCenter.callEventHandler = ^(CTCall *call)
        {
            NSLog(@"call.callState = %@", call.callState);
            if((call.callState == CTCallStateIncoming)
               || (call.callState == CTCallStateDialing)
               || (call.callState == CTCallStateConnected)
               || (call.callState == CTCallStateDisconnected))
            {
                if([[RcpApi2 sharedInstance] isOpened])
                    [[RcpApi2 sharedInstance] close];
                
                dispatch_async(dispatch_get_main_queue(),
                ^{
                    AreteRfidViewController *strongSelf = weakSelf;
                    if(strongSelf)
                    {
                        [strongSelf displayClose];
                        [strongSelf.olSwitch setOn:NO];
                    }
                });
            }
        };
    }
    NSLog(@"appDidFinishLaunching\n");
    
    NSDictionary *defaults
    = [NSDictionary dictionaryWithObjectsAndKeys:
       @"0", @"stopTagCount",
       @"0", @"stopTime",
       @"0", @"stopCycle",
       @"NO", @"SPEAKER_BEEP",
       @"NO", @"READ_AFTER_PLUGGING",
       @"0", @"ENCODING_TYPE",
       nil];
    
    [[NSUserDefaults standardUserDefaults]
     registerDefaults:defaults];
    

}

- (void)viewWillAppear:(BOOL)animated
{
    [super viewWillAppear:animated];
    NSLog(@"viewWillAppear\n");
    
    BOOL rssiOn = [[NSUserDefaults standardUserDefaults] boolForKey:@"tagRssi"];
    int new_encoding_type
        = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"ENCODING_TYPE"];
    
    if(tagRssiOn != rssiOn || encoding_type != new_encoding_type)
    {
        [self performSelector: @selector(btnClear:) withObject:self afterDelay: 0.0];
        tagRssiOn = rssiOn;
        encoding_type = new_encoding_type;
    }
}

- (void)viewDidAppear:(BOOL)animated
{
    
    [super viewDidAppear:animated];
    printf("viewDidAppear\n");
    
    
    [RcpApi2 sharedInstance].delegate = self;    
    
#ifndef __IPHONE_7_0
    typedef void (^PermissionBlock)(BOOL granted);
#endif
    
    static BOOL bPermission = NO;
    
    PermissionBlock permissionBlock = ^(BOOL granted)
    {
        if (granted)
        {
            bPermission = YES;
        }
        else
        {
            // Warn no access to microphone
            UIAlertView *alert = [[UIAlertView alloc]
                                  initWithTitle:@"Error"
                                  message:@"Microphone input permission refused. Go to iOS settings to enable permission."
                                  delegate:nil
                                  cancelButtonTitle:@"OK"
                                  otherButtonTitles:nil];
            
            dispatch_async(dispatch_get_main_queue(),
                           ^{
                               [alert show];
                           });
        }
    };
    
    if([[AVAudioSession sharedInstance] respondsToSelector:@selector(requestRecordPermission:)])
    {
        [[AVAudioSession sharedInstance] performSelector:@selector(requestRecordPermission:)
                                              withObject:permissionBlock];
    }
}

- (void)viewWillDisappear:(BOOL)animated
{
	[super viewWillDisappear:animated];
    NSLog(@"viewWillDisappear");
}

- (void)viewDidDisappear:(BOOL)animated
{
	[super viewDidDisappear:animated];
    NSLog(@"viewDidDisappear");
}

- (void)tagReceived:(NSData*)pcEpc
{   
    dispatch_async(dispatch_get_main_queue(),
    ^{
        NSString *tag = [EpcConverter toString:encoding_type data:pcEpc];
        
        BOOL bNewItemReceived = ![self.tagViewController.tagIDArray containsObject:tag];
        BOOL bNewTagReceived = ![self.tagViewController.tagDataArray containsObject:pcEpc];
        
        if(bNewTagReceived)
        {
            [self.tagViewController.tagDataArray addObject:pcEpc];
        }
        
        if( (encoding_type != EAN13 && bNewTagReceived)
           || (encoding_type == EAN13 && bNewTagReceived && bNewItemReceived))
        {
            int tagCount = (int)([self.tagViewController.tagCountArray count] + 1);
            [self.tagViewController.tagCountArray addObject:[NSNumber numberWithInt:1]];
            //[self.tagViewController.tagIDArray addObject:pcEpc];
            [self.tagViewController.tagIDArray addObject:tag];
            self.olTagCount.text = [NSString stringWithFormat:@"%d",tagCount];            
        }
        else if( (encoding_type != EAN13 && !bNewTagReceived)
                || (encoding_type == EAN13 && bNewTagReceived && !bNewItemReceived))
        {
            int index = (int)[self.tagViewController.tagIDArray indexOfObject:tag];
            int count = (int)[[self.tagViewController.tagCountArray objectAtIndex:index]
                              integerValue];
            [self.tagViewController.tagCountArray
             replaceObjectAtIndex:index withObject:[NSNumber numberWithInt:(count + 1)]];
        }    	
	    [self.tagViewController.tableView reloadData];
	});
    
    if([[NSUserDefaults standardUserDefaults] boolForKey:@"SPEAKER_BEEP"])
    {
         [self playSound];
    }
}

- (void)tagWithRssiReceived:(NSData*)pcEpc rssi:(int8_t)rssi
{
    dispatch_async(dispatch_get_main_queue(),
    ^{
        NSString *tag = [EpcConverter toString:encoding_type data:pcEpc];
       if(![self.tagViewController.tagIDArray containsObject:tag])
       {
           int tagCount = (int)([self.tagViewController.tagCountArray count] + 1);
           [self.tagViewController.tagCountArray addObject:[NSNumber numberWithInt:(rssi)]];
           //[self.tagViewController.tagIDArray addObject:pcEpc];
           [self.tagViewController.tagIDArray addObject:tag];
           self.olTagCount.text = [NSString stringWithFormat:@"%d",tagCount];
       }
       else
       {
           int index = (int)[self.tagViewController.tagIDArray indexOfObject:tag];
           //int count = [[self.tagViewController.tagCountArray objectAtIndex:index] integerValue];
           [self.tagViewController.tagCountArray
            replaceObjectAtIndex:index                                                        withObject:[NSNumber numberWithInt:(rssi)]];
       }    	
       [self.tagViewController.tableView reloadData];
    });
    
    if([[NSUserDefaults standardUserDefaults] boolForKey:@"SPEAKER_BEEP"])
    {
        [self playSound];
    }
}

- (void)tagWithTidReceived:(NSData *)pcEpc tid:(NSData *)tid
{
    [self ListReflesh:pcEpc];
    [self ListReflesh:tid];
    
    if([[NSUserDefaults standardUserDefaults] boolForKey:@"SPEAKER_BEEP"])
    {
        [self playSound];
    }
}

- (void)ListReflesh:(NSData *)pcEpc
{
    dispatch_async(dispatch_get_main_queue(),
                   ^{
                       NSString *tag = [EpcConverter toString:encoding_type data:pcEpc];
                       
                       BOOL bNewItemReceived = ![self.tagViewController.tagIDArray containsObject:tag];
                       BOOL bNewTagReceived = ![self.tagViewController.tagDataArray containsObject:pcEpc];
                       
                       if(bNewTagReceived)
                       {
                           [self.tagViewController.tagDataArray addObject:pcEpc];
                       }
                       
                       if( (encoding_type != EAN13 && bNewTagReceived)
                          || (encoding_type == EAN13 && bNewTagReceived && bNewItemReceived))
                       {
                           int tagCount = (int)([self.tagViewController.tagCountArray count] + 1);
                           [self.tagViewController.tagCountArray addObject:[NSNumber numberWithInt:1]];
                           //[self.tagViewController.tagIDArray addObject:pcEpc];
                           [self.tagViewController.tagIDArray addObject:tag];
                           self.olTagCount.text = [NSString stringWithFormat:@"%d",tagCount];
                       }
                       else if( (encoding_type != EAN13 && !bNewTagReceived)
                               || (encoding_type == EAN13 && bNewTagReceived && !bNewItemReceived))
                       {
                           int index = (int)[self.tagViewController.tagIDArray indexOfObject:tag];
                           int count = (int)[[self.tagViewController.tagCountArray objectAtIndex:index] integerValue];
                           [self.tagViewController.tagCountArray
                            replaceObjectAtIndex:index withObject:[NSNumber numberWithInt:(count + 1)]];
                       }
                       [self.tagViewController.tableView reloadData];
                   });
}


- (void)playSound
{
    if([[RcpApi2 sharedInstance] isOpened])
    {
        //[NSThread sleepForTimeInterval:0.5f];
        [[RcpApi2 sharedInstance] close];
        [NSThread sleepForTimeInterval:0.5f];
        AudioServicesPlaySystemSound (1352);
    }
    
    if(!playingSound)
    {
        playingSound = YES;
        
        NSError* error;
        if (![[AVAudioSession sharedInstance]
              overrideOutputAudioPort:AVAudioSessionPortOverrideSpeaker
              error:&error])
            NSLog(@"AVAudioSession error overrideOutputAudioPort:%@",error);
        
        [readSound play];
    }
}

- (void)audioPlayerDidFinishPlaying:(AVAudioPlayer *)player successfully:(BOOL)flag
{
    if(playingSound)
    {        
        NSError* error;
        if (![[AVAudioSession sharedInstance]
              overrideOutputAudioPort:AVAudioSessionPortOverrideNone
              error:&error])
            NSLog(@"AVAudioSession error overrideOutputAudioPort:%@",error);
        
        playingSound = NO;
        
        [[RcpApi2 sharedInstance] open];
    }
}

- (void)resetReceived
{
	NSLog(@"readerConnected\n");
    dispatch_async(dispatch_get_main_queue(),
    ^{
        self.olStatus.text = @"Connected\n";
    });
}

- (void)successReceived:(uint8_t)commandCode
{
	NSLog(@"ack_received [%02X]\n",commandCode);
}

- (void)failureReceived:(NSData*)errCode
{
	NSLog(@"err_received [%02X]\n",
          ((const uint8_t *)errCode.bytes)[0]);
}

- (void)batteryStateReceived:(NSData*)data
{
    NSLog(@"batteryStateReceived [%@]\n",data);
    Byte *b = (Byte*) [data bytes];
    
    int adc = b[0];
    int adcMin = b[1];
    int adcMax = b[2];
    
    if(adcMin == adcMax)
    {
        adcMax += 1;
    }
    
    int battery = (adc-adcMin) * 100 / (adcMax - adcMin) + 12;
    battery /= 25;
    battery *= 25;
    
    if(battery > 100) battery = 100;
    else if(battery < 0) battery = 0;
    
    dispatch_async(dispatch_get_main_queue(),
    ^{                       
        self.olBattery.text = [NSString stringWithFormat:@"%d%% ", battery];
        self.olStatus.text = @"Connected\n";
    });        
}

- (void)plugged:(BOOL)plug
{
    plugged = plug;
    
    if(plug)
    {        
        self.olStatus.text = @"Plugged";
        //NSLog(@"Plugged\n");
        
        if( (![[RcpApi2 sharedInstance] isOpened]
               && [[NSUserDefaults standardUserDefaults]
                   boolForKey:@"READ_AFTER_PLUGGING"]))
        {
            dispatch_async(dispatch_get_main_queue(),
            ^{
                UISwitch *sw = self.olSwitch;
                UIBarButtonItem *btn = self.olBtnRead;
                
                [sw setOn:YES];
                [self performSelector:@selector(mSwitch:)
                       withObject:sw];
                [self performSelector:@selector(btnRead:)
                       withObject:btn afterDelay:1.5f];
            });
        }
    }
    else
    {
        self.olStatus.text = @"Unplugged";
        //NSLog(@"Unplugged\n");
        dispatch_async(dispatch_get_main_queue(),
        ^{
            UISwitch *sw = self.olSwitch;
            [sw setOn:NO];
            [self performSelector:@selector(mSwitch:)
                withObject:sw];
        });
        
    }    
}

- (IBAction)mSwitch:(UISwitch *)sender 
{
    if([sender isOn])
    {
        NSLog(@"On\n");
        if([[RcpApi2 sharedInstance] open])
        {
            self.olBtnRead.enabled = YES;
            self.olBtnClear.enabled = YES;
            self.olBtnStop.enabled = YES;
        }
        self.olBtnSettings.enabled = YES;
        
        if(1.0 != [[AVAudioSession sharedInstance] outputVolume])
        {
            UIAlertView *alert = [[UIAlertView alloc]
                                  initWithTitle:@"Error"
                                  message:@"Set the maximum volume."
                                  delegate:nil
                                  cancelButtonTitle:@"OK"
                                  otherButtonTitles:nil];
            [alert show];
        }
    }
    else
    {
        NSLog(@"Off\n");
        [[RcpApi2 sharedInstance] close];
        [self displayClose];
    }
}

- (void)displayClose
{
    self.olBtnRead.enabled = NO;
    self.olBtnClear.enabled = NO;
    self.olBtnStop.enabled = NO;
    self.olBtnSettings.enabled = NO;
                       
    if(plugged)
    {
        self.olStatus.text = @"Plugged";
    }
    else
    {
        self.olStatus.text = @"Unplugged";
    }
    
    self.olBattery.text = @"0% "; 
}

- (IBAction)btnRead:(UIBarButtonItem *)sender
{
    NSString *text = [sender title];
    NSLog(@"%@\n",text);
	
    if(![[RcpApi2 sharedInstance] isOpened])
        return;
    
    int stopTagCount = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopTagCount"];
    int stopTime = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopTime"];
    int stopCycle = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopCycle"];
    BOOL rssiOn = [[NSUserDefaults standardUserDefaults] boolForKey:@"tagRssi"];
    
    if([[NSUserDefaults standardUserDefaults] boolForKey:@"SPEAKER_BEEP"])
    {
        stopTagCount = 1;
    }
    
    if(!rssiOn)
    {
        [[RcpApi2 sharedInstance] startReadTags:stopTagCount mtime:stopTime repeatCycle:stopCycle];
    }
    else
    {
        [[RcpApi2 sharedInstance] startReadTagsWithRssi:stopTagCount mtime:stopTime repeatCycle:stopCycle];
    }
}

- (IBAction)btnClear:(UIBarButtonItem *)sender 
{
    NSString *text = [sender title];
    NSLog(@"%@\n",text);
    [self.tagViewController.tagDataArray removeAllObjects];
    [self.tagViewController.tagIDArray removeAllObjects];
    [self.tagViewController.tagCountArray removeAllObjects];
    [self.tagViewController.tableView reloadData];
    self.olTagCount.text = @"0";
}

- (IBAction)btnStop:(UIBarButtonItem *)sender 
{    
    NSString *text = [sender title];
    NSLog(@"%@\n",text);
       
    if(![[RcpApi2 sharedInstance] isOpened])
        return;

    [[RcpApi2 sharedInstance] stopReadTags];
}

@end

