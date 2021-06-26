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
	[Register ("PreferencesViewController")]
	partial class PreferencesViewController
	{
		[Outlet]
		AppKit.NSComboBox AppearanceComboBox { get; set; }

		[Outlet]
		AppKit.NSSwitch TouchBarEnableSwitch { get; set; }

		[Action ("AppearanceComboBoxChanged:")]
		partial void AppearanceComboBoxChanged (AppKit.NSComboBox sender);

		[Action ("TouchBarSwitchStateChanged:")]
		partial void TouchBarSwitchStateChanged (AppKit.NSSwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (TouchBarEnableSwitch != null) {
				TouchBarEnableSwitch.Dispose ();
				TouchBarEnableSwitch = null;
			}

			if (AppearanceComboBox != null) {
				AppearanceComboBox.Dispose ();
				AppearanceComboBox = null;
			}

		}
	}
}
