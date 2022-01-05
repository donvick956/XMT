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
	[Register ("CustomRecipientCell")]
	partial class CustomRecipientCell
	{
		[Outlet]
		UIKit.UILabel recipAccNumLabel { get; set; }

		[Outlet]
		UIKit.UILabel recipAmountLabel { get; set; }

		[Outlet]
		UIKit.UILabel recipBankLabel { get; set; }

		[Outlet]
		UIKit.UILabel recipNameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (recipNameLabel != null) {
				recipNameLabel.Dispose ();
				recipNameLabel = null;
			}

			if (recipAccNumLabel != null) {
				recipAccNumLabel.Dispose ();
				recipAccNumLabel = null;
			}

			if (recipBankLabel != null) {
				recipBankLabel.Dispose ();
				recipBankLabel = null;
			}

			if (recipAmountLabel != null) {
				recipAmountLabel.Dispose ();
				recipAmountLabel = null;
			}
		}
	}
}
