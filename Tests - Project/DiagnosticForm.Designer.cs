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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticForm));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Symptomsbox
            // 
            this.Symptomsbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Symptomsbox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Symptomsbox.FormattingEnabled = true;
            this.Symptomsbox.ItemHeight = 28;
            this.Symptomsbox.Location = new System.Drawing.Point(14, 236);
            this.Symptomsbox.Margin = new System.Windows.Forms.Padding(5);
            this.Symptomsbox.Name = "Symptomsbox";
            this.Symptomsbox.Size = new System.Drawing.Size(298, 424);
            this.Symptomsbox.TabIndex = 0;
            // 
            // BloodResultsbox
            // 
            this.BloodResultsbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BloodResultsbox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BloodResultsbox.FormattingEnabled = true;
            this.BloodResultsbox.HorizontalScrollbar = true;
            this.BloodResultsbox.ItemHeight = 28;
            this.BloodResultsbox.Location = new System.Drawing.Point(306, 236);
            this.BloodResultsbox.Margin = new System.Windows.Forms.Padding(5);
            this.BloodResultsbox.Name = "BloodResultsbox";
            this.BloodResultsbox.Size = new System.Drawing.Size(469, 424);
            this.BloodResultsbox.TabIndex = 1;
            this.BloodResultsbox.SelectedIndexChanged += new System.EventHandler(this.BloodResults_SelectedIndexChanged);
            // 
            // Diseasesbox
            // 
            this.Diseasesbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Diseasesbox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Diseasesbox.FormattingEnabled = true;
            this.Diseasesbox.HorizontalScrollbar = true;
            this.Diseasesbox.ItemHeight = 28;
            this.Diseasesbox.Location = new System.Drawing.Point(769, 236);
            this.Diseasesbox.Margin = new System.Windows.Forms.Padding(5);
            this.Diseasesbox.Name = "Diseasesbox";
            this.Diseasesbox.Size = new System.Drawing.Size(373, 424);
            this.Diseasesbox.TabIndex = 2;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DoneButton.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoneButton.ForeColor = System.Drawing.Color.Red;
            this.DoneButton.Location = new System.Drawing.Point(1470, 779);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(5);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(180, 70);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CancelButton.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(20, 779);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(180, 70);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(785, 739);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 39);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(555, 737);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Final diagnoses ";
            // 
            // Treatmentsbox
            // 
            this.Treatmentsbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Treatmentsbox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Treatmentsbox.FormattingEnabled = true;
            this.Treatmentsbox.HorizontalScrollbar = true;
            this.Treatmentsbox.ItemHeight = 28;
            this.Treatmentsbox.Location = new System.Drawing.Point(1136, 236);
            this.Treatmentsbox.Margin = new System.Windows.Forms.Padding(5);
            this.Treatmentsbox.Name = "Treatmentsbox";
            this.Treatmentsbox.Size = new System.Drawing.Size(524, 424);
            this.Treatmentsbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Symptoms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(306, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blood Test Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(769, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Possible Diseases";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1136, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Treatments";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(1384, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 188);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(621, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 59);
            this.label6.TabIndex = 26;
            this.label6.Text = "Diagnostic Page";
            // 
            // DiagnosticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1664, 863);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
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
            this.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DiagnosticForm";
            this.Text = "DiagnosticForm";
            this.Load += new System.EventHandler(this.DiagnosticForm_Load);
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
        private Panel panel2;
        private Label label6;
    }
}