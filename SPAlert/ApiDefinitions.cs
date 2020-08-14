using Foundation;
using UIKit;

namespace PCPersonalCloud
{
    // @interface SPAlert : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC7SPAlert7SPAlert")]
	interface SPAlert
	{
		// +(void)presentWithTitle:(NSString * _Nonnull)title message:(NSString * _Nullable)message preset:(enum SPAlertPreset)preset;
		[Static]
		[Export("presentWithTitle:message:preset:")]
		void PresentPreset(string title, [NullAllowed] string message, SPAlertPreset preset);

		// +(void)presentWithTitle:(NSString * _Nonnull)title message:(NSString * _Nullable)message image:(UIImage * _Nonnull)image;
		[Static]
		[Export("presentWithTitle:message:image:")]
		void PresentCustom(string title, [NullAllowed] string message, UIImage image);

		// +(void)presentWithMessage:(NSString * _Nonnull)message haptic:(enum SPAlertHaptic)haptic;
		[Static]
		[Export("presentWithMessage:haptic:")]
		void PresentCustom(string message, SPAlertHaptic haptic);

		// +(void)presentWithTitle:(NSString * _Nonnull)title message:(NSString * _Nullable)message preset:(enum SPAlertPreset)preset durationInSeconds:(NSTimeInterval)durationInSeconds;
		[Static]
		[Export("presentWithTitle:message:preset:durationInSeconds:")]
		void PresentPreset(string title, [NullAllowed] string message, SPAlertPreset preset, double durationInSeconds);

		// +(void)presentWithTitle:(NSString * _Nonnull)title message:(NSString * _Nullable)message image:(UIImage * _Nonnull)image durationInSeconds:(NSTimeInterval)durationInSeconds;
		[Static]
		[Export("presentWithTitle:message:image:durationInSeconds:")]
		void PresentCustom(string title, [NullAllowed] string message, UIImage image, double durationInSeconds);

		// +(void)presentWithMessage:(NSString * _Nonnull)message durationInSeconds:(NSTimeInterval)durationInSeconds haptic:(enum SPAlertHaptic)haptic;
		[Static]
		[Export("presentWithMessage:durationInSeconds:haptic:")]
		void PresentCustom(string message, double durationInSeconds, SPAlertHaptic haptic);
	}
}
