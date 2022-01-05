// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface GroupController : UIViewController {
	UIBarButtonItem *_addRecipientBtn;
	UIBarButtonItem *_chooseFromBeneficiaryBtn;
	UITableView *_groupTableView;
	UILabel *_recipientCountLabel;
	UILabel *_totalAmountLabel;
	UIButton *_transferBtn;
}

@property (nonatomic, retain) IBOutlet UIBarButtonItem *addRecipientBtn;

@property (nonatomic, retain) IBOutlet UIBarButtonItem *chooseFromBeneficiaryBtn;

@property (nonatomic, retain) IBOutlet UITableView *groupTableView;

@property (nonatomic, retain) IBOutlet UILabel *recipientCountLabel;

@property (nonatomic, retain) IBOutlet UILabel *totalAmountLabel;

@property (nonatomic, retain) IBOutlet UIButton *transferBtn;

@end
