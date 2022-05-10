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
            this.SuspendLayout();
            // 
            // QuestionButton
            // 
            this.QuestionButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionButton.Location = new System.Drawing.Point(12, 30);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(195, 76);
            this.QuestionButton.TabIndex = 0;
            this.QuestionButton.Text = "Question Form";
            this.QuestionButton.UseVisualStyleBackColor = true;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // SymptomsBox
            // 
            this.SymptomsBox.FormattingEnabled = true;
            this.SymptomsBox.ItemHeight = 20;
            this.SymptomsBox.Location = new System.Drawing.Point(550, 50);
            this.SymptomsBox.Name = "SymptomsBox";
            this.SymptomsBox.Size = new System.Drawing.Size(162, 444);
            this.SymptomsBox.TabIndex = 3;
            this.SymptomsBox.SelectedIndexChanged += new System.EventHandler(this.SymptomsBox_SelectedIndexChanged);
            // 
            // Illments
            // 
            this.Illments.FormattingEnabled = true;
            this.Illments.ItemHeight = 20;
            this.Illments.Location = new System.Drawing.Point(709, 50);
            this.Illments.Name = "Illments";
            this.Illments.Size = new System.Drawing.Size(170, 444);
            this.Illments.TabIndex = 4;
            // 
            // BloodButton
            // 
            this.BloodButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodButton.Location = new System.Drawing.Point(248, 30);
            this.BloodButton.Name = "BloodButton";
            this.BloodButton.Size = new System.Drawing.Size(195, 76);
            this.BloodButton.TabIndex = 5;
            this.BloodButton.Text = "Import Blood Test";
            this.BloodButton.UseVisualStyleBackColor = true;
            this.BloodButton.Click += new System.EventHandler(this.BloodButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoButton.Location = new System.Drawing.Point(12, 134);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(195, 76);
            this.InfoButton.TabIndex = 6;
            this.InfoButton.Text = "Enter Patient Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(709, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Possible diagnosis";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.BloodButton);
            this.Controls.Add(this.Illments);
            this.Controls.Add(this.SymptomsBox);
            this.Controls.Add(this.QuestionButton);
            this.Name = "MainPage";
            this.Text = "MainPage";
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
    }
}