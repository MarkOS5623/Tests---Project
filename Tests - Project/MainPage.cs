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
    public partial class MainPage : Form
    {
        public static List<Patient> PatientList = new List<Patient>();
        public static bool flag = false;
        public static bool flag2 = false;
        public static bool flag3 = false;
        public static bool flag4 = false;
        Dictionary<String, String> Dict = new Dictionary<String, String>() {   
            { "Anemia", "Two 10mg B12 pills a day for a month"}, { "Bleeding", "Go to the Hospital" },
            { "Hyperlipidemia", "One 5mg Simbobil pill a day for a week, Dietian visit"},
            { "Blood cell problems", "Two 10mg B12 pills a day for a month + One 5mg polyc acid pill a day for a Month" },
            { "Hematological disorder", "Hormone shot" }, { "Iron deficiency", "Two 10mg B12 pills a day for a month"},
            { "Iron poisoning", "Go to the Hospital"}, { "Dehydration", "lay down and drink a lot of water"},
            { "Infection", "Antibotics"},{ "Vitamin deficiency", "Blood test to identify missing vitamins"},
            { "Viral infection", "Resting at home"}, { "Digestive tract problems", "Referral for surgery"},
            { "Heart disease", "Dietians referral"}, { "Blood disease", "Cyclophosphamide + Corticosteroids"},
            { "Liver disease", "Referral for diagonstics"}, { "Kidney disease", "Blood suger adjustment"},
            { "Muscle disease", "Two 5mg Turmeric pills a day for a month"}, { "Smoker", "Stop smoking"},
            { "Lung disease", "Stop smoking + Chest xray"},
            { "Thyroid gland problems", "Perscribe Propylthiouracil"}, { "Adult diabetes", "Insulin level adjustments"},
            { "Cancer", "Perscribe Entrectinib"}, { "High red meat consumption", "Dietian referral"},
            { "Underweight", "Dietian referral"}, { "Overweight", "Dietian referral"},
            { "Using different medicines", "Family doctor referral to coordinate prescriptions"} 
        };
        public MainPage()
        {
            InitializeComponent();
            InitializeTable();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            if (PatientList.Count == 1 && flag4 == false)
            {
                Questionnaire f = new Questionnaire();
                f.ShowDialog();
                InitializeTable();
                flag2 = true; // Prevents doubling of symptoms
                flag4 = true;
            }
            else if (flag4 = true) MessageBox.Show("The patient has already filled the form!!");
            else MessageBox.Show("No patient has been addmited!!");
        }

        public void InitializeTable()
        {
            int n = Questionnaire.Symptoms.Count;
            for (int i = 0; i < n; i++)
                if (flag2 == false)
                    SymptomsBox.Items.Add(Questionnaire.Symptoms[i]);

            int k = Questionnaire.Diagnostics.Count;
            for (int i = 0; i < k; i++)
                if (flag3 == false)
                    Illments.Items.Add(Questionnaire.Diagnostics[i]);
        }
        public void InitializeInfo()
        {
            Patient Zero = PatientList[0];
            Patient_Info.Items.Add("First Name: " + Zero.getFname());
            Patient_Info.Items.Add("Last Name: " + Zero.getLName());
            Patient_Info.Items.Add("ID Number: " + Zero.getId());
            if(Zero.getMale())
                Patient_Info.Items.Add("Sex: Male");
            else Patient_Info.Items.Add("Sex: Female");
            Patient_Info.Items.Add("Age: " + Zero.getAge() + " years old");
            Patient_Info.Items.Add("Height: " + Zero.getHeight() + " Cm");
            Patient_Info.Items.Add("Weight: " + Zero.getWeight() + " Kg");
        }
        private void SymptomsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BloodButton_Click(object sender, EventArgs e)
        {
            if (PatientList.Count == 1 && flag == false)
            {
                Questionnaire f = new Questionnaire();
                Excel excel = new Excel(@"Data.xlsx", 1);
                int WBC = Convert.ToInt32(excel.ReadCell(1, 0));
                float Neutrophil = Convert.ToSingle(excel.ReadCell(2, 0));
                float Lymphocytes = Convert.ToSingle(excel.ReadCell(3, 0));
                float RBC = Convert.ToSingle(excel.ReadCell(4, 0));
                float HCT = Convert.ToSingle(excel.ReadCell(5, 0));
                float Urea = Convert.ToSingle(excel.ReadCell(6, 0));
                float Hemoglobin = Convert.ToSingle(excel.ReadCell(7, 0));
                int Iron = Convert.ToInt32(excel.ReadCell(8, 0));
                float Crtn = Convert.ToSingle(excel.ReadCell(9, 0));
                float HDL = Convert.ToSingle(excel.ReadCell(10, 0));
                int AP = Convert.ToInt32(excel.ReadCell(11, 0));
                BloodTest bloodTest = new BloodTest(WBC, Neutrophil, Lymphocytes, RBC, HCT, Urea, Hemoglobin, Iron, Crtn, HDL, AP);
                excel.Close();
                PatientList[0].setResults(bloodTest);
                flag = true;
                f.AdultdiseaseInator();
                InitializeTable();
                flag3 = true; // Prevents doubling of diagnostics
            }
            else if (flag = true) MessageBox.Show("The patient's blood test has already been imported!!");
            else MessageBox.Show("No patient has been addmited!!");
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (PatientList.Count == 0) {
                PatientForm f = new PatientForm();
                f.ShowDialog();
                InitializeInfo();} //i was here
            else MessageBox.Show("Only one patient can be admited at the time!!");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BloodResults()
        {
            BloodTest bloodTest = PatientList[0].getresults();

            if (bloodTest.getWBC() < 4500) { }

            if (bloodTest.getWBC() > 11000) { }

            if (bloodTest.getNeutrophil() < 28) { }

            if (bloodTest.getNeutrophil() > 54) { }

            if (bloodTest.getLymphocytes() < 36) { }

            if (bloodTest.getLymphocytes() > 52) { }

            if (bloodTest.getRBC() < 4.5) { }

            if (bloodTest.getRBC() > 6) { }

            if (PatientList[0].getMale())
            {
                if (bloodTest.getHCT() < 37) { }
                if (bloodTest.getHCT() > 54) { }
            }
            else
            {
                if (bloodTest.getHCT() < 33) { }
                if (bloodTest.getHCT() > 47) { }
            }

            if (bloodTest.getUrea() < 17) { }

            if (bloodTest.getUrea() > 43) { }

            if (PatientList[0].getMale())
            {
                if (bloodTest.getHemoglobin() < 12) { }
                if (bloodTest.getHemoglobin() > 18) { }
            }
            else
            {
                if (bloodTest.getHemoglobin() < 12) { }
                if (bloodTest.getHemoglobin() > 16) { }
            }

            if (bloodTest.getCrtn() < 0.6) { }

            if (bloodTest.getCrtn() > 1) { }

            if (PatientList[0].getMale())
            {
                if (bloodTest.getIron() < 60) { }
                if (bloodTest.getIron() > 160) { }
            }
            else
            {
                if (bloodTest.getIron() < 48) { }
                if (bloodTest.getIron() > 128) { }
            }

            if (PatientList[0].getMale())
            {
                if (bloodTest.getHDL() < 29) { }
                if (bloodTest.getHDL() > 62) { }
            }
            else
            {
                if (bloodTest.getHDL() < 34) { }
                if (bloodTest.getHDL() > 82) { }
            }

            if (bloodTest.getAP() < 60) { }

            if (bloodTest.getAP() > 120) { }
        }
    }
}
