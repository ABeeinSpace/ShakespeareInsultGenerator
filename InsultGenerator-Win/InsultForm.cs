using System;
using System.Collections;
using System.Windows.Forms;

namespace InsultGenerator_Win
{
    public partial class InsultView : Form
    {
        private Random rng;
        public ArrayList generatedInsults;
        public InsultView()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string insult = InsultGeneratorInator(rng);
            label1.Text = insult;
        }
        
        // ReSharper disable once CommentTypo
        // InsultGeneratorInator()
        // Parameters: Random rng, ArrayList generatedInsult
        // Returns: string insult
        // Description: Generates an insult from three ArrayLists of possible values, saves it to the generatedInsults ArrayList so we can reference it later, and then returns the generated insult so that we can assign it to InsultLabel's StringValue later on. Technically I could do that here, but I didn't, so cry more. 
        // ReSharper disable once IdentifierTypo
        private string InsultGeneratorInator(Random rng) {
			
            // ReSharper disable once StringLiteralTypo
            string[] firstHalfOfInsultArray = new string[] {"warped", "rougish", "fobbing", "babbling"};
            string[] middleOfInsultArray = new string[] {"swag-bellied", "sheep-biting", "puke-stockinged", "hag-born"};
            // ReSharper disable once StringLiteralTypo
            string[] finalBitOfInsultArray = new string[] {"ruinous-butt!", "tyrant!", "misbegotten-divel!", "coward!"};

            string beginningOfInsult = (string)firstHalfOfInsultArray.GetValue(rng.Next(4));
            string middleOfInsult = (string)middleOfInsultArray.GetValue(rng.Next(4));
            string endOfInsult = (string)finalBitOfInsultArray.GetValue(rng.Next(4));

            var insult = $"Thou {beginningOfInsult} {middleOfInsult} {endOfInsult}";
            generatedInsults.Add(insult);
            return insult;
        }

        private void InsultView_Load(object sender, EventArgs e)
        {
            rng = new Random();
            generatedInsults = new ArrayList();
            string insult = InsultGeneratorInator(rng);
            label1.Text = insult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPreviousInsultsForm previousInsultsForm = new ViewPreviousInsultsForm(generatedInsults);
            previousInsultsForm.Show();
        }
    }
}