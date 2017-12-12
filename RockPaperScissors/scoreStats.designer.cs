// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RockPaperScissors
{
    [Register ("scoreStats")]
    partial class scoreStats
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel drawCountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel gameCountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel looseCountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel winCountLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (drawCountLabel != null) {
                drawCountLabel.Dispose ();
                drawCountLabel = null;
            }

            if (gameCountLabel != null) {
                gameCountLabel.Dispose ();
                gameCountLabel = null;
            }

            if (looseCountLabel != null) {
                looseCountLabel.Dispose ();
                looseCountLabel = null;
            }

            if (winCountLabel != null) {
                winCountLabel.Dispose ();
                winCountLabel = null;
            }
        }
    }
}