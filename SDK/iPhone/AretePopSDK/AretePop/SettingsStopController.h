//
//  SettingsStopController.h
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface SettingsStopController : UIViewController
@property (weak, nonatomic) IBOutlet UITextField *olStopTagCount;
@property (weak, nonatomic) IBOutlet UITextField *olStopTime;
@property (weak, nonatomic) IBOutlet UITextField *olStopCycle;
- (IBAction)rightBarButtonItemClicked:(id)sender;
@end
