//
//  KillController.h
//  AretePop
//
//  Created by phychips on 13. 6. 20..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface KillController : UIViewController <RcpDelegate2>
@property (nonatomic, strong, readwrite) NSString *epc;
@property (weak, nonatomic) IBOutlet UITextField *olTargetEpc;
@property (weak, nonatomic) IBOutlet UITextField *olKillPassword;
- (IBAction)rightBarButtonItemClicked:(id)sender;
@end
