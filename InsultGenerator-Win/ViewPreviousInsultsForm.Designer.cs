using System.ComponentModel;

namespace InsultGenerator_Win
{
    partial class ViewPreviousInsultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveListButton = new System.Windows.Forms.Button();
            this.clearInsultArrayButton = new System.Windows.Forms.Button();
            this.insultListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveListButton
            // 
            this.saveListButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveListButton.Location = new System.Drawing.Point(408, 289);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(106, 43);
            this.saveListButton.TabIndex = 1;
            this.saveListButton.Text = "Save";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearInsultArrayButton
            // 
            this.clearInsultArrayButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearInsultArrayButton.Location = new System.Drawing.Point(296, 289);
            this.clearInsultArrayButton.Name = "clearInsultArrayButton";
            this.clearInsultArrayButton.Size = new System.Drawing.Size(106, 43);
            this.clearInsultArrayButton.TabIndex = 2;
            this.clearInsultArrayButton.Text = "Clear List";
            this.clearInsultArrayButton.UseVisualStyleBackColor = true;
            this.clearInsultArrayButton.Click += new System.EventHandler(this.clearInsultArrayButton_Click);
            // 
            // insultListLabel
            // 
            this.insultListLabel.Location = new System.Drawing.Point(12, 9);
            this.insultListLabel.Name = "insultListLabel";
            this.insultListLabel.Size = new System.Drawing.Size(502, 277);
            this.insultListLabel.TabIndex = 3;
            this.insultListLabel.Text = "There should be many insults here";
            // 
            // ViewPreviousInsultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(526, 344);
            this.Controls.Add(this.insultListLabel);
            this.Controls.Add(this.clearInsultArrayButton);
            this.Controls.Add(this.saveListButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ViewPreviousInsultsForm";
            this.Text = "Viewing Previously Generated Insults";
            this.Load += new System.EventHandler(this.ViewPreviousInsultsForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label insultListLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label InsultListLabel;

        private System.Windows.Forms.Button saveListButton;
        private System.Windows.Forms.Button clearInsultArrayButton;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}