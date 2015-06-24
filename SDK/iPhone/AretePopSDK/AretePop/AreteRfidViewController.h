//
//  AreteEarphoneRfidViewController.h
//  AreteEarphoneRfid
//
//  Created by Jinsung Yi on 13. 1. 25..
//  Copyright (c) 2013 PHYCHIPS. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <AVFoundation/AVAudioPlayer.h>
#import "RcpApi2.h"

@interface AreteRfidViewController : UIViewController <RcpDelegate2,AVAudioPlayerDelegate>
- (IBAction)mSwitch:(UISwitch *)sender;
- (IBAction)btnRead:(UIBarButtonItem *)sender;
- (IBAction)btnClear:(UIBarButtonItem *)sender;
- (IBAction)btnStop:(UIBarButtonItem *)sender;



@property (weak, nonatomic) IBOutlet UIBarButtonItem *olBtnSettings;
@property (weak, nonatomic) IBOutlet UILabel *olTagCount;
@property (weak, nonatomic) IBOutlet UILabel *olStatus;
@property (weak, nonatomic) IBOutlet UILabel *olBattery;
@property (weak, nonatomic) IBOutlet UIBarButtonItem *olBtnRead;
@property (weak, nonatomic) IBOutlet UIBarButtonItem *olBtnClear;
@property (weak, nonatomic) IBOutlet UIBarButtonItem *olBtnStop;
@property (weak, nonatomic) IBOutlet UISwitch *olSwitch;
@end
