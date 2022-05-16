namespace Tests___Project
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.QuestionButton = new System.Windows.Forms.Button();
            this.BloodButton = new System.Windows.Forms.Button();
            this.Patient_Info = new System.Windows.Forms.ListBox();
            this.Dismiss = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.QuestionButton.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuestionButton.ForeColor = System.Drawing.Color.Red;
            this.QuestionButton.Location = new System.Drawing.Point(394, 687);
            this.QuestionButton.Margin = new System.Windows.Forms.Padding(5);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(180, 100);
            this.QuestionButton.TabIndex = 0;
            this.QuestionButton.Text = "Question Form";
            this.QuestionButton.UseVisualStyleBackColor = false;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // BloodButton
            // 
            this.BloodButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BloodButton.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BloodButton.ForeColor = System.Drawing.Color.Red;
            this.BloodButton.Location = new System.Drawing.Point(204, 687);
            this.BloodButton.Margin = new System.Windows.Forms.Padding(5);
            this.BloodButton.Name = "BloodButton";
            this.BloodButton.Size = new System.Drawing.Size(180, 100);
            this.BloodButton.TabIndex = 5;
            this.BloodButton.Text = "Import Blood Test";
            this.BloodButton.UseVisualStyleBackColor = false;
            this.BloodButton.Click += new System.EventHandler(this.BloodButton_Click);
            // 
            // Patient_Info
            // 
            this.Patient_Info.FormattingEnabled = true;
            this.Patient_Info.ItemHeight = 31;
            this.Patient_Info.Location = new System.Drawing.Point(20, 232);
            this.Patient_Info.Margin = new System.Windows.Forms.Padding(5);
            this.Patient_Info.Name = "Patient_Info";
            this.Patient_Info.Size = new System.Drawing.Size(554, 407);
            this.Patient_Info.TabIndex = 9;
            this.Patient_Info.SelectedIndexChanged += new System.EventHandler(this.Patient_Info_SelectedIndexChanged);
            // 
            // Dismiss
            // 
            this.Dismiss.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Dismiss.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dismiss.ForeColor = System.Drawing.Color.Red;
            this.Dismiss.Location = new System.Drawing.Point(394, 91);
            this.Dismiss.Margin = new System.Windows.Forms.Padding(5);
            this.Dismiss.Name = "Dismiss";
            this.Dismiss.Size = new System.Drawing.Size(180, 100);
            this.Dismiss.TabIndex = 10;
            this.Dismiss.Text = "Dismiss Patient";
            this.Dismiss.UseVisualStyleBackColor = false;
            this.Dismiss.Click += new System.EventHandler(this.Dismiss_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Patient Information:";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CloseButton.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(754, 687);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(180, 100);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(957, 41);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(113, 35);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(14, 687);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 100);
            this.button1.TabIndex = 14;
            this.button1.Text = "Diagnose Patient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.InfoButton.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoButton.ForeColor = System.Drawing.Color.Red;
            this.InfoButton.Location = new System.Drawing.Point(20, 91);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(5);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(180, 100);
            this.InfoButton.TabIndex = 6;
            this.InfoButton.Text = "Enter Patient Info";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(697, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 146);
            this.panel1.TabIndex = 19;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(957, 801);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dismiss);
            this.Controls.Add(this.Patient_Info);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.BloodButton);
            this.Controls.Add(this.QuestionButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button QuestionButton;
        private Button BloodButton;
        private ListBox Patient_Info;
        private Button Dismiss;
        private Label label3;
        private Button CloseButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Button button1;
        private Button InfoButton;
        private Panel panel1;
    }
}