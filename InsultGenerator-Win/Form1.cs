using System;
using System.Windows.Forms;

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
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/ABeeinSpace/ShakespeareInsultGenerator/releases/");
        }
    }
}
