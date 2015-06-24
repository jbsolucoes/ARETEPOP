//
//  TagViewController.h
//  AreteEarphoneRfid
//
//  Created by phychips on 13. 1. 30..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface TagViewController : UITableViewController
{
}
@property (nonatomic,retain)NSMutableArray *tagDataArray;
@property (nonatomic,retain)NSMutableArray *tagIDArray;
@property (nonatomic,retain)NSMutableArray *tagCountArray;
@end
