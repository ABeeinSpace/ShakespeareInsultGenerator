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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton InsultGeneratorButton { get; set; }

		[Action ("GenerateInsultButtonPressed:")]
		partial void GenerateInsultButtonPressed (AppKit.NSButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (InsultGeneratorButton != null) {
				InsultGeneratorButton.Dispose ();
				InsultGeneratorButton = null;
			}

		}
	}
}
