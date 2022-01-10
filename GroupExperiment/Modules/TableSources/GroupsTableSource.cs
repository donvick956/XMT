using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace GroupExperiment.Modules
{
    //Commenting out old correct code to try new things

    public class GroupsTableSource : UITableViewSource
    {
        //provide list for the table and target viewcontroller to use the table
        List<BeneficiaryGroup> tableItems;
        CreateGroupController groupsController;

        public GroupsTableSource(List<BeneficiaryGroup> tableItems, CreateGroupController groupsController)
        {
            this.tableItems = tableItems;
            this.groupsController = groupsController;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("groupCell");
            cell.TextLabel.Text = tableItems[indexPath.Row].GroupName;
            cell.DetailTextLabel.Text = "Recipients: " + tableItems[indexPath.Row].Recipients.Count;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);

            //set groupname and send to next controller
            //groupsController.groupName = tableItems[indexPath.Row].GroupName;
            //groupsController.groupRecipients = tableItems[indexPath.Row].Recipients;
            groupsController.indexNumber = indexPath.Row;
            groupsController.PerformSegue("toGroupController", null);
        }
    }
}
