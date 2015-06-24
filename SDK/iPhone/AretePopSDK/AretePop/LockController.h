//
//  LockController.h
//  AretePop
//
//  Created by phychips on 13. 6. 20..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface LockController : UIViewController <RcpDelegate2>


@property (nonatomic, strong, readwrite) NSString *epc;
@property (weak, nonatomic) IBOutlet UITextField *olTargetEpc;
@property (weak, nonatomic) IBOutlet UITextField *olAccessPassword;
@property (weak, nonatomic) IBOutlet UISegmentedControl *olTargetMemory;
@property (weak, nonatomic) IBOutlet UISegmentedControl *olAction;
- (IBAction)rightBarButtonItemClicked:(id)sender;
@end
