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
            this.Symptoms = new System.Windows.Forms.ListBox();
            this.BloodResults = new System.Windows.Forms.ListBox();
            this.Diseases = new System.Windows.Forms.ListBox();
            this.Treatments = new System.Windows.Forms.ListBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Symptoms
            // 
            this.Symptoms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Symptoms.FormattingEnabled = true;
            this.Symptoms.ItemHeight = 28;
            this.Symptoms.Location = new System.Drawing.Point(27, 57);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(185, 284);
            this.Symptoms.TabIndex = 0;
            // 
            // BloodResults
            // 
            this.BloodResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodResults.FormattingEnabled = true;
            this.BloodResults.ItemHeight = 28;
            this.BloodResults.Location = new System.Drawing.Point(207, 57);
            this.BloodResults.Name = "BloodResults";
            this.BloodResults.Size = new System.Drawing.Size(185, 284);
            this.BloodResults.TabIndex = 1;
            this.BloodResults.SelectedIndexChanged += new System.EventHandler(this.BloodResults_SelectedIndexChanged);
            // 
            // Diseases
            // 
            this.Diseases.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Diseases.FormattingEnabled = true;
            this.Diseases.ItemHeight = 28;
            this.Diseases.Location = new System.Drawing.Point(418, 57);
            this.Diseases.Name = "Diseases";
            this.Diseases.Size = new System.Drawing.Size(185, 284);
            this.Diseases.TabIndex = 2;
            // 
            // Treatments
            // 
            this.Treatments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Treatments.FormattingEnabled = true;
            this.Treatments.ItemHeight = 28;
            this.Treatments.Location = new System.Drawing.Point(599, 57);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(265, 284);
            this.Treatments.TabIndex = 3;
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoneButton.Location = new System.Drawing.Point(740, 514);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(116, 61);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.comboBox1.Location = new System.Drawing.Point(418, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 36);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 370);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Final diagnoses ";
            // 
            // DiagnosticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.Treatments);
            this.Controls.Add(this.Diseases);
            this.Controls.Add(this.BloodResults);
            this.Controls.Add(this.Symptoms);
            this.Name = "DiagnosticForm";
            this.Text = "DiagnosticForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Symptoms;
        private ListBox BloodResults;
        private ListBox Diseases;
        private ListBox Treatments;
        private Button DoneButton;
        private Button CancelButton;
        private ComboBox comboBox1;
        private Label label1;
    }
}