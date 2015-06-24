//
//  LockController.m
//  AretePop
//
//  Created by phychips on 13. 6. 20..
//
//

#import "LockController.h"
#import "PhyUtility.h"

@interface LockController ()

@end

@implementation LockController
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

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{
    [self.olTargetEpc resignFirstResponder];
    
    NSString *hexaString = self.olAccessPassword.text;
    NSScanner* pScanner = [NSScanner scannerWithString: hexaString];
    uint32_t accesspassword;
    [pScanner scanHexInt: &accesspassword];
    
    uint32_t lock = 0;
    uint32_t seed = (uint32_t)self.olAction.selectedSegmentIndex;
        
    switch (self.olTargetMemory.selectedSegmentIndex)
    {
        case 0: // Kill
            lock = (seed << 8) | (3 << 18);
            break;
        case 1: // Access
            lock = (seed << 6) | (3 << 16);
            break;
        case 2: // EPC
            lock = (seed << 4) | (3 << 14);
            break;  
        case 3: // TID
            lock = (seed << 2) | (3 << 12);
            break;
        case 4: // USER
            lock = (seed << 0) | (3 << 10);
            break;
        default:
            break;
    }
    
    [[RcpApi2 sharedInstance] lockTagMemory:accesspassword
                        epc:[self.epc hexStringToBytes]
                   lockData:lock];
    
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
    [self setOlAccessPassword:nil];
    [self setOlTargetMemory:nil];
    [self setOlAction:nil];
    [super viewDidUnload];
}
@end
