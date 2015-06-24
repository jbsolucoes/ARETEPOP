//
//  SettingsPowerController.m
//  AretePop
//
//  Created by phychips on 13. 6. 18..
//
//

#import "SettingsPowerController.h"

@interface SettingsPowerController ()
{
    NSIndexPath *_selectedIndexPath;
    int16_t powerLevel;
}
@end

@implementation SettingsPowerController
@synthesize powerArray = _powerArray;
@synthesize initPower;

- (id)initWithStyle:(UITableViewStyle)style
{
    self = [super initWithStyle:style];
    if (self) {
        // Custom initialization
    }
    return self;
}



- (NSMutableArray *)powerArray
{
    if(!_powerArray)
    {
        _powerArray = [NSMutableArray arrayWithObjects:nil];
    }
    
    return _powerArray;
}

- (void)viewDidLoad
{
    [super viewDidLoad];

    // Uncomment the following line to preserve selection between presentations.
    // self.clearsSelectionOnViewWillAppear = NO;
 
    // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
    // self.navigationItem.rightBarButtonItem = self.editButtonItem;
    _selectedIndexPath = nil;
    //self.navigationItem.rightBarButtonItem.target = self;
    //self.navigationItem.rightBarButtonItem.action = @selector(rightBarButtonItemClicked:);
}

- (IBAction)rightBarButtonItemClicked:(id)sender
{
    [[RcpApi2 sharedInstance] setOutputPowerLevel:powerLevel];
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
    return self.powerArray.count;
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    static NSString *CellIdentifier = @"Cell";
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:CellIdentifier forIndexPath:indexPath];
    
    // Configure the cell...
    int ipower = [[self.powerArray objectAtIndex:indexPath.row] intValue];
    float power = (float) ipower / 10;
    cell.textLabel.text = [NSString stringWithFormat:@"%02.1f", power];
    
    NSLog(@"_selectedIndexPath = %@",_selectedIndexPath);
    NSLog(@"indexPath = %@",indexPath);
    
    if(_selectedIndexPath != nil)
    {
        if(_selectedIndexPath.row == indexPath.row && _selectedIndexPath.section == indexPath.section)
        {
            cell.accessoryType = UITableViewCellAccessoryCheckmark;
            powerLevel = ipower;
        }
        else
        {
            cell.accessoryType = UITableViewCellAccessoryNone;
        }
    }
    else
    {
        if(initPower == [[self.powerArray objectAtIndex:indexPath.row] integerValue])
        {
            cell.accessoryType = UITableViewCellAccessoryCheckmark;
            powerLevel = ipower;
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

    _selectedIndexPath = indexPath;

    [self.tableView reloadData];
}


@end
