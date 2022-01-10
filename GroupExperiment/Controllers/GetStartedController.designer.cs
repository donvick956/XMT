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
	[Register ("GetStartedController")]
	partial class GetStartedController
	{
		[Outlet]
		UIKit.UITextField accountTypeTextField { get; set; }

		[Outlet]
		UIKit.UITextField addressTextField { get; set; }

		[Outlet]
		UIKit.UITextField confirmPasswordTextField { get; set; }

		[Outlet]
		UIKit.UIButton createAccountBtn { get; set; }

		[Outlet]
		UIKit.UITextField emailTextField { get; set; }

		[Outlet]
		UIKit.UITextField firstNameTextField { get; set; }

		[Outlet]
		UIKit.UITextField lastNameTextField { get; set; }

		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		UIKit.UITextField phoneNumberTextField { get; set; }

		[Outlet]
		UIKit.UITextField setPinTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (firstNameTextField != null) {
				firstNameTextField.Dispose ();
				firstNameTextField = null;
			}

			if (lastNameTextField != null) {
				lastNameTextField.Dispose ();
				lastNameTextField = null;
			}

			if (addressTextField != null) {
				addressTextField.Dispose ();
				addressTextField = null;
			}

			if (phoneNumberTextField != null) {
				phoneNumberTextField.Dispose ();
				phoneNumberTextField = null;
			}

			if (emailTextField != null) {
				emailTextField.Dispose ();
				emailTextField = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}

			if (confirmPasswordTextField != null) {
				confirmPasswordTextField.Dispose ();
				confirmPasswordTextField = null;
			}

			if (accountTypeTextField != null) {
				accountTypeTextField.Dispose ();
				accountTypeTextField = null;
			}

			if (setPinTextField != null) {
				setPinTextField.Dispose ();
				setPinTextField = null;
			}

			if (createAccountBtn != null) {
				createAccountBtn.Dispose ();
				createAccountBtn = null;
			}
		}
	}
}
