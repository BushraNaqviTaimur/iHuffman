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

namespace HuffmaniProj
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnGenerate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textBox1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView textBox2 { get; set; }

        [Action ("BtnGenerate_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnGenerate_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnGenerate != null) {
                btnGenerate.Dispose ();
                btnGenerate = null;
            }

            if (textBox1 != null) {
                textBox1.Dispose ();
                textBox1 = null;
            }

            if (textBox2 != null) {
                textBox2.Dispose ();
                textBox2 = null;
            }
        }
    }
}