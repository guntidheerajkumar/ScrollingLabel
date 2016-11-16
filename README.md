# ScrollingLabel

Binding Project based on https://github.com/lovels/LBScrollLabel.

###Usage
```
var label = new ScrollLabel(new CGRect(20, 100, this.View.Frame.Width - 40, 30));
label.TextColor = UIColor.Blue;
label.Font = UIFont.SystemFontOfSize(14f);
label.BackgroundColor = UIColor.Yellow;
label.Text = "Good Evening Dheeraj, This is a scrolling Label.";
this.View.AddSubview(label);
label.BeginScrollWithDirection(ScrollLabelDirection.Left);
```
