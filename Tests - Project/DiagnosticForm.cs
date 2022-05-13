﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests___Project
{
    public partial class DiagnosticForm : Form
    {
        public DiagnosticForm()
        {
            InitializeComponent();
            BoxLoader();
        }

        public void BoxLoader() {
            int n = Questionnaire.Symptoms.Count;
            for (int i = 0; i < n; i++) {
                Symptomsbox.Items.Add(Questionnaire.Symptoms[i]);
            }
            n = MainPage.BloodTests.Count;
            for (int i = 0; i < n; i++)
            {
                BloodResultsbox.Items.Add(MainPage.BloodTests[i]);
            }
            n = Questionnaire.Diagnostics.Count;
            for (int i = 0; i < n; i++)
            {
                Diseasesbox.Items.Add(Questionnaire.Diagnostics[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Treatmentsbox.Items.Add(MainPage.Dict[Questionnaire.Diagnostics[i]]);
            }
        }
        private void BloodResults_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
