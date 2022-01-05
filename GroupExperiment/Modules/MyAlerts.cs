using System;
using UIKit;
using Foundation;
using System.Linq;

namespace GroupExperiment.Modules
{
    public class MyAlerts
    {
        public MyAlerts()
        {
        }

        public UIAlertController alertController;

        public void ShowSimpleAlert(string title, string message, UIViewController viewController)
        {
            alertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            var action = UIAlertAction.Create("Okay", UIAlertActionStyle.Default, null);
            alertController.AddAction(action);

            viewController.PresentViewController(alertController, true, null);
        }

        public void ShowAlertWithTextField(string title, string message, UIViewController viewController, Action<UIAlertAction> alertAction)
        {
            alertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            var action = UIAlertAction.Create("cancel", UIAlertActionStyle.Cancel, null);
            var action2 = UIAlertAction.Create("done", UIAlertActionStyle.Default,alertAction);

            alertController.AddTextField((UITextField obj) => { });
            alertController.AddAction(action);
            alertController.AddAction(action2);

            viewController.PresentViewController(alertController, true, null);
        }

        public void ShowAddRecipientAlert(string title, string message, UIViewController viewController, Action<UIAlertAction> alertAction)
        {
            alertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            var action = UIAlertAction.Create("cancel", UIAlertActionStyle.Cancel, null);
            var action2 = UIAlertAction.Create("add", UIAlertActionStyle.Default, alertAction);

            alertController.AddTextField((UITextField obj) => { obj.Placeholder = "Bank name"; });
            alertController.AddTextField((UITextField obj) => { obj.Placeholder = "Account number"; });
            alertController.AddTextField((UITextField obj) => { obj.Placeholder = "Amount"; });
            alertController.AddAction(action);
            alertController.AddAction(action2);

            viewController.PresentViewController(alertController, true, null);
        }
    }
}
