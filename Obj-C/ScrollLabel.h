//
//  ScrollLabel.h
//  ScrollLabelDemo
//
//  Created by luobbe on 15/9/26.
//  Copyright (c) 2015年 luobbe. All rights reserved.
//

#import <UIKit/UIKit.h>

typedef NS_ENUM(NSInteger,ScrollLabelDirection) {
    ScrollLabelDirection_Top,         //from bottom to top
    ScrollLabelDirection_Bottom,
    ScrollLabelDirection_Left,
    ScrollLabelDirection_Right,
};

//default speed 10
#define ScrollSpeed     10

@interface ScrollLabel : UIView

@property (nonatomic, strong) UIColor *textColor;
@property (nonatomic, copy) NSString *text;
@property (nonatomic) NSTextAlignment textAlignment;
@property (nonatomic) UIFont *font;

- (void)beginScrollWithDirection:(ScrollLabelDirection)direction; /** move labels*/

@end
