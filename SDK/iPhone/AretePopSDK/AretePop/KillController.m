//
//  KillController.m
//  AretePop
//
//  Created by phychips on 13. 6. 20..
//
//

#import "KillController.h"
#import "PhyUtility.h"

@interface KillController ()

@end

@implementation KillController
@synthesize epc = _epc;

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
}

- (void)viewWillAppear:(BOOL)animated
{
    [super viewWillAppear:animated];
    
    [RcpApi2 sharedInstance].delegate = self;
    self.olTargetEpc.text = self.epc;
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{
    [self.olTargetEpc resignFirstResponder];
    
    NSString *hexaString = self.olKillPassword.text;
    NSScanner* pScanner = [NSScanner scannerWithString: hexaString];
    uint32_t killpassword;
    [pScanner scanHexInt: &killpassword];
    
    [[RcpApi2 sharedInstance] killTag:killpassword epc:[self.epc hexStringToBytes]];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)failureReceived:(NSData*)errCode
{
    NSString *strErrMsg = [NSString stringWithFormat:@"Error Code: 0x%02X",
                           ((const uint8_t *)errCode.bytes)[0]];
    UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Error"
                                                    message:strErrMsg
                                                   delegate:nil
                                          cancelButtonTitle:@"OK"
                                          otherButtonTitles:nil];
    
    dispatch_async(dispatch_get_main_queue(),
                   ^{
                       [alert show];
                   });
}

- (void)viewDidUnload {
    [self setOlTargetEpc:nil];
    [self setOlKillPassword:nil];
    [super viewDidUnload];
}
@end
