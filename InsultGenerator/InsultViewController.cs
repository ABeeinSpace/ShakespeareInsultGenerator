﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections;
using AppKit;

namespace InsultGenerator
{
	public partial class InsultViewController : NSViewController
	{
		public static ArrayList GeneratedInsults;
		private Random _rng;

		public InsultViewController(IntPtr handle) : base(handle)
		{
			
		}



		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
			_rng = new Random();
			GeneratedInsults = new ArrayList();
			// We have to do some trickery here in order to have an insult ready for the user when the window opens. In essence, what this does is it presses the button for the user so that I can use the code I've already written. 
			GenerateAnInsultButtonPressed(sender: GenerateAnInsultButton);
		}

		partial void GenerateAnInsultButtonPressed(NSButton sender)
		{
			string insult = InsultGeneratorInator(_rng);
			InsultLabel.StringValue = insult;
		}

		partial void PreviouslyGeneratedInsultsButtonPressed(NSButton sender)
		{
			var storyboard = NSStoryboard.FromName("Main", null);

			if (storyboard.InstantiateControllerWithIdentifier("PreviousInsultsWindowController") is NSWindowController controller) controller.ShowWindow(sender);
		}
		
		// ReSharper disable once CommentTypo
		// InsultGeneratorInator()
		// Parameters: Random rng, ArrayList generatedInsult
		// Returns: string insult
		// Description: Generates an insult from three ArrayLists of possible values, saves it to the generatedInsults ArrayList so we can reference it later, and then returns the generated insult so that we can assign it to InsultLabel's StringValue later on. Technically I could do that here, but I didn't, so cry more. 
		// ReSharper disable once IdentifierTypo
		private string InsultGeneratorInator(Random rng) {
			
			// ReSharper disable once StringLiteralTypo
			string[] firstHalfOfInsultArray = new string[] {"warped", "rougish", "fobbing", "babbling", "surly", };
			string[] middleOfInsultArray = new string[] {"swag-bellied", "sheep-biting", "puke-stockinged", "hag-born", "soulless", "dread-bolted"};
			// ReSharper disable once StringLiteralTypo
			string[] finalBitOfInsultArray = new string[] {"ruinous-butt!", "tyrant!", "misbegotten-divel!", "coward!", "miscreant!", "vassal!"};

			string beginningOfInsult = (string)firstHalfOfInsultArray.GetValue(rng.Next(firstHalfOfInsultArray.Length));
			string middleOfInsult = (string)middleOfInsultArray.GetValue(rng.Next(middleOfInsultArray.Length));
			string endOfInsult = (string)finalBitOfInsultArray.GetValue(rng.Next(finalBitOfInsultArray.Length));

			var insult = $"Thou {beginningOfInsult} {middleOfInsult} {endOfInsult}";
			GeneratedInsults.Add(insult);
			return insult;
		}

		public void ClearLabel()
		{
			InsultLabel.StringValue = String.Empty;
		}
	}
}
