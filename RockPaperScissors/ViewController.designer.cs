// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RockPaperScissors
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView cpuImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton paperBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView playerImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel playerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton rockBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton scissorsBtn { get; set; }

        [Action ("PaperBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PaperBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("RockBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RockBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("ScissorsBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ScissorsBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (cpuImage != null) {
                cpuImage.Dispose ();
                cpuImage = null;
            }

            if (paperBtn != null) {
                paperBtn.Dispose ();
                paperBtn = null;
            }

            if (playerImage != null) {
                playerImage.Dispose ();
                playerImage = null;
            }

            if (playerLabel != null) {
                playerLabel.Dispose ();
                playerLabel = null;
            }

            if (rockBtn != null) {
                rockBtn.Dispose ();
                rockBtn = null;
            }

            if (scissorsBtn != null) {
                scissorsBtn.Dispose ();
                scissorsBtn = null;
            }
        }
    }
}