//
//  NavigationController.m
//  AretePop
//
//  Created by phychips on 13. 6. 25..
//
//

#import "NavigationController.h"

@interface NavigationController ()

@end

@implementation NavigationController

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view.
}

- (BOOL)shouldAutorotate
{
    //printf("shouldAutorotate\n");
    return YES;
}

- (BOOL)shouldAutorotateToInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation
{
    //printf("shouldAutorotateToInterfaceOrientation\n");
    // Return YES for supported orientations
    
    return YES;
}

-(NSUInteger)supportedInterfaceOrientations{
    
    NSInteger orientationMask = 0;
    
    //if ([self shouldAutorotateToInterfaceOrientation: UIInterfaceOrientationLandscapeLeft])
        
        orientationMask |= UIInterfaceOrientationMaskLandscapeLeft;
    
    //if ([self shouldAutorotateToInterfaceOrientation: UIInterfaceOrientationLandscapeRight])
        
        orientationMask |= UIInterfaceOrientationMaskLandscapeRight;
    
    //if ([self shouldAutorotateToInterfaceOrientation: UIInterfaceOrientationPortrait])
        
        orientationMask |= UIInterfaceOrientationMaskPortrait;
    
    //if ([self shouldAutorotateToInterfaceOrientation: UIInterfaceOrientationPortraitUpsideDown])
        
        orientationMask |= UIInterfaceOrientationMaskPortraitUpsideDown;
    
    return orientationMask;
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
