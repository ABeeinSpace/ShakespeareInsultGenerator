using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace InsultGenerator_Win
{
    public partial class ViewPreviousInsultsForm : Form
    {
        private ArrayList generatedInsults;
        private string generatedInsultsString;
        
        public ViewPreviousInsultsForm(ArrayList generatedInsults)
        {
            InitializeComponent();
            this.generatedInsults = generatedInsults;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save things here.
            SaveFileDialog saveInsultsDialog = new SaveFileDialog();
            saveInsultsDialog.Title = "Save Insult List";
            saveInsultsDialog.Filter = "Text File|*.txt";
            saveInsultsDialog.ShowDialog();
            if (saveInsultsDialog.FileName != "")
            {
                StreamWriter fs = new StreamWriter(saveInsultsDialog.OpenFile());
                fs.Write(generatedInsultsString);
                fs.Close();
            }
        
        }

        private void clearInsultArrayButton_Click(object sender, EventArgs e)
        {
            generatedInsults.Clear();
            Application.OpenForms[1].Close();
            this.Close();
        }

        private void ViewPreviousInsultsForm_Load(object sender, EventArgs e)
        {
            generatedInsultsString = "";
            for (int i = 0; i < generatedInsults.Count; i++)
            {
                generatedInsultsString += generatedInsults[i] + "\n\n";
            }

            insultListLabel.Text = generatedInsultsString;
        }
    }
}