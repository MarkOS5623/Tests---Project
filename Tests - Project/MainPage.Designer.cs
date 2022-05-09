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
            this.SuspendLayout();
            // 
            // QuestionButton
            // 
            this.QuestionButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionButton.Location = new System.Drawing.Point(39, 31);
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
            this.SymptomsBox.Location = new System.Drawing.Point(550, 30);
            this.SymptomsBox.Name = "SymptomsBox";
            this.SymptomsBox.Size = new System.Drawing.Size(162, 464);
            this.SymptomsBox.TabIndex = 3;
            this.SymptomsBox.SelectedIndexChanged += new System.EventHandler(this.SymptomsBox_SelectedIndexChanged);
            // 
            // Illments
            // 
            this.Illments.FormattingEnabled = true;
            this.Illments.ItemHeight = 20;
            this.Illments.Location = new System.Drawing.Point(709, 30);
            this.Illments.Name = "Illments";
            this.Illments.Size = new System.Drawing.Size(159, 464);
            this.Illments.TabIndex = 4;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 517);
            this.Controls.Add(this.Illments);
            this.Controls.Add(this.SymptomsBox);
            this.Controls.Add(this.QuestionButton);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button QuestionButton;
        private ListBox SymptomsBox;
        private ListBox Illments;
    }
}