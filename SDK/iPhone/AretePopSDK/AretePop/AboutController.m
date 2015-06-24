//
//  AboutController.m
//  AretePop
//
//  Created by phychips on 13. 6. 19..
//
//

#import "AboutController.h"

@interface AboutController ()

@end

@implementation AboutController


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
    // self.navigationItem.rightBarButtonItem = self.editButtonItem;
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Table view data source

- (void) viewWillAppear:(BOOL)animated
{

    [super viewWillAppear:animated];
    self.olAppVersion.text = [NSString stringWithFormat:@"%@",[[NSBundle mainBundle] objectForInfoDictionaryKey:@"CFBundleShortVersionString"]];
    
    [RcpApi2 sharedInstance].delegate = self;
    [[RcpApi2 sharedInstance] getReaderInfo:0xB1];
    printf("AboutController:viewWillAppear\n");
    
    [self performSelector:@selector(onTick) withObject:nil afterDelay:.5f];
}

- (void) onTick
{
    if( [self.olRegion.text hasPrefix:@"Detail"]  )
    {
        [[RcpApi2 sharedInstance] getReaderInfo:0xB1];
        [self performSelector:@selector(onTick) withObject:nil afterDelay:.5f];
    }
}



#define REGION_KOREA_OLD			0x01
#define REGION_USA_OLD 				0x02
#define REGION_EUROPE_OLD			0x04
#define REGION_JAPAN_OLD			0x08
#define REGION_CHINA2_OLD			0x10
#define REGION_CHINA1_OLD			0x16
#define REGION_USA2_OLD				0x32

#define REGION_KOREA				0x11
#define REGION_USA 					0x21
#define REGION_USA2	 				0x22
#define REGION_EUROPE				0x31
#define REGION_JAPAN				0x41
#define REGION_CHINA1				0x51
#define REGION_CHINA2				0x52
#define REGION_BRAZIL1              0x61
#define REGION_BRAZIL2              0x62
#define REGION_AU_HK				0x71

- (void)readerInfoReceived:(NSData *)data
{
	//NSLog(@"readerInfoReceived [%@]\n",[NSString stringWithFormat:@"%@",data]);
    Byte *b = (Byte*) [data bytes];
    
    if(data.length < 29) return;
    if(b[0] != 0xB1) return;
        
    int band = b[1];
    
    int adc = b[2];
    int adcMin = b[3];
    int adcMax = b[4];
    
    if(adcMin == adcMax)
    {
        adcMax += 1;
    }
    
    int battery = (adc-adcMin) * 100 / (adcMax - adcMin) + 12;
    battery /= 25;
    battery *= 25;
    
    if(battery > 100) battery = 100;
    else if(battery < 0) battery = 0;
    
    NSData *model = [data subdataWithRange:NSMakeRange(5,10)];
    NSData *pid = [data subdataWithRange:NSMakeRange(15,10)];
    NSData *fid = [data subdataWithRange:NSMakeRange(25,4)];
    
    NSString *strBand;
    
    switch (band)
    {
        case REGION_KOREA_OLD:
        case REGION_KOREA:
            strBand = @"KOREA";
            break;
        case REGION_USA_OLD:
        case REGION_USA:
        case REGION_USA2:
            strBand = @"US";
            break;
        case REGION_EUROPE_OLD:
        case REGION_EUROPE:
            strBand = @"EU";
            break;
        case REGION_JAPAN_OLD:
        case REGION_JAPAN:
            strBand = @"JAPAN";
            break;
        case REGION_CHINA2_OLD:
        case REGION_CHINA1_OLD:
        case REGION_CHINA1:
        case REGION_CHINA2:
            strBand = @"CHINA";
            break;
        case REGION_AU_HK:
            strBand = @"ASIA";
            break;
        default:
            strBand = @"Unkown";
            break;
    }
    
    dispatch_async(dispatch_get_main_queue(),
    ^{
        self.olRegion.text = strBand;
        self.olBattery.text = [NSString stringWithFormat:@"%d%%", battery];
        self.olModel.text = [[NSString alloc] initWithData:model encoding:NSUTF8StringEncoding];
        self.olPID.text = [[NSString alloc] initWithData:pid encoding:NSUTF8StringEncoding];
        
        NSMutableString* strFid = [[NSMutableString alloc] init];
        unsigned char* ptr= (unsigned char*) [fid bytes];
        for(int i = 0; i < fid.length; i++)
            [strFid appendFormat:@"%02X", *ptr++ & 0xFF ];
        
        self.olFID.text = [NSString stringWithFormat:@"%@", strFid];
    });    
}

/*
- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
#warning Potentially incomplete method implementation.
    // Return the number of sections.
    return 0;
}
*/
/*
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
- (NSIndexPath *)tableView:(UITableView *)tableView willSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    UITableViewCell* cell = [tableView cellForRowAtIndexPath:indexPath];
    
    cell.selectionStyle = UITableViewCellSelectionStyleNone;
    
    return indexPath;
}

#define BATTERY_IDX (5)

- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    // Navigation logic may go here. Create and push another view controller.
    //NSLog(@"indexPath = %d", (int)indexPath.row);
    if(indexPath.row == BATTERY_IDX)
    {
        UIAlertView *alert
        = [[UIAlertView alloc]
           initWithTitle:@"Battery Calibration"
           message:@"This process will delete battery information from your ARETE POP. 1. After click YES, fully charge your ARETE POP until the red LED turn off. 2. Disconnect the charger and use your ARETE POP. 3.When your battery gets low, fully charged again."
           delegate:self
           cancelButtonTitle:@"NO"
           otherButtonTitles:@"YES",nil];
        [alert show];
    }
}

- (void)alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{
	if (buttonIndex == 1)
    {
        NSLog(@"battery calibarion");
        [[RcpApi2 sharedInstance] calGpAdc:255 max:0];
	}
}

- (void)viewDidUnload {
    [self setOlAppVersion:nil];
    [self setOlModel:nil];
    [self setOlPID:nil];
    [self setOlRegion:nil];
    [self setOlBattery:nil];
    [self setOlFID:nil];
    [super viewDidUnload];
}
@end
