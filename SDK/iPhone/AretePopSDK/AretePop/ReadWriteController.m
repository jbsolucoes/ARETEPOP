//
//  ReadWriteController.m
//  AretePop
//
//  Created by phychips on 13. 6. 19..
//
//

#import "ReadWriteController.h"
#import "PhyUtility.h"

@interface ReadWriteController ()
{
    UIView *activeField;
    UIScrollView *scrollView;
    CGFloat scrollViewOffset;
    
    unsigned int dataAddr;
    NSMutableString *dataBuffer;
}
@end

@implementation ReadWriteController
@synthesize epc = _epc;

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
//    self.olScrollVeiw.scrollEnabled = YES;
//    self.olScrollVeiw.contentSize = CGSizeMake(self.view.frame.size.width, self.view.frame.size.height + 300);
    
    scrollView = [[UIScrollView alloc] initWithFrame:self.view.frame];
    
    //scrool view must be under main view - swap it
    UIView* natView = self.view;
    [self setView:scrollView];
    [self.view addSubview:natView];
    
    UIToolbar* numberToolbar = [[UIToolbar alloc]initWithFrame:CGRectMake(0, 0, 320, 50)];
    //numberToolbar.barStyle = UIBarStyleBlackTranslucent;
    numberToolbar.barStyle = UIBarStyleDefault;
    numberToolbar.items = [NSArray arrayWithObjects:
                           [[UIBarButtonItem alloc]initWithBarButtonSystemItem:UIBarButtonSystemItemFlexibleSpace target:nil action:nil],
                           [[UIBarButtonItem alloc]initWithTitle:@"Apply" style:UIBarButtonItemStyleDone target:self action:@selector(doneWithNumberPad)],
                           nil];
    
    [numberToolbar sizeToFit];
    
    scrollView = self.olScrollVeiw;
    scrollView.scrollEnabled = YES;
    self.olAccessPassword.delegate = self;
    self.olData.delegate = self;
    self.olLength.delegate = self;
    self.olLength.inputAccessoryView = numberToolbar;
    self.olStartAdress.delegate = self;
//    self.olStartAdress.inputAccessoryView = numberToolbar;
    self.olTargetEpc.delegate = self;
}

- (void)doneWithNumberPad
{
    if(self.olLength.canResignFirstResponder)
    {
        [self.olLength resignFirstResponder];
    }
//    
//    if(self.olStartAdress.canResignFirstResponder)
//    {
//        [self.olStartAdress resignFirstResponder];
//    }
}

- (void)viewWillAppear:(BOOL)animated
{
    [super viewWillAppear:animated];
    
    [RcpApi2 sharedInstance].delegate = self;
    self.olTargetEpc.text = self.epc;
    
    [self registerForKeyboardNotifications];
}

- (void)viewWillDisappear:(BOOL)animated
{
    [super viewWillAppear:animated];
    
    [[NSNotificationCenter defaultCenter] removeObserver:self];
}


// Call this method somewhere in your view controller setup code.
- (void)registerForKeyboardNotifications
{
    [[NSNotificationCenter defaultCenter] addObserver:self
                                             selector:@selector(keyboardWillShown:)
                                                 name:UIKeyboardDidShowNotification object:nil];
    
    [[NSNotificationCenter defaultCenter] addObserver:self
                                             selector:@selector(keyboardWillBeHidden:)
                                                 name:UIKeyboardWillHideNotification object:nil];
    
}

- (void)keyboardWillShown:(NSNotification*)aNotification
{
    //printf("keyboardWillShown\n");
    
    NSDictionary* info = [aNotification userInfo];
    CGSize kbSize = [[info objectForKey:UIKeyboardFrameBeginUserInfoKey] CGRectValue].size;
    
    CGRect frame = self.view.frame;
    frame.size.height -= kbSize.height;
    CGPoint fOrigin = activeField.frame.origin;
    fOrigin.y -= scrollView.contentOffset.y;
    fOrigin.y += activeField.frame.size.height;
    scrollViewOffset = scrollView.contentOffset.y;
    
    if (!CGRectContainsPoint(frame, fOrigin) )
    {
        CGPoint scrollPoint = CGPointMake(0.0, activeField.frame.origin.y + activeField.frame.size.height - frame.size.height + 80);
        
        [scrollView setContentOffset:scrollPoint animated:YES];
    }
}

- (void)keyboardWillBeHidden:(NSNotification*)aNotification
{
    [scrollView setContentOffset:CGPointMake(0.0, scrollViewOffset) animated:YES];
}

- (void)textFieldDidBeginEditing:(UITextField *)textField
{
    //printf("textFieldDidBeginEditing\n");
    activeField = textField;
}

- (void)textFieldDidEndEditing:(UITextField *)textField
{
    activeField = nil;
}

- (BOOL)textFieldShouldReturn:(UITextField *)textField
{
    [textField resignFirstResponder];
    return YES;
}

- (void)textViewDidBeginEditing:(UITextView *)textView
{
    activeField = textView;
}

- (void)textViewDidEndEditing:(UITextView *)textView
{
    activeField = nil;
}

- (BOOL)textView:(UITextView *)textView shouldChangeTextInRange:(NSRange)range
 replacementText:(NSString *)text
{
    if ([text isEqualToString:@"\n"]) {
        [textView resignFirstResponder];
        return FALSE;
    }
    
    return TRUE;
}

- (void)tagMemoryReceived:(NSData *)data
{
    dispatch_async(dispatch_get_main_queue(),
    ^{
        self.olData.text = [data bytesToHexString];
    });
    
    dispatch_async(dispatch_get_main_queue(),
    ^{
        CGRect frame = self.olData.frame;
        if (self.olData.contentSize.height > (scrollView.bounds.size.height - self.olData.frame.origin.y - 80)) {
            frame.size.height = scrollView.bounds.size.height - self.olData.frame.origin.y - 80;
        }
        else
        {
            frame.size.height = self.olData.contentSize.height;
        }
        
        self.olData.frame = frame;
    });
}

- (void)tagMemoryLongReceived:(NSData *)data
{
    NSLog(@"data length = %d", (int) data.length);
    
    if ([data length] > 3) {
        [[NSScanner scannerWithString:self.olStartAdress.text] scanHexInt:&dataAddr];
        [dataBuffer appendString: [[data bytesToHexString] substringFromIndex:6]];
        
        dispatch_async(dispatch_get_main_queue(),
        ^{
            self.olData.text = @"Read operation is in progress..";
        });

    }
    else if(([data length] == 1) & (((const uint8_t *)data.bytes)[0] == 0x1F))	// 0x1F = Complete
    {
        dispatch_async(dispatch_get_main_queue(),
        ^{
            self.olData.text = [self editAddressString:dataAddr dataString:dataBuffer];
        });

        dispatch_async(dispatch_get_main_queue(),
        ^{
            CGRect frame = self.olData.frame;
            frame.size.height = scrollView.bounds.size.height - self.olData.frame.origin.y - 80;
            
            self.olData.frame = frame;
        });
    }
}

- (NSMutableString *) editAddressString:(unsigned int)add dataString:(NSMutableString *)dataString
{
    NSMutableString *ms = [NSMutableString stringWithCapacity: 10];
    
    for(int i=0; i<[dataString length]; i++)
    {
        if(i%16 == 0)
            [ms appendFormat: @"0x%04X  ", add+(i/4)];
        
        [ms appendString:[dataString substringWithRange:NSMakeRange(i, 1)]];
        
        if(i%2 == 1)
            [ms appendString:@" "];
        
        if(i%16 == 15 )
            [ms appendString:@"\n"];
    }
    
    return ms;
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)eModeChanged:(id)sender
{
    printf("eModeChanged\n");
    
    if(self.olMode.selectedSegmentIndex == 0)
    {
        self.navigationItem.title = @"Read";
        self.olLength.enabled = YES;
    }
    else
    {
        self.navigationItem.title = @"Write";
        self.olLength.enabled = NO;
    }
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{
    dataAddr = 0;
    dataBuffer = [NSMutableString stringWithCapacity: 10];
    
    [self.olTargetEpc resignFirstResponder];
    [self.olAccessPassword resignFirstResponder];
    [self.olStartAdress resignFirstResponder];
    [self.olLength resignFirstResponder];
    [self.olData resignFirstResponder];
    
    NSString *hexaString = self.olAccessPassword.text;
    NSScanner* pScanner = [NSScanner scannerWithString: hexaString];
    uint32_t accesspassword;    
    [pScanner scanHexInt: &accesspassword];
    
    hexaString = self.olStartAdress.text;
    pScanner = [NSScanner scannerWithString: hexaString];
    uint32_t startAddress;
    [pScanner scanHexInt: &startAddress];
    
    uint16_t dataLength = [self.olLength.text intValue];
    uint8_t membank = self.olTargetMemory.selectedSegmentIndex;
    
    //printf("accesspassword = %08X\n",accesspassword);    
    NSData *data = [self.olData.text hexStringToBytes];
    
    if(self.epc.length == 0)
        return;
    
    if(self.olMode.selectedSegmentIndex == 0)
    {
        //self.navigationItem.title = @"Read";
        if (dataLength <= 64) {
            [[RcpApi2 sharedInstance] readFromTagMemory:accesspassword
                                                    epc:[self.epc hexStringToBytes]
                                             memoryBank:membank
                                           startAddress:startAddress
                                             dataLength:dataLength];
        } else {
            [[RcpApi2 sharedInstance] readFromTagMemoryLong:accesspassword
                                                    epc:[self.epc hexStringToBytes]
                                             memoryBank:membank
                                           startAddress:startAddress
                                             dataLength:dataLength];
        }
    }
    else
    {
        //self.navigationItem.title = @"Write";
        [[RcpApi2 sharedInstance] writeToTagMemory:accesspassword
                               epc:[self.epc hexStringToBytes]
                        memoryBank:membank
                      startAddress:startAddress
                       dataToWrite:data];
        
        self.olLength.text = [NSString stringWithFormat:@"%d", (uint16_t)data.length/2];
    }
}

- (void)failureReceived:(NSData*)errCode
{
    NSString *strErrMsg = [NSString stringWithFormat:@"Error Code: 0x%02X",
                           ((const uint8_t *)errCode.bytes)[0]];
    UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Error"
                                                    message:strErrMsg
                                                   delegate:nil
                                          cancelButtonTitle:@"OK"
                                          otherButtonTitles:nil];
    
    dispatch_async(dispatch_get_main_queue(),
    ^{
        [alert show];
    });
}

- (void)viewDidUnload {
    [self setOlAccessPassword:nil];
    [self setOlMode:nil];
    [self setOlStartAdress:nil];
    [self setOlLength:nil];
    [self setOlTargetMemory:nil];
    [self setOlData:nil];
    [self setOlTargetEpc:nil];

    [self setOlScrollVeiw:nil];
    [super viewDidUnload];
}
@end



