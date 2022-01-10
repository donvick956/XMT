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
		UIKit.UILabel accBalanceLabel { get; set; }

		[Outlet]
		UIKit.UILabel accNumberLabel { get; set; }

		[Outlet]
		UIKit.UILabel accTypeLabel { get; set; }

		[Outlet]
		UIKit.UIButton cancelPinBtn { get; set; }

		[Outlet]
		UIKit.UIButton confirmBtn { get; set; }

		[Outlet]
		UIKit.UIView enterPinBackgroundView { get; set; }

		[Outlet]
		UIKit.UIView enterPinView { get; set; }

		[Outlet]
		UIKit.UILabel groupNameLabel { get; set; }

		[Outlet]
		UIKit.UIView groupSummaryCard { get; set; }

		[Outlet]
		UIKit.UIButton okayBtn { get; set; }

		[Outlet]
		UIKit.UITextField pinTextField { get; set; }

		[Outlet]
		UIKit.UILabel recipientsNumberLabel { get; set; }

		[Outlet]
		UIKit.UITextField remarkTextField { get; set; }

		[Outlet]
		UIKit.UIView senderSummaryCard { get; set; }

		[Outlet]
		UIKit.UILabel totalAmountLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (accBalanceLabel != null) {
				accBalanceLabel.Dispose ();
				accBalanceLabel = null;
			}

			if (accNumberLabel != null) {
				accNumberLabel.Dispose ();
				accNumberLabel = null;
			}

			if (accTypeLabel != null) {
				accTypeLabel.Dispose ();
				accTypeLabel = null;
			}

			if (confirmBtn != null) {
				confirmBtn.Dispose ();
				confirmBtn = null;
			}

			if (groupNameLabel != null) {
				groupNameLabel.Dispose ();
				groupNameLabel = null;
			}

			if (groupSummaryCard != null) {
				groupSummaryCard.Dispose ();
				groupSummaryCard = null;
			}

			if (recipientsNumberLabel != null) {
				recipientsNumberLabel.Dispose ();
				recipientsNumberLabel = null;
			}

			if (senderSummaryCard != null) {
				senderSummaryCard.Dispose ();
				senderSummaryCard = null;
			}

			if (totalAmountLabel != null) {
				totalAmountLabel.Dispose ();
				totalAmountLabel = null;
			}

			if (enterPinBackgroundView != null) {
				enterPinBackgroundView.Dispose ();
				enterPinBackgroundView = null;
			}

			if (enterPinView != null) {
				enterPinView.Dispose ();
				enterPinView = null;
			}

			if (pinTextField != null) {
				pinTextField.Dispose ();
				pinTextField = null;
			}

			if (okayBtn != null) {
				okayBtn.Dispose ();
				okayBtn = null;
			}

			if (cancelPinBtn != null) {
				cancelPinBtn.Dispose ();
				cancelPinBtn = null;
			}

			if (remarkTextField != null) {
				remarkTextField.Dispose ();
				remarkTextField = null;
			}
		}
	}
}
