//
//  SettingPopController.m
//  AretePop
//
//  Created by phychips on 13. 6. 17..
//
//
#import "EpcConverter.h"
#import "SettingsPopController.h"
#import "SettingsPowerController.h"
#import "SettingsFhLbtController.h"


@interface SettingsPopController ()
{
    Boolean beep;
    int16_t power;
    int16_t powerMin;
    int16_t powerMax;
    int16_t onTime;
    int16_t offTime;
    int16_t senseTime;
    int16_t lbtLevel;
    Boolean fhEnable;
    Boolean lbtEnable;
    Boolean cwEnable;
}
@property(nonatomic, strong, readwrite) SettingsPowerController *settingsPowerController;
@property(nonatomic, strong, readwrite) SettingsFhLbtController *settingsFhLbtController;
@end

@implementation SettingsPopController
@synthesize settingsPowerController = _settingsPowerController;
@synthesize settingsFhLbtController = _settingsFhLbtController;

- (id)initWithStyle:(UITableViewStyle)style
{
    self = [super initWithStyle:style];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    if ([segue.identifier isEqualToString:@"seguePowerSettings"])
    {
        _settingsPowerController = segue.destinationViewController;
        for(int i = powerMin; i <= powerMax; i = i + 5)
        {
            [_settingsPowerController.powerArray addObject:[NSNumber numberWithInt:i]];
        }
        _settingsPowerController.initPower = power;
    }
    else if ([segue.identifier isEqualToString:@"seguefhLbtSettings"])
    {
        _settingsFhLbtController = segue.destinationViewController;

        _settingsFhLbtController.onTime = onTime;
        _settingsFhLbtController.offTime = offTime;
        _settingsFhLbtController.senseTime = senseTime;
        _settingsFhLbtController.lbtLevel = lbtLevel;
        _settingsFhLbtController.fhEnable = fhEnable;
        _settingsFhLbtController.lbtEnable = lbtEnable;
        _settingsFhLbtController.cwEnable = cwEnable;
    }
}

- (void)viewDidLoad
{
    [super viewDidLoad];

    // Uncomment the following line to preserve selection between presentations.
    // self.clearsSelectionOnViewWillAppear = NO;
 
    // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
    // self.navigationItem.rightBarButtonItem = self.editButtonItem;

    

}

- (void)viewWillAppear:(BOOL)animated
{
    printf("viewWillAppear\n");
    
    [super viewWillAppear:animated];
    
    int stopTagCount = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopTagCount"];
    int stopTime = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopTime"];
    int stopCycle = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopCycle"];
    
    self.olStopCondition.text
    = [NSString stringWithFormat:@"%d/%d/%d",
       stopTagCount,
       stopTime,
       stopCycle];
    
    BOOL rssiOn = [[NSUserDefaults standardUserDefaults] boolForKey:@"tagRssi"];
    [self.olTagRssi setOn:rssiOn];
    
    BOOL speakerBeep = [[NSUserDefaults standardUserDefaults] boolForKey:@"SPEAKER_BEEP"];
    [self.olSpeakerBeep setOn:speakerBeep];
    
    BOOL readAfterStartup = [[NSUserDefaults standardUserDefaults] boolForKey:@"READ_AFTER_PLUGGING"];
    [self.olReadAfterStartup setOn:readAfterStartup];
    
    int encodingType = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"ENCODING_TYPE"];
    
    [self.olEncodingType setText:[EpcConverter toTypeString:encodingType]];
    
    [RcpApi2 sharedInstance].delegate = self;
    [[RcpApi2 sharedInstance] getReaderInfo:0xB0];
    [self performSelector:@selector(onTick) withObject:nil afterDelay:.5f];
}

- (void) onTick
{
    if([self.olPowerLevel.text hasPrefix:@"Detail"])
    {
        [[RcpApi2 sharedInstance] getReaderInfo:0xB0];
        [self performSelector:@selector(onTick) withObject:nil afterDelay:.5f];
    }
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Table view data source
/*
- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
#warning Potentially incomplete method implementation.
    // Return the number of sections.
    return 0;
}
*/

/*
- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
#warning Incomplete method implementation.
    // Return the number of rows in the section.
    return 0;
}
*/

/*
- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    
    static NSString *CellIdentifier = @"Cell";
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:CellIdentifier forIndexPath:indexPath];
    
    // Configure the cell...
    
    return cell;
}
*/

/*
// Override to support conditional editing of the table view.
- (BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Return NO if you do not want the specified item to be editable.
    return YES;
}
*/

/*
// Override to support editing the table view.
- (void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath
{
    if (editingStyle == UITableViewCellEditingStyleDelete) {
        // Delete the row from the data source
        [tableView deleteRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationFade];
    }   
    else if (editingStyle == UITableViewCellEditingStyleInsert) {
        // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
    }   
}
*/

/*
// Override to support rearranging the table view.
- (void)tableView:(UITableView *)tableView moveRowAtIndexPath:(NSIndexPath *)fromIndexPath toIndexPath:(NSIndexPath *)toIndexPath
{
}
*/

/*
// Override to support conditional rearranging of the table view.
- (BOOL)tableView:(UITableView *)tableView canMoveRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Return NO if you do not want the item to be re-orderable.
    return YES;
}
*/

#pragma mark - Table view delegate
- (NSIndexPath *)tableView:(UITableView *)tableView willSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    UITableViewCell* cell = [tableView cellForRowAtIndexPath:indexPath];
    
    cell.selectionStyle = UITableViewCellSelectionStyleNone;
    
    return indexPath;
}

- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Navigation logic may go here. Create and push another view controller.
    if(indexPath.section == 3 && indexPath.row == 0)
    {
        UIAlertView * alert
            = [[UIAlertView alloc] initWithTitle:@"Password Required"
                                         message:@"Please enter the supervisor password."
                                        delegate:self
                               cancelButtonTitle:@"OK" otherButtonTitles:nil];
        
        alert.alertViewStyle = UIAlertViewStyleSecureTextInput;
        [alert show];
    }
}

-(void)alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{
    //NSLog(@"intput = %@",[alertView textFieldAtIndex:0].text);
    NSString *input = [alertView textFieldAtIndex:0].text;
    
    if([[RcpApi2 sharedInstance] submitPassword:input])
    {
        [self performSegueWithIdentifier:@"segueSupervisor" sender:self];
    }
    else
    {
        UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Error"
                                                        message:@"Invalid password!"
                                                       delegate:nil
                                              cancelButtonTitle:@"OK"
                                              otherButtonTitles:nil];
        [alert show];
    }
}

- (void)readerInfoReceived:(NSData *)data
{
	//NSLog(@"readerInfoReceived [%@]\n",[NSString stringWithFormat:@"%@",data]);
    
    Byte *b = (Byte*) [data bytes];
    
    if(data.length < 14) return;
    if(b[0] != 0xB0) return;
        
    beep = b[1];    
    power = b[2];
    powerMin = 200;
    powerMax = 250;
    onTime = (b[3] << 8) | b[4];    
    offTime = (b[5] << 8) | b[6];
    senseTime = (b[7] << 8) | b[8];
    lbtLevel = (b[9] << 8) | b[10];
    fhEnable = b[11];
    lbtEnable = b[12];
    cwEnable = b[13];
    
    if(power == 0)
    {
        power = (b[14] << 8) | b[15];
        powerMin = (b[16] << 8) | b[17];
        powerMax = (b[18] << 8) | b[19];
    }
    
    dispatch_async(dispatch_get_main_queue(),
    ^{
        self.olBeep.on = beep;
        self.olPowerLevel.text = [NSString stringWithFormat:@"%02.1f", (float)power / 10];
        self.olOnOffTime.text = [NSString stringWithFormat:@"%d/%d",onTime,offTime];
        //[self.tableView reloadData];
    });
}

- (void)viewDidUnload
{
    [self setOlPowerLevel:nil];
    [self setOlOnOffTime:nil];
    [self setOlBeep:nil];
    [self setOlStopCondition:nil];
    [super viewDidUnload];
}

- (IBAction)eReadAfterPlugging:(UISwitch *)sender
{
    [[NSUserDefaults standardUserDefaults] setBool:sender.isOn forKey:@"READ_AFTER_PLUGGING"];
    [[NSUserDefaults standardUserDefaults] synchronize];
}

- (IBAction)eBeepChanged:(id)sender
{    
    [[RcpApi2 sharedInstance] setBeep:(uint8_t)self.olBeep.on];
}

- (IBAction)eTagRssiChanged:(id)sender
{
    [[NSUserDefaults standardUserDefaults] setBool:self.olTagRssi.isOn forKey:@"tagRssi"];    
    [[NSUserDefaults standardUserDefaults] synchronize];
}

- (IBAction)eSpeakerBeepChanged:(UISwitch *)sender
{
    [[NSUserDefaults standardUserDefaults] setBool:sender.isOn forKey:@"SPEAKER_BEEP"];
    [[NSUserDefaults standardUserDefaults] synchronize];
}

@end
