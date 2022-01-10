using System;
using System.Net.Http;
using System.Threading.Tasks;
using HealthKit;
using UIKit;

namespace GroupExperiment.Modules.Utils
{
    public class MyUtils
    {
        public MyUtils()
        {
        }

        //Add shadow to any view
        public static void AddShadow(UIView view)
        {
            view.Layer.ShadowColor = UIColor.Black.CGColor;
            view.Layer.ShadowOpacity = 2.0f;
            view.Layer.ShadowOffset = new CoreGraphics.CGSize(-3, 3);
            view.Layer.ShadowRadius = 5;
        }

        public static void AddTextFieldShadow(UIView view)
        {
            view.Layer.ShadowColor = UIColor.LightGray.CGColor;
            view.Layer.ShadowOpacity = 2.0f;
            view.Layer.ShadowOffset = new CoreGraphics.CGSize(-3, 3);
            view.Layer.ShadowRadius = 5;
        }

        //close keyboards and responders on any view by tapping anywhere
        public static void ResignResponders(UIView view)
        {
            var tapRecognizer = new UITapGestureRecognizer(() => { view.EndEditing(true); });
            tapRecognizer.CancelsTouchesInView = false;
            view.AddGestureRecognizer(tapRecognizer);
        }

        //show different types of alerts
        public static UIAlertController alertController;

        public static void ShowSimpleAlert(string title, string message, UIViewController viewController)
        {
            alertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            var action = UIAlertAction.Create("Okay", UIAlertActionStyle.Default, null);

            alertController.AddAction(action);
            viewController.PresentViewController(alertController, true, null);
        }

        public static void ShowAlertWithTextField(string title, string message, UIViewController viewController, Action<UIAlertAction> alertAction)
        {
            alertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            var action = UIAlertAction.Create("cancel", UIAlertActionStyle.Cancel, null);
            var action2 = UIAlertAction.Create("done", UIAlertActionStyle.Default, alertAction);

            alertController.AddTextField((UITextField obj) => { });
            alertController.AddAction(action);
            alertController.AddAction(action2);

            viewController.PresentViewController(alertController, true, null);
        }

        public static HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
    }
}
