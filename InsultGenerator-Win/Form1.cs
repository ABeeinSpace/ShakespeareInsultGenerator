using System;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace InsultGenerator_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsultView form = new InsultView();
            form.Show();
        }

        private void checkForUpdatesButton_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://rbsoft.org/updates/AutoUpdaterTest.xml");
            // string message = "You have version " + Application.ProductVersion + ". Pressing OK will open the GitHub releases page for this program so that you can look for any updates. (I know this isn't great, I'm working on making this better)";
            // string caption = "Checking for Updates";
            // var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            // if (result == DialogResult.OK)
            // {
            //     System.Diagnostics.Process.Start("explorer.exe", "https://github.com/ABeeinSpace/ShakespeareInsultGenerator/releases/");
            }
        }
    }
}
