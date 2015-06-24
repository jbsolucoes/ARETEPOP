//
//  SettingsStopController.m
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import "SettingsStopController.h"

@interface SettingsStopController ()

@end

@implementation SettingsStopController

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
    printf("viewDidLoad\n");
    int stopTagCount = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopTagCount"];
    int stopTime = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopTime"];
    int stopCycle = (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"stopCycle"];
    
    printf("%d/%d/%d\n",stopTagCount,stopTime,stopCycle);
    
    self.olStopTagCount.text = [NSString stringWithFormat:@"%d",stopTagCount];
    self.olStopTime.text = [NSString stringWithFormat:@"%d",stopTime];
    self.olStopCycle.text = [NSString stringWithFormat:@"%d",stopCycle];
    
    //self.navigationItem.rightBarButtonItem.target = self;
    //self.navigationItem.rightBarButtonItem.action = @selector(rightBarButtonItemClicked:);
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{
    [self.olStopTagCount resignFirstResponder];
    [self.olStopTime resignFirstResponder];
    [self.olStopCycle resignFirstResponder];
       
    int stopTagCount = (int)[self.olStopTagCount.text integerValue];
    int stopTime = (int)[self.olStopTime.text integerValue];
    int stopCycle = (int)[self.olStopCycle.text integerValue];
    
    [[NSUserDefaults standardUserDefaults] setInteger:stopTagCount forKey:@"stopTagCount"];
    [[NSUserDefaults standardUserDefaults] setInteger:stopTime forKey:@"stopTime"];
    [[NSUserDefaults standardUserDefaults] setInteger:stopCycle forKey:@"stopCycle"];
    
    [[NSUserDefaults standardUserDefaults] synchronize];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)viewDidUnload {
    [self setOlStopTagCount:nil];
    [self setOlStopTime:nil];
    [self setOlStopCycle:nil];
    [super viewDidUnload];
}
@end
