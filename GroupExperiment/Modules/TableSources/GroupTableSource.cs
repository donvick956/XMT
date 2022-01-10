using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using GroupExperiment.Modules.Models;
using GroupExperiment.Modules.Utils;
using UIKit;

namespace GroupExperiment.Modules
{
    public class GroupTableSource : UITableViewSource
    {
        List<Recipient> tableItems;
        GroupController groupPage;

        public GroupTableSource(List<Recipient> tableItems, GroupController groupPage)
        {
            this.tableItems = tableItems;
            this.groupPage = groupPage;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("recipientCell") as CustomRecipientCell;
            if (cell == null)
            {
                cell = new CustomRecipientCell();
            }

            cell.Populate(tableItems[indexPath.Section].AccountName, tableItems[indexPath.Section].AccountNumber, tableItems[indexPath.Section].Bank, tableItems[indexPath.Section].AmountToRecieve);

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

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            string name = tableItems[indexPath.Section].AccountName;
            MyUtils.ShowSimpleAlert("Name", name, groupPage);

            tableView.DeselectRow(indexPath, true);
        }

        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            if(editingStyle == UITableViewCellEditingStyle.Delete)
            {
                tableItems.RemoveAt(indexPath.Section);
                tableView.DeleteSections(NSIndexSet.FromIndex(indexPath.Section), UITableViewRowAnimation.Fade);
                groupPage.UpdateRecipientCount();
                groupPage.UpdateTotalAmount();
                groupPage.recipientDTOList.RemoveAt(indexPath.Section);
            }
        }

        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            return true;
        }

    }
}
