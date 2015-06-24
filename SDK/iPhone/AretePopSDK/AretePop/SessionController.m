//
//  SessionController.m
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import "SessionController.h"

@interface SessionController ()
{
    //NSIndexPath *_selectedIndexPath;
}
@property (nonatomic,assign)NSInteger session;
@end

@implementation SessionController


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
    
    self.session = -1;
}

- (void)viewWillAppear:(BOOL)animated
{
    printf("viewWillAppear\n");
    
    [super viewWillAppear:animated];
    
    [RcpApi2 sharedInstance].delegate = self;
    [[RcpApi2 sharedInstance] getSession];
    
    printf("getSession\n");
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{
    if(self.session == -1)
    {
        [[RcpApi2 sharedInstance] setSession:0];
    }
    else
    {
        [[RcpApi2 sharedInstance] setSession:self.session];
    }
    
    UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Warring"
                                                    message:@"Reset your hardware."
                                                   delegate:nil
                                          cancelButtonTitle:@"OK"
                                          otherButtonTitles:nil];
    
    dispatch_async(dispatch_get_main_queue(),
                   ^{
                       [alert show];
                   });
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Table view data source


- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
//#warning Potentially incomplete method implementation.
    // Return the number of sections.
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
//#warning Incomplete method implementation.
    // Return the number of rows in the section.
    return 4;
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    static NSString *CellIdentifier = @"Cell";
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:CellIdentifier forIndexPath:indexPath];
    
    // Configure the cell...
    cell.textLabel.text = [NSString stringWithFormat:@"S%d", (int)indexPath.row];

    {
        if(self.session == indexPath.row)
        {
            cell.accessoryType = UITableViewCellAccessoryCheckmark;
        }
        else
        {
            cell.accessoryType = UITableViewCellAccessoryNone;
        }
    }
   
    //printf("cellForRowAtIndexPath\n");
    
    return cell;
}

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
    
     //<#DetailViewController#> *detailViewController = [[<#DetailViewController#> alloc] initWithNibName:@"<#Nib name#>" bundle:nil];
     // ...
     // Pass the selected object to the new view controller.
     //[self.navigationController pushViewController:detailViewController animated:YES];
    printf("didSelectRowAtIndexPath\n");

    //_selectedIndexPath = indexPath;
    self.session = indexPath.row;
    
    [self.tableView reloadData];
}

-(void) sessionReceived:(uint8_t)session
{
    self.session = session;
    dispatch_async(dispatch_get_main_queue(),
                   ^{
    [self.tableView reloadData];
                   });
}

@end
