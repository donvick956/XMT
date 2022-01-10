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
	[Register ("LoginController")]
	partial class LoginController
	{
		[Outlet]
		UIKit.UIView activityBackgroundView { get; set; }

		[Outlet]
		UIKit.UIImageView alatlogo { get; set; }

		[Outlet]
		UIKit.UITextField emailTextField { get; set; }

		[Outlet]
		UIKit.UIActivityIndicatorView indicator { get; set; }

		[Outlet]
		UIKit.UIButton loginBtn { get; set; }

		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (alatlogo != null) {
				alatlogo.Dispose ();
				alatlogo = null;
			}

			if (emailTextField != null) {
				emailTextField.Dispose ();
				emailTextField = null;
			}

			if (loginBtn != null) {
				loginBtn.Dispose ();
				loginBtn = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}

			if (indicator != null) {
				indicator.Dispose ();
				indicator = null;
			}

			if (activityBackgroundView != null) {
				activityBackgroundView.Dispose ();
				activityBackgroundView = null;
			}
		}
	}
}
