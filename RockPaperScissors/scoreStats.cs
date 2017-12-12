using Foundation;
using System;
using UIKit;

namespace RockPaperScissors
{
    public partial class scoreStats : UIViewController
    {
        public scoreStats (IntPtr handle) : base (handle)
        {
            
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            // cpuImage.Image = UIImage.FromBundle("paper");
            winCountLabel.Text = UserData.winCount.ToString();
            drawCountLabel.Text = UserData.drawCount.ToString();
            looseCountLabel.Text = UserData.loseCount.ToString();
            gameCountLabel.Text = UserData.gameCount.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}