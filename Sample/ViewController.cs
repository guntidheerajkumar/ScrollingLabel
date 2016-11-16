using System;
using CustomScrollingLabel;
using CoreGraphics;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var label = new ScrollLabel(new CGRect(20, 100, this.View.Frame.Width - 40, 30));
			label.TextColor = UIColor.Blue;
			label.Font = UIFont.SystemFontOfSize(14f);
			label.BackgroundColor = UIColor.Yellow;
			label.Text = "Good Evening Dheeraj, This is a scrolling Label.";
			this.View.AddSubview(label);
			label.BeginScrollWithDirection(ScrollLabelDirection.Left);
		}
	}
}
