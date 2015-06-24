//
//  SettingPopController.h
//  AretePop
//
//  Created by phychips on 13. 6. 17..
//
//

#import <UIKit/UIKit.h>
#import "RcpApi2.h"

@interface SettingsPopController : UITableViewController <RcpDelegate2>
@property (weak, nonatomic) IBOutlet UILabel *olPowerLevel;
@property (weak, nonatomic) IBOutlet UILabel *olOnOffTime;
@property (weak, nonatomic) IBOutlet UISwitch *olBeep;
@property (weak, nonatomic) IBOutlet UILabel *olStopCondition;
@property (weak, nonatomic) IBOutlet UISwitch *olSpeakerBeep;
@property (weak, nonatomic) IBOutlet UISwitch *olTagRssi;
@property (weak, nonatomic) IBOutlet UISwitch *olReadAfterStartup;
@property (weak, nonatomic) IBOutlet UILabel *olEncodingType;
- (IBAction)eReadAfterPlugging:(UISwitch *)sender;
- (IBAction)eBeepChanged:(id)sender;
- (IBAction)eTagRssiChanged:(id)sender;
- (IBAction)eSpeakerBeepChanged:(UISwitch *)sender;
@end
