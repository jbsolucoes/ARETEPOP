//
//  SettingsFhLbtController.h
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface SettingsFhLbtController : UIViewController
{
    
}

@property (nonatomic,assign)NSInteger onTime;
@property (nonatomic,assign)NSInteger offTime;
@property (nonatomic,assign)NSInteger senseTime;
@property (nonatomic,assign)NSInteger lbtLevel;
@property (nonatomic,assign)NSInteger fhEnable;
@property (nonatomic,assign)NSInteger lbtEnable;
@property (nonatomic,assign)NSInteger cwEnable;
@property (weak, nonatomic) IBOutlet UITextField *olOnTime;
@property (weak, nonatomic) IBOutlet UITextField *olOffTime;
- (IBAction)rightBarButtonItemClicked:(id)sender;
@end
