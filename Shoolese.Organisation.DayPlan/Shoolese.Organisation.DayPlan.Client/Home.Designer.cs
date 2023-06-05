namespace Shoolese.Organisation.DayPlan.Client
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tb_home = new TabPage();
            tb_manage_high_level_tasks = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tb_home);
            tabControl1.Controls.Add(tb_manage_high_level_tasks);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1373, 664);
            tabControl1.TabIndex = 0;
            // 
            // tb_home
            // 
            tb_home.Location = new Point(4, 24);
            tb_home.Name = "tb_home";
            tb_home.Padding = new Padding(3);
            tb_home.Size = new Size(1365, 636);
            tb_home.TabIndex = 0;
            tb_home.Text = "Home";
            tb_home.UseVisualStyleBackColor = true;
            // 
            // tb_manage_high_level_tasks
            // 
            tb_manage_high_level_tasks.Location = new Point(4, 24);
            tb_manage_high_level_tasks.Name = "tb_manage_high_level_tasks";
            tb_manage_high_level_tasks.Padding = new Padding(3);
            tb_manage_high_level_tasks.Size = new Size(1365, 636);
            tb_manage_high_level_tasks.TabIndex = 1;
            tb_manage_high_level_tasks.Text = "Manage High Level Tasks";
            tb_manage_high_level_tasks.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 664);
            Controls.Add(tabControl1);
            Name = "Home";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tb_home;
        private TabPage tb_manage_high_level_tasks;
    }
}