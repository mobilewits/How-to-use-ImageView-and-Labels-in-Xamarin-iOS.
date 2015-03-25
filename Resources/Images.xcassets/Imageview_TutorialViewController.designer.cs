// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Imageview_Tutorial
{
	[Register ("Imageview_TutorialViewController")]
	partial class Imageview_TutorialViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageview { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_sample { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imageview != null) {
				imageview.Dispose ();
				imageview = null;
			}
			if (lbl_sample != null) {
				lbl_sample.Dispose ();
				lbl_sample = null;
			}
		}
	}
}
