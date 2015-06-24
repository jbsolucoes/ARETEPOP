//
//  ReadWriteController.h
//  AretePop
//
//  Created by phychips on 13. 6. 19..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface ReadWriteController : UIViewController <RcpDelegate2, UITextViewDelegate, UITextFieldDelegate>

@property (nonatomic, strong, readwrite) NSString *epc;
@property (weak, nonatomic) IBOutlet UISegmentedControl *olMode;
- (IBAction)eModeChanged:(id)sender;
@property (weak, nonatomic) IBOutlet UITextField *olAccessPassword;
@property (weak, nonatomic) IBOutlet UITextField *olStartAdress;
@property (weak, nonatomic) IBOutlet UITextField *olLength;
@property (weak, nonatomic) IBOutlet UITextView *olData;
@property (weak, nonatomic) IBOutlet UISegmentedControl *olTargetMemory;
@property (weak, nonatomic) IBOutlet UITextField *olTargetEpc;
@property (weak, nonatomic) IBOutlet UIScrollView *olScrollVeiw;
- (IBAction)rightBarButtonItemClicked:(id)sender;
@end
