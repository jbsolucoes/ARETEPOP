//
//  RfSettingsController.m
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import "RfSettingsController.h"

@interface RfSettingsController ()

@end

@implementation RfSettingsController

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
    printf("viewWillAppear\n");
    
    [super viewWillAppear:animated];
    
    [RcpApi2 sharedInstance].delegate = self;
    [[RcpApi2 sharedInstance] getChannel];
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{    
    [self.olChannel resignFirstResponder];
    
    [[RcpApi2 sharedInstance]
        setChannel:[self.olChannel.text integerValue]
     channelOffset:0];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)viewDidUnload
{
    [self setOlChannel:nil];
    [super viewDidUnload];
}

- (void)channelReceived:(uint8_t)channel channelOffset:(uint8_t)channelOffset
{

    dispatch_async(dispatch_get_main_queue(),
                   ^{
                       [self.olChannel setText:[NSString stringWithFormat:@"%d",channel]];
                   });
}

@end
