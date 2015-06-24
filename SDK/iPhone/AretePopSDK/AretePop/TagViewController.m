//
//  TagViewController.m
//  AreteEarphoneRfid
//
//  Created by phychips on 13. 1. 30..
//
//
#import "EpcConverter.h"
#import "TagViewController.h"
#import "CustomCell.h"
#import "TagAccessController.h"

#define PC_XI                       0x0200
#define XPC_XEB                     0x8000

@interface TagViewController ()
@property (nonatomic, strong, readwrite) TagAccessController *tagAccessController;
@property (nonatomic, strong, readwrite) NSString *epc;
@end

@implementation TagViewController
@synthesize tagAccessController = _tagAccessController;
//@synthesize epc = _epc;

- (id)initWithStyle:(UITableViewStyle)style
{
    self = [super initWithStyle:style];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (NSMutableArray *)tagDataArray
{
    if(!_tagDataArray)
    {
        _tagDataArray = [NSMutableArray arrayWithObjects:nil];
    }
    
    return _tagDataArray;
}

- (NSMutableArray *)tagIDArray
{
    if(!_tagIDArray)
    {
        _tagIDArray = [NSMutableArray arrayWithObjects:nil];
    }
    
    return _tagIDArray;
}

- (NSMutableArray *)tagCountArray
{
    if(!_tagCountArray)
    {
        _tagCountArray = [NSMutableArray arrayWithObjects:nil];
    }
    
    return _tagCountArray;
}

- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    if ([segue.identifier isEqualToString:@"segueTagAccess"])
    {
        [[RcpApi2 sharedInstance] stopReadTags];
        self.tagAccessController = segue.destinationViewController;
        self.tagAccessController.epc = self.epc;
    }
}

- (void)viewDidLoad
{
    [super viewDidLoad];

    // Uncomment the following line to preserve selection between presentations.
    // self.clearsSelectionOnViewWillAppear = NO;
 
    // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
    // self.navigationItem.rightBarButtonItem = self.editButtonItem;
    
    

}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Table view data source

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
    // Return the number of sections.
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
    // Return the number of rows in the section.
    //NSLog(@"numberOfRowsInSection:%u\n",[self.listData count]);
    return [self.tagIDArray count];
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    static NSString *CellIdentifier = @"Cell";
    CustomCell *cell = [tableView dequeueReusableCellWithIdentifier:CellIdentifier forIndexPath:indexPath];
    
    // Configure the cell...
    //NSMutableString* tag = [[NSMutableString alloc] init];
    //NSData *epc = [self.tagIDArray objectAtIndex:indexPath.row];
    //unsigned char* ptr= (unsigned char*) [epc bytes];
    //for(int i = 0; i < epc.length; i++)
    //[tag appendFormat:@"%02X", *ptr++ & 0xFF ];
    //cell.tagID.text = tag;
    cell.tagID.text = [self.tagIDArray objectAtIndex:indexPath.row];
    cell.tagCount.text = [NSString stringWithFormat:@"%@"
                          , [self.tagCountArray objectAtIndex:indexPath.row]];
    
    //cell.tagID.autoresizingMask=UIViewAutoresizingFlexibleWidth;
    
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
    else if (editingStyle == UITableViewCellEditingStyleInsert) {substringWithRange:NSMakeRange
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
    NSString *pcEpc = [self.tagIDArray objectAtIndex:indexPath.row];
 
    unsigned int pc;
    [[NSScanner scannerWithString:[pcEpc substringToIndex:4]] scanHexInt:&pc];
    
    if(pc & PC_XI){    // check the XI bit on the PC
        unsigned int xpc;
        [[NSScanner scannerWithString:[pcEpc substringWithRange:NSMakeRange(4, 4)]] scanHexInt:&xpc];
        
        if (xpc & XPC_XEB) {     // check the XEB bit on the XPC_W1
            self.epc = [pcEpc substringFromIndex:12];
        } else {
            self.epc = [pcEpc substringFromIndex:8];
        }
    } else {
        self.epc = [pcEpc substringFromIndex:4];
    }    
    
    if( HEX_STRING == (int)[[NSUserDefaults standardUserDefaults] integerForKey:@"ENCODING_TYPE"])
    {
        [self performSegueWithIdentifier:@"segueTagAccess" sender:self];
    }
    else
    {
        UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Error"
                                                        message:@"Not possible when encoding type is not HEX."
                                                       delegate:nil
                                              cancelButtonTitle:@"OK"
                                              otherButtonTitles:nil];
        [alert show];
    }
}

- (void)viewDidUnload {
    [self setTableView:nil];
    [super viewDidUnload];
}
@end
