using System;
using System.Collections.Generic;
using UIKit;

namespace GroupExperiment.Modules.Models
{
    public class MyPickerModel : UIPickerViewModel
    {
        List<string> pickerItems;

        //event handler to do something when item is chosen
        //and string variable to save which item was chosen
        public EventHandler ValueChanged;
        public string SelectedValue;

        //pass a list of strings when using this model
        public MyPickerModel(List<string> pickerItems)
        {
            this.pickerItems = pickerItems;
        }

        //number of rows in the pickerView
        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return pickerItems.Count;
        }

        //number of columns
        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        //title of the rows
        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            return pickerItems[(int) row];
        }

        //what should happen when item is selected
        //event handler is invoked here
        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            var item = pickerItems[(int)row];
            SelectedValue = item;

            ValueChanged ? .Invoke(null, null);
        }

    }
}
