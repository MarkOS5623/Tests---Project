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
            this.QuestionButton = new System.Windows.Forms.Button();
            this.SymptomsBox = new System.Windows.Forms.ListBox();
            this.Illments = new System.Windows.Forms.ListBox();
            this.BloodButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Patient_Info = new System.Windows.Forms.ListBox();
            this.Dismiss = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionButton
            // 
            this.QuestionButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionButton.Location = new System.Drawing.Point(521, 351);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(144, 66);
            this.QuestionButton.TabIndex = 0;
            this.QuestionButton.Text = "Question Form";
            this.QuestionButton.UseVisualStyleBackColor = true;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // SymptomsBox
            // 
            this.SymptomsBox.FormattingEnabled = true;
            this.SymptomsBox.ItemHeight = 20;
            this.SymptomsBox.Location = new System.Drawing.Point(336, 85);
            this.SymptomsBox.Name = "SymptomsBox";
            this.SymptomsBox.Size = new System.Drawing.Size(162, 244);
            this.SymptomsBox.TabIndex = 3;
            this.SymptomsBox.SelectedIndexChanged += new System.EventHandler(this.SymptomsBox_SelectedIndexChanged);
            // 
            // Illments
            // 
            this.Illments.FormattingEnabled = true;
            this.Illments.ItemHeight = 20;
            this.Illments.Location = new System.Drawing.Point(495, 85);
            this.Illments.Name = "Illments";
            this.Illments.Size = new System.Drawing.Size(170, 244);
            this.Illments.TabIndex = 4;
            // 
            // BloodButton
            // 
            this.BloodButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodButton.Location = new System.Drawing.Point(336, 351);
            this.BloodButton.Name = "BloodButton";
            this.BloodButton.Size = new System.Drawing.Size(144, 66);
            this.BloodButton.TabIndex = 5;
            this.BloodButton.Text = "Import Blood Test";
            this.BloodButton.UseVisualStyleBackColor = true;
            this.BloodButton.Click += new System.EventHandler(this.BloodButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoButton.Location = new System.Drawing.Point(12, 50);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(144, 66);
            this.InfoButton.TabIndex = 6;
            this.InfoButton.Text = "Enter Patient Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(495, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Possible diagnosis";
            // 
            // Patient_Info
            // 
            this.Patient_Info.FormattingEnabled = true;
            this.Patient_Info.ItemHeight = 20;
            this.Patient_Info.Location = new System.Drawing.Point(12, 150);
            this.Patient_Info.Name = "Patient_Info";
            this.Patient_Info.Size = new System.Drawing.Size(305, 264);
            this.Patient_Info.TabIndex = 9;
            // 
            // Dismiss
            // 
            this.Dismiss.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dismiss.Location = new System.Drawing.Point(173, 50);
            this.Dismiss.Name = "Dismiss";
            this.Dismiss.Size = new System.Drawing.Size(144, 66);
            this.Dismiss.TabIndex = 10;
            this.Dismiss.Text = "Dismiss Patient";
            this.Dismiss.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Patient Information:";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(521, 439);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(144, 66);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 66);
            this.button1.TabIndex = 14;
            this.button1.Text = "Diagnose Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dismiss);
            this.Controls.Add(this.Patient_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.BloodButton);
            this.Controls.Add(this.Illments);
            this.Controls.Add(this.SymptomsBox);
            this.Controls.Add(this.QuestionButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button QuestionButton;
        private ListBox SymptomsBox;
        private ListBox Illments;
        private Button BloodButton;
        private Button InfoButton;
        private Label label1;
        private Label label2;
        private ListBox Patient_Info;
        private Button Dismiss;
        private Label label3;
        private Button CloseButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Button button1;
    }
}