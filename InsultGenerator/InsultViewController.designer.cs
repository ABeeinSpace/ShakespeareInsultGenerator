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
	[Register ("InsultViewController")]
	partial class InsultViewController
	{
		[Outlet]
		AppKit.NSButton GenerateAnInsultButton { get; set; }

		[Outlet]
		AppKit.NSTextField InsultLabel { get; set; }

		[Outlet]
		AppKit.NSButton PreviouslyGeneratedInsultsButton { get; set; }

		[Action ("GenerateAnInsultButtonPressed:")]
		partial void GenerateAnInsultButtonPressed (AppKit.NSButton sender);

		[Action ("PreviouslyGeneratedInsultsButtonPressed:")]
		partial void PreviouslyGeneratedInsultsButtonPressed (AppKit.NSButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (GenerateAnInsultButton != null) {
				GenerateAnInsultButton.Dispose ();
				GenerateAnInsultButton = null;
			}

			if (InsultLabel != null) {
				InsultLabel.Dispose ();
				InsultLabel = null;
			}

			if (PreviouslyGeneratedInsultsButton != null) {
				PreviouslyGeneratedInsultsButton.Dispose ();
				PreviouslyGeneratedInsultsButton = null;
			}

		}
	}
}
