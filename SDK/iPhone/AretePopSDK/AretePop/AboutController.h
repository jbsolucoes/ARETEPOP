//
//  AboutController.h
//  AretePop
//
//  Created by phychips on 13. 6. 19..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface AboutController : UITableViewController <RcpDelegate2>
@property (weak, nonatomic) IBOutlet UILabel *olAppVersion;
@property (weak, nonatomic) IBOutlet UILabel *olModel;
@property (weak, nonatomic) IBOutlet UILabel *olPID;
@property (weak, nonatomic) IBOutlet UILabel *olRegion;
@property (weak, nonatomic) IBOutlet UILabel *olBattery;
@property (weak, nonatomic) IBOutlet UILabel *olFID;
@end
