#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>

@class __monomac_internal_ActionDispatcher;
@class NSApplicationDelegate;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class __NSGestureRecognizerToken;
@class __NSGestureRecognizerParameterlessToken;
@class __NSGestureRecognizerParametrizedToken;
@class __NSClickGestureRecognizer;
@class __NSMagnificationGestureRecognizer;
@class __NSPanGestureRecognizer;
@class __NSPressGestureRecognizer;
@class __NSRotationGestureRecognizer;
@class __NSObject_Disposer;
@class AppPreferences;
@class InsultViewController;
@class AppDelegate;
@class PreferencesViewController;
@class ViewController;
@class PreviousInsultsController;

@interface NSApplicationDelegate : NSObject<NSApplicationDelegate> {
}
	-(id) init;
@end

@interface __NSGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __NSGestureRecognizerParameterlessToken : __NSGestureRecognizerToken {
}
	-(void) target;
@end

@interface __NSGestureRecognizerParametrizedToken : __NSGestureRecognizerToken {
}
	-(void) target:(NSGestureRecognizer *)p0;
@end

@interface AppPreferences : NSObject {
}
	@property (nonatomic, assign) BOOL DefaultTouchBarState;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) DefaultTouchBarState;
	-(void) setDefaultTouchBarState:(BOOL)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface InsultViewController : NSViewController {
}
	@property (nonatomic, assign) NSButton * GenerateAnInsultButton;
	@property (nonatomic, assign) NSTextField * InsultLabel;
	@property (nonatomic, assign) NSTextField * InsultsTouchBarLabel;
	@property (nonatomic, assign) NSButton * PreviouslyGeneratedInsultsButton;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSButton *) GenerateAnInsultButton;
	-(void) setGenerateAnInsultButton:(NSButton *)p0;
	-(NSTextField *) InsultLabel;
	-(void) setInsultLabel:(NSTextField *)p0;
	-(NSTextField *) InsultsTouchBarLabel;
	-(void) setInsultsTouchBarLabel:(NSTextField *)p0;
	-(NSButton *) PreviouslyGeneratedInsultsButton;
	-(void) setPreviouslyGeneratedInsultsButton:(NSButton *)p0;
	-(void) viewDidLoad;
	-(void) GenerateAnInsultButtonPressed:(NSButton *)p0;
	-(void) PreviouslyGeneratedInsultsButtonPressed:(NSButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface AppDelegate : NSObject<NSApplicationDelegate, NSApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) applicationDidFinishLaunching:(NSNotification *)p0;
	-(void) applicationWillTerminate:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface PreferencesViewController : NSViewController {
}
	@property (nonatomic, assign) NSComboBox * AppearanceComboBox;
	@property (nonatomic, assign) NSSwitch * TouchBarEnableSwitch;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSComboBox *) AppearanceComboBox;
	-(void) setAppearanceComboBox:(NSComboBox *)p0;
	-(NSSwitch *) TouchBarEnableSwitch;
	-(void) setTouchBarEnableSwitch:(NSSwitch *)p0;
	-(void) AppearanceComboBoxChanged:(NSComboBox *)p0;
	-(void) TouchBarSwitchStateChanged:(NSSwitch *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ViewController : NSViewController {
}
	@property (nonatomic, assign) NSButton * InsultGeneratorButton;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSButton *) InsultGeneratorButton;
	-(void) setInsultGeneratorButton:(NSButton *)p0;
	-(void) GenerateInsultButtonPressed:(NSButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface PreviousInsultsController : NSViewController {
}
	@property (nonatomic, assign) NSButton * ClearInsultsButton;
	@property (nonatomic, assign) NSTextView * InsultsTextView;
	@property (nonatomic, assign) NSButton * SaveInsultsButton;
	@property (nonatomic, assign) NSTextField * SaveResultTextField;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSButton *) ClearInsultsButton;
	-(void) setClearInsultsButton:(NSButton *)p0;
	-(NSTextView *) InsultsTextView;
	-(void) setInsultsTextView:(NSTextView *)p0;
	-(NSButton *) SaveInsultsButton;
	-(void) setSaveInsultsButton:(NSButton *)p0;
	-(NSTextField *) SaveResultTextField;
	-(void) setSaveResultTextField:(NSTextField *)p0;
	-(void) saveDocumentAs:(NSObject *)p0;
	-(void) viewDidLoad;
	-(void) ClearInsultsButtonClicked:(NSButton *)p0;
	-(void) SaveInsultsButtonClicked:(NSButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end


