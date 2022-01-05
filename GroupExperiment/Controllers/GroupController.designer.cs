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
		UIKit.UIBarButtonItem chooseFromBeneficiaryBtn { get; set; }

		[Outlet]
		UIKit.UITableView groupTableView { get; set; }

		[Outlet]
		UIKit.UILabel recipientCountLabel { get; set; }

		[Outlet]
		UIKit.UILabel totalAmountLabel { get; set; }

		[Outlet]
		UIKit.UIButton transferBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (groupTableView != null) {
				groupTableView.Dispose ();
				groupTableView = null;
			}

			if (transferBtn != null) {
				transferBtn.Dispose ();
				transferBtn = null;
			}

			if (recipientCountLabel != null) {
				recipientCountLabel.Dispose ();
				recipientCountLabel = null;
			}

			if (totalAmountLabel != null) {
				totalAmountLabel.Dispose ();
				totalAmountLabel = null;
			}

			if (addRecipientBtn != null) {
				addRecipientBtn.Dispose ();
				addRecipientBtn = null;
			}

			if (chooseFromBeneficiaryBtn != null) {
				chooseFromBeneficiaryBtn.Dispose ();
				chooseFromBeneficiaryBtn = null;
			}
		}
	}
}
