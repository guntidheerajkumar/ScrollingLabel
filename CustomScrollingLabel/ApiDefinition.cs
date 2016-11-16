using Foundation;
using ObjCRuntime;
using UIKit;
using System;
using CoreGraphics;

namespace CustomScrollingLabel
{
	// @interface ScrollLabel : UIView
	[BaseType(typeof(UIView))]
	interface ScrollLabel
	{
		// @property (nonatomic, strong) UIColor * textColor;
		[Export("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (copy, nonatomic) NSString * text;
		[Export("text")]
		string Text { get; set; }

		[Export("initWithFrame:")]
		IntPtr Constructor(CGRect frame);

		// @property (nonatomic) NSTextAlignment textAlignment;
		[Export("textAlignment", ArgumentSemantic.Assign)]
		UITextAlignment TextAlignment { get; set; }

		// @property (nonatomic) UIFont * font;
		[Export("font", ArgumentSemantic.Assign)]
		UIFont Font { get; set; }

		// -(void)beginScrollWithDirection:(ScrollLabelDirection)direction;
		[Export("beginScrollWithDirection:")]
		void BeginScrollWithDirection(ScrollLabelDirection direction);
	}
}
