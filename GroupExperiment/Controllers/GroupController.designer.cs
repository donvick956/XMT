// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace GroupExperiment
{
	[Register ("GroupController")]
	partial class GroupController
	{
		[Outlet]
		UIKit.UIBarButtonItem addRecipientBtn { get; set; }

		[Outlet]
		UIKit.UIView alertBackgroundView { get; set; }

		[Outlet]
		UIKit.UIView alertView { get; set; }

		[Outlet]
		UIKit.UITextField amountTextField { get; set; }

		[Outlet]
		UIKit.UITextField bankTextField { get; set; }

		[Outlet]
		UIKit.UIButton cancelAlertBtn { get; set; }

		[Outlet]
		UIKit.UIBarButtonItem chooseFromBeneficiaryBtn { get; set; }

		[Outlet]
		UIKit.UITableView groupTableView { get; set; }

		[Outlet]
		UIKit.UITextField recipAcctTextField { get; set; }

		[Outlet]
		UIKit.UILabel recipientCountLabel { get; set; }

		[Outlet]
		UIKit.UILabel totalAmountLabel { get; set; }

		[Outlet]
		UIKit.UIButton transferBtn { get; set; }

		[Outlet]
		UIKit.UIButton verifyAddButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addRecipientBtn != null) {
				addRecipientBtn.Dispose ();
				addRecipientBtn = null;
			}

			if (alertBackgroundView != null) {
				alertBackgroundView.Dispose ();
				alertBackgroundView = null;
			}

			if (alertView != null) {
				alertView.Dispose ();
				alertView = null;
			}

			if (amountTextField != null) {
				amountTextField.Dispose ();
				amountTextField = null;
			}

			if (bankTextField != null) {
				bankTextField.Dispose ();
				bankTextField = null;
			}

			if (chooseFromBeneficiaryBtn != null) {
				chooseFromBeneficiaryBtn.Dispose ();
				chooseFromBeneficiaryBtn = null;
			}

			if (groupTableView != null) {
				groupTableView.Dispose ();
				groupTableView = null;
			}

			if (recipAcctTextField != null) {
				recipAcctTextField.Dispose ();
				recipAcctTextField = null;
			}

			if (recipientCountLabel != null) {
				recipientCountLabel.Dispose ();
				recipientCountLabel = null;
			}

			if (totalAmountLabel != null) {
				totalAmountLabel.Dispose ();
				totalAmountLabel = null;
			}

			if (transferBtn != null) {
				transferBtn.Dispose ();
				transferBtn = null;
			}

			if (verifyAddButton != null) {
				verifyAddButton.Dispose ();
				verifyAddButton = null;
			}

			if (cancelAlertBtn != null) {
				cancelAlertBtn.Dispose ();
				cancelAlertBtn = null;
			}
		}
	}
}
