using System;

using UIKit;
using ToastIOS;

namespace RockPaperScissors
{
    public partial class ViewController : UIViewController
    {
        Random rnd;
        String cpuChoice;
        String myChoice;
        String result;


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.



        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            // cpuImage.Image = UIImage.FromBundle("paper");
            playerLabel.Text = UserData.Name + " Choice!";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void ScissorsBtn_TouchUpInside(UIButton sender)
        {
            playerImage.Image = UIImage.FromBundle("scissors");
            myChoice = "scissors";
            Calculate();
        }

        partial void PaperBtn_TouchUpInside(UIButton sender)
        {
            playerImage.Image = UIImage.FromBundle("paper");
            myChoice = "paper";
            Calculate();
        }

        partial void RockBtn_TouchUpInside(UIButton sender)
        {
            playerImage.Image = UIImage.FromBundle("rock");
            myChoice = "rock";
            Calculate();
        }
        public void Calculate() {
            rnd = new Random();
            int cpu = rnd.Next(3);
            if (cpu == 0) {
                cpuChoice = "rock";
                cpuImage.Image = UIImage.FromBundle("rock");
            }
            if (cpu == 1) {
                cpuChoice = "paper";
                cpuImage.Image = UIImage.FromBundle("paper");
            }
            if (cpu == 2) {
                cpuChoice = "scissors";
                cpuImage.Image = UIImage.FromBundle("scissors");
            }
            if (myChoice.Equals("rock") && cpuChoice.Equals("paper"))
            {
                result = "You Lose!";
                UserData.loseCount++;
            }
            if (myChoice.Equals("rock") && cpuChoice.Equals("scissors"))
            {
                result = "You Win!";
                UserData.winCount++;
            }
            if (myChoice.Equals("paper") && cpuChoice.Equals("rock"))
            {
                result = "You Win!";
                UserData.winCount++;
            }
            if (myChoice.Equals("paper") && cpuChoice.Equals("scissors"))
            {
                result = "You Lose!";
                UserData.loseCount++;
            }
            if (myChoice.Equals("scissors") && cpuChoice.Equals("paper"))
            {
                result = "You Win!";
                UserData.winCount++;
            }
            if (myChoice.Equals("scissors") && cpuChoice.Equals("rock"))
            {
                result = "You Lose!";
                UserData.loseCount++;
            }
            if (myChoice.Equals(cpuChoice))
            {
                result = "Match Draw";
                UserData.drawCount++;
            }
            UserData.gameCount++;
            Toast.MakeText(UserData.Name + " " + result)
                .SetDuration(3000)
                .Show();




        }
    }
}
