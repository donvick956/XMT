using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace GroupExperiment.Modules
{
    public class GroupsTableSource : UITableViewSource
    {
        List<BeneficiaryGroup> tableItems;

        public GroupsTableSource(List<BeneficiaryGroup> tableItems)
        {
            this.tableItems = tableItems;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("groupCell");
            cell.TextLabel.Text = tableItems[indexPath.Row].GroupName;
            cell.DetailTextLabel.Text = "Recipients: " + tableItems[indexPath.Row].NumOfRecipients;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }
    }
}
