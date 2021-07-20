// WARNING
// This file has been generated automatically by Rider IDE to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface InsultViewController : NSViewController {
	NSButton *_GenerateAnInsultButton;
	NSTextField *_InsultLabel;
	NSTextField *_InsultsTouchBarLabel;
	NSButton *_PreviouslyGeneratedInsultsButton;
}

@property (nonatomic, retain) IBOutlet NSButton *GenerateAnInsultButton;

@property (nonatomic, retain) IBOutlet NSTextField *InsultLabel;

@property (nonatomic, retain) IBOutlet NSTextField *InsultsTouchBarLabel;

@property (nonatomic, retain) IBOutlet NSButton *PreviouslyGeneratedInsultsButton;

- (IBAction)GenerateAnInsultButtonPressed:(NSButton *)sender;

- (IBAction)PreviouslyGeneratedInsultsButtonPressed:(NSButton *)sender;

@end
