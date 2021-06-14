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
	[Register ("PreviousInsultsController")]
	partial class PreviousInsultsController
	{
		[Outlet]
		AppKit.NSButton ClearInsultsButton { get; set; }

		[Outlet]
		AppKit.NSTextView InsultsTextView { get; set; }

		[Outlet]
		AppKit.NSButton SaveInsultsButton { get; set; }

		[Action ("ClearInsultsButtonClicked:")]
		partial void ClearInsultsButtonClicked (AppKit.NSButton sender);

		[Action ("SaveInsultsButtonClicked:")]
		partial void SaveInsultsButtonClicked (AppKit.NSButton sender);

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

			if (ClearInsultsButton != null) {
				ClearInsultsButton.Dispose ();
				ClearInsultsButton = null;
			}

		}
	}
}
