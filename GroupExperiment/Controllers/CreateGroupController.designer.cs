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
	[Register ("CreateGroupController")]
	partial class CreateGroupController
	{
		[Outlet]
		UIKit.UIBarButtonItem addNewGroupBtn { get; set; }

		[Outlet]
		UIKit.UIButton createGroupBtn { get; set; }

		[Outlet]
		UIKit.UILabel createGroupLabel { get; set; }

		[Outlet]
		UIKit.UITableView groupsTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (createGroupBtn != null) {
				createGroupBtn.Dispose ();
				createGroupBtn = null;
			}

			if (createGroupLabel != null) {
				createGroupLabel.Dispose ();
				createGroupLabel = null;
			}

			if (groupsTable != null) {
				groupsTable.Dispose ();
				groupsTable = null;
			}

			if (addNewGroupBtn != null) {
				addNewGroupBtn.Dispose ();
				addNewGroupBtn = null;
			}
		}
	}
}
