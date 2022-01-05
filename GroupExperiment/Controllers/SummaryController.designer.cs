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
	[Register ("SummaryController")]
	partial class SummaryController
	{
		[Outlet]
		UIKit.UIButton confirmBtn { get; set; }

		[Outlet]
		UIKit.UILabel groupNameLabel { get; set; }

		[Outlet]
		UIKit.UIView groupSummaryCard { get; set; }

		[Outlet]
		UIKit.UILabel recipientsNumberLabel { get; set; }

		[Outlet]
		UIKit.UIView senderSummaryCard { get; set; }

		[Outlet]
		UIKit.UILabel totalAmountLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (confirmBtn != null) {
				confirmBtn.Dispose ();
				confirmBtn = null;
			}

			if (groupSummaryCard != null) {
				groupSummaryCard.Dispose ();
				groupSummaryCard = null;
			}

			if (senderSummaryCard != null) {
				senderSummaryCard.Dispose ();
				senderSummaryCard = null;
			}

			if (groupNameLabel != null) {
				groupNameLabel.Dispose ();
				groupNameLabel = null;
			}

			if (totalAmountLabel != null) {
				totalAmountLabel.Dispose ();
				totalAmountLabel = null;
			}

			if (recipientsNumberLabel != null) {
				recipientsNumberLabel.Dispose ();
				recipientsNumberLabel = null;
			}
		}
	}
}
