// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace InsultGenerator
{
    [Register ("PreviousInsultsViewController")]
    partial class PreviouInsultsViewController
    {
        [Outlet]
        AppKit.NSTextView InsultsTextView { get; set; }

        [Outlet]
        AppKit.NSButton SaveInsultsButton { get; set; }

        [Action ("SaveButtonPressed:")]
        partial void SaveButtonPressed (AppKit.NSButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (InsultsTextView != null) {
                InsultsTextView.Dispose ();
                InsultsTextView = null;
            }

            if (SaveInsultsButton != null) {
                SaveInsultsButton.Dispose ();
                SaveInsultsButton = null;
            }

        }
    }
}