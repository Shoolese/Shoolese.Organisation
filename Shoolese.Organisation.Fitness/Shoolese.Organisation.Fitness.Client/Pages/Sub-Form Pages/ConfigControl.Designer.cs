namespace Shoolese.Organisation.Fitness.Client.Pages.Sub_Form_Pages
{
    partial class ConfigControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_ok = new Button();
            dob_set = new DateTimePicker();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_ok, 1, 1);
            tableLayoutPanel1.Controls.Add(dob_set, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(442, 276);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_ok
            // 
            btn_ok.Dock = DockStyle.Fill;
            btn_ok.Location = new Point(224, 141);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(215, 132);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // dob_set
            // 
            dob_set.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dob_set.Location = new Point(224, 57);
            dob_set.Name = "dob_set";
            dob_set.Size = new Size(215, 23);
            dob_set.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 61);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 2;
            label1.Text = "Date of Birth:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfigControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ConfigControl";
            Size = new Size(442, 276);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_ok;
        private DateTimePicker dob_set;
        private Label label1;
    }
}
