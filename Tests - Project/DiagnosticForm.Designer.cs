namespace Tests___Project
{
    partial class DiagnosticForm
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
            this.Symptomsbox = new System.Windows.Forms.ListBox();
            this.BloodResultsbox = new System.Windows.Forms.ListBox();
            this.Diseasesbox = new System.Windows.Forms.ListBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Treatmentsbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Symptomsbox
            // 
            this.Symptomsbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Symptomsbox.FormattingEnabled = true;
            this.Symptomsbox.ItemHeight = 22;
            this.Symptomsbox.Location = new System.Drawing.Point(27, 51);
            this.Symptomsbox.Name = "Symptomsbox";
            this.Symptomsbox.Size = new System.Drawing.Size(185, 290);
            this.Symptomsbox.TabIndex = 0;
            // 
            // BloodResultsbox
            // 
            this.BloodResultsbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodResultsbox.FormattingEnabled = true;
            this.BloodResultsbox.HorizontalScrollbar = true;
            this.BloodResultsbox.ItemHeight = 22;
            this.BloodResultsbox.Location = new System.Drawing.Point(207, 51);
            this.BloodResultsbox.Name = "BloodResultsbox";
            this.BloodResultsbox.Size = new System.Drawing.Size(329, 290);
            this.BloodResultsbox.TabIndex = 1;
            this.BloodResultsbox.SelectedIndexChanged += new System.EventHandler(this.BloodResults_SelectedIndexChanged);
            // 
            // Diseasesbox
            // 
            this.Diseasesbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Diseasesbox.FormattingEnabled = true;
            this.Diseasesbox.HorizontalScrollbar = true;
            this.Diseasesbox.ItemHeight = 22;
            this.Diseasesbox.Location = new System.Drawing.Point(533, 51);
            this.Diseasesbox.Name = "Diseasesbox";
            this.Diseasesbox.Size = new System.Drawing.Size(231, 290);
            this.Diseasesbox.TabIndex = 2;
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoneButton.Location = new System.Drawing.Point(1077, 514);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(116, 61);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(12, 514);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(116, 61);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(579, 514);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 36);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 514);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Final diagnoses ";
            // 
            // Treatmentsbox
            // 
            this.Treatmentsbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Treatmentsbox.FormattingEnabled = true;
            this.Treatmentsbox.HorizontalScrollbar = true;
            this.Treatmentsbox.ItemHeight = 22;
            this.Treatmentsbox.Location = new System.Drawing.Point(762, 51);
            this.Treatmentsbox.Name = "Treatmentsbox";
            this.Treatmentsbox.Size = new System.Drawing.Size(431, 290);
            this.Treatmentsbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Symptoms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(207, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blood Test Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(533, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Possible Diseases";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(762, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Treatments";
            // 
            // DiagnosticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.Treatmentsbox);
            this.Controls.Add(this.Diseasesbox);
            this.Controls.Add(this.BloodResultsbox);
            this.Controls.Add(this.Symptomsbox);
            this.Name = "DiagnosticForm";
            this.Text = "DiagnosticForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Symptomsbox;
        private ListBox BloodResultsbox;
        private ListBox Diseasesbox;
        private Button DoneButton;
        private Button CancelButton;
        private ComboBox comboBox1;
        private Label label1;
        private ListBox Treatmentsbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}