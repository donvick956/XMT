using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using UIKit;
namespace GroupExperiment.Modules
{
    public class GroupTableSource : UITableViewSource
    {
        List<Recipient> tableItems;

        public GroupTableSource(List<Recipient> tableItems)
        {
            this.tableItems = tableItems;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("recipientCell") as CustomRecipientCell;
            if (cell == null)
            {
                cell = new CustomRecipientCell();
            }

            cell.Populate(tableItems[indexPath.Section].Name, tableItems[indexPath.Section].AccountNumber, tableItems[indexPath.Section].Bank, tableItems[indexPath.Section].AmountToRecieve);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return tableItems.Count;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 80f;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerView = new UIView();
            headerView.BackgroundColor = UIColor.Clear;
            return headerView;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return 0f;
        }
    }
}
