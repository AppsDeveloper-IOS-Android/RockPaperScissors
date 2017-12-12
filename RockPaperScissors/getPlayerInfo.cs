using Foundation;
using System;
using UIKit;

namespace RockPaperScissors
{
    public partial class getPlayerInfo : UIViewController
    {
        public getPlayerInfo (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton7660_TouchUpInside(UIButton sender)
        {
            UserData.Name = playerName.Text;
        }
    }
}