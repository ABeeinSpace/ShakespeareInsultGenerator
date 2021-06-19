// WARNING
// This file has been generated automatically by Rider IDE to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface PreviousInsultsController : NSViewController {
	NSButton *_ClearInsultsButton;
	NSTextView *_InsultsTextView;
	NSButton *_SaveInsultsButton;
	NSTextField *_SaveResultTextField;
}

@property (nonatomic, retain) IBOutlet NSButton *ClearInsultsButton;

@property (nonatomic, retain) IBOutlet NSTextView *InsultsTextView;

@property (nonatomic, retain) IBOutlet NSButton *SaveInsultsButton;

@property (nonatomic, retain) IBOutlet NSTextField *SaveResultTextField;

- (IBAction)ClearInsultsButtonClicked:(NSButton *)sender;

- (IBAction)SaveInsultsButtonClicked:(NSButton *)sender;

@end
