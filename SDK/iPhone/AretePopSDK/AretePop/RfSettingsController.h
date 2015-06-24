//
//  SettingsFhLbtController.h
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface RfSettingsController : UIViewController  <RcpDelegate2>
{
    
}
@property (weak, nonatomic) IBOutlet UITextField *olChannel;
- (IBAction)rightBarButtonItemClicked:(id)sender;
@end
