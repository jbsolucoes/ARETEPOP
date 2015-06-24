//
//  SettingsController.h
//  AretePop
//
//  Created by phychips on 13. 6. 17..
//
//
#import <MessageUI/MessageUI.h>  
#import <UIKit/UIKit.h>
#import "RcpApi2.h"


@interface SettingsController : UITableViewController <UIDocumentInteractionControllerDelegate, MFMailComposeViewControllerDelegate>
@property (nonatomic,retain)NSMutableArray *tagIDArray;
@end
