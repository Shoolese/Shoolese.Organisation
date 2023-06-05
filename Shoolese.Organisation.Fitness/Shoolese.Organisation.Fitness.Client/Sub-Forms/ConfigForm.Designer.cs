namespace Shoolese.Organisation.Fitness.Client.Sub_Forms
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            configControl1 = new Pages.Sub_Form_Pages.ConfigControl();
            SuspendLayout();
            // 
            // configControl1
            // 
            configControl1.Dock = DockStyle.Fill;
            configControl1.Location = new Point(0, 0);
            configControl1.Name = "configControl1";
            configControl1.Size = new Size(800, 450);
            configControl1.TabIndex = 0;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(configControl1);
            Name = "ConfigForm";
            Text = "ConfigForm";
            ResumeLayout(false);
        }

        #endregion

        private Pages.Sub_Form_Pages.ConfigControl configControl1;
    }
}