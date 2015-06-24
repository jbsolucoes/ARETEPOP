//
//  SettingsPowerController.h
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface SettingsPowerController : UITableViewController
{
}
@property (nonatomic,retain)NSMutableArray *powerArray;
@property (nonatomic,assign)NSInteger initPower;
- (IBAction)rightBarButtonItemClicked:(id)sender;
@end
