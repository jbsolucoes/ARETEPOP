//
//  SettingsFhLbtController.m
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import "SettingsFhLbtController.h"

@interface SettingsFhLbtController ()

@end

@implementation SettingsFhLbtController
@synthesize onTime;
@synthesize offTime;
@synthesize senseTime;
@synthesize lbtLevel;
@synthesize lbtEnable;
@synthesize fhEnable;
@synthesize cwEnable;

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view.
    self.olOnTime.text = [NSString stringWithFormat:@"%d",(int)onTime];
    self.olOffTime.text = [NSString stringWithFormat:@"%d",(int)offTime];
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{    
    [self.olOnTime resignFirstResponder];
    [self.olOffTime resignFirstResponder];
    
    self.onTime = [self.olOnTime.text integerValue];
    self.offTime = [self.olOffTime.text integerValue];
    
    [[RcpApi2 sharedInstance] setFhLbtParam:self.onTime
                   idleTime:self.offTime
           carrierSenseTime:self.senseTime
                    rfLevel:self.lbtLevel
           frequencyHopping:self.fhEnable
           listenBeforeTalk:self.lbtEnable
             continuousWave:self.cwEnable];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}



- (void)viewDidUnload {
    [self setOlOnTime:nil];
    [self setOlOffTime:nil];
    [super viewDidUnload];
}





@end
