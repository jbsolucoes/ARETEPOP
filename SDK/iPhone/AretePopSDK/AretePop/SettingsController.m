//
//  SettingsController.m
//  AretePop
//
//  Created by phychips on 13. 6. 17..
//
//

#import "SettingsController.h"
#import "SettingsPopController.h"
#import "AboutController.h"


@interface SettingsController ()
{
    UIDocumentInteractionController *documentController;
    
}
@property(nonatomic, strong, readwrite) SettingsPopController *settingsPopController;
@property(nonatomic, strong, readwrite) AboutController *aboutController;
@property(nonatomic, retain) UIBarButtonItem *backBarButtonItem;
@end

@implementation SettingsController
@synthesize settingsPopController = _settingsPopController;
@synthesize aboutController = _aboutController;
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    if ([segue.identifier isEqualToString:@"seguePopSettings"])
    {
        _settingsPopController = segue.destinationViewController;
    }
    else if ([segue.identifier isEqualToString:@"segueAbout"])
    {
        _aboutController = segue.destinationViewController;
    }
    //printf("SettingsController:prepareForSegue\n");
}

- (id)initWithStyle:(UITableViewStyle)style
{
    self = [super initWithStyle:style];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];

    // Uncomment the following line to preserve selection between presentations.
    // self.clearsSelectionOnViewWillAppear = NO;
 
    // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
    //self.navigationItem.rightBarButtonItem = self.editButtonItem;
}


- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Table view data source

/*
- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
#warning Potentially incomplete method implementation.
    // Return the number of sections.
    return 0;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
#warning Incomplete method implementation.
    // Return the number of rows in the section.
    return 0;
}
*/

/*
- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    static NSString *CellIdentifier = @"Cell";
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:CellIdentifier forIndexPath:indexPath];
    
    // Configure the cell...
    
    return cell;
}
*/

/*
// Override to support conditional editing of the table view.
- (BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Return NO if you do not want the specified item to be editable.
    return YES;
}
*/

/*
// Override to support editing the table view.
- (void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath
{
    if (editingStyle == UITableViewCellEditingStyleDelete) {
        // Delete the row from the data source
        [tableView deleteRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationFade];
    }   
    else if (editingStyle == UITableViewCellEditingStyleInsert) {
        // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
    }   
}
*/

/*
// Override to support rearranging the table view.
- (void)tableView:(UITableView *)tableView moveRowAtIndexPath:(NSIndexPath *)fromIndexPath toIndexPath:(NSIndexPath *)toIndexPath
{
}
*/

/*
// Override to support conditional rearranging of the table view.
- (BOOL)tableView:(UITableView *)tableView canMoveRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Return NO if you do not want the item to be re-orderable.
    return YES;
}
*/

#pragma mark - Table view delegate

- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Navigation logic may go here. Create and push another view controller.
    /*
     <#DetailViewController#> *detailViewController = [[<#DetailViewController#> alloc] initWithNibName:@"<#Nib name#>" bundle:nil];
     // ...
     // Pass the selected object to the new view controller.
     [self.navigationController pushViewController:detailViewController animated:YES];
     */
    
    //printf("selected %ld\n", (long)indexPath.section);
    if(indexPath.section == 2 && indexPath.row == 0 && self.tagIDArray.count != 0)
    {
        NSArray *paths
        = NSSearchPathForDirectoriesInDomains
        (NSDocumentDirectory,
         NSUserDomainMask, YES);
        
        NSString *documentsDirectory
        = [paths objectAtIndex:0];
        
        NSDate* date = [NSDate date];
        
        NSCalendar* calendar = [NSCalendar currentCalendar];
        NSDateComponents* components = [calendar components:NSYearCalendarUnit |
                                        NSMonthCalendarUnit |
                                        NSDayCalendarUnit |
                                        NSHourCalendarUnit |
                                        NSMinuteCalendarUnit |
                                        NSSecondCalendarUnit fromDate:date];
        
        NSString *dateString
        = [NSString stringWithFormat:@"tag_list_%04d%02d%02d_%02d%02d%02d.csv",
            (int)[components year],
            (int)[components month],
            (int)[components day],
            (int)[components hour],
            (int)[components minute],
            (int)[components second]];
                          
        NSString *fileName
        = [documentsDirectory stringByAppendingPathComponent:dateString];
        
        NSLog(@"%@",fileName);
        
        NSMutableString *content = [[NSMutableString alloc] init];
        for(int i = 0; i < self.tagIDArray.count; i++)
        {
            //NSData *epc = [self.tagIDArray objectAtIndex:i];
            //NSMutableString* tag = [[NSMutableString alloc] init];
            //unsigned char* ptr= (unsigned char*) [epc bytes];
            //for(int j = 0; j < epc.length; j++)
            //[tag appendFormat:@"%02X", *ptr++ & 0xFF ];
            [content appendString:[self.tagIDArray objectAtIndex:i]];
            [content appendString:@"\n"];
        }

        //save content to the documents directory
        [content writeToFile:fileName
                  atomically:NO
                    encoding:NSStringEncodingConversionAllowLossy
                       error:nil];
        
        
        documentController =
        [UIDocumentInteractionController
         interactionControllerWithURL:[NSURL fileURLWithPath:fileName]];
        
        NSLog(@"NSURL : %@", [NSURL fileURLWithPath:fileName]);
        
        documentController.delegate = self;

        documentController.UTI = @"public.text";
        
        if(![documentController presentOpenInMenuFromRect:self.view.frame
                                                  inView:self.view
                                                animated:YES])
        {
            NSLog(@"There is no app for this file");
            
            if ([MFMailComposeViewController canSendMail])
            {
                // Create and show composer
                MFMailComposeViewController* controller;
                controller = [[MFMailComposeViewController alloc] init];
                controller.mailComposeDelegate = self;
                [controller setSubject:dateString];
                [controller setMessageBody:content isHTML:NO];
                NSData* contentData = [content dataUsingEncoding: NSUTF8StringEncoding];
                [controller addAttachmentData:contentData mimeType:@"text/csv" fileName:dateString];
                
                [self presentViewController:controller animated:YES completion:nil];
            }
            else
            {
                // Show some error message here
                UIAlertView *alert = [[UIAlertView alloc]initWithTitle:@"Error" message:@"No mail account setup on device" delegate:self cancelButtonTitle:@"Close" otherButtonTitles:nil, nil];
                
                [alert show];
            }            

        }
        
        //[documentController presentPreviewAnimated:YES];
    }
    [self.tableView reloadData];
}

-(void)mailComposeController:(MFMailComposeViewController *)controller didFinishWithResult:(MFMailComposeResult)result error:(NSError *)error
{
    
    switch (result) {
//        case MFMailComposeResultCancelled:
//        {
//            UIAlertView *alert = [[UIAlertView alloc]initWithTitle:@"" message:@"Cancel" delegate:self cancelButtonTitle:@"Close" otherButtonTitles:nil, nil];
//            
//            [alert show];
//            break;
//        }
//        case MFMailComposeResultFailed:
//        {
//            UIAlertView *alert = [[UIAlertView alloc]initWithTitle:@"" message:@"Failed" delegate:self cancelButtonTitle:@"Close" otherButtonTitles:nil, nil];
//            
//            [alert show];
//            break;
//        }
        case MFMailComposeResultSent:
        {
            UIAlertView *alert = [[UIAlertView alloc]initWithTitle:@"" message:@"Success" delegate:self cancelButtonTitle:@"Close" otherButtonTitles:nil, nil];
            
            [alert show];
        }
        default:
            break;
    }

    [controller dismissViewControllerAnimated:NO completion:Nil];
}

@end
