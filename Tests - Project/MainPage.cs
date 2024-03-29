﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Tests___Project
{
    public partial class MainPage : Form
    {
        public static List<Patient> PatientList = new List<Patient>();
        public static List<String> BloodTests = new List<String>();
        //flags for checks
        public static bool BloodFlag = false;
        public static bool SymptomsFlag = false;
        public static bool Diagnosticsflag = false;
        public static bool QuestionnaireFlag = false;

        public static Dictionary<String, String> Dict = new Dictionary<String, String>() {   
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
            { "Underweight", "Dietian referral"}, { "Overweight", "Dietian referral"}, { "Malnourished","Dietian referral"},
            { "Using different medicines", "Family doctor referral to coordinate prescriptions"} 
        };
        public MainPage()
        {
            InitializeComponent();
            
            DiagnosticForm f = new DiagnosticForm();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            if (PatientList.Count == 1 && QuestionnaireFlag == false)
            {
                Questionnaire f = new Questionnaire();
                f.ShowDialog();

                SymptomsFlag = true; // Prevents doubling of symptoms
                QuestionnaireFlag = true;
            }
            else if (QuestionnaireFlag == true) MessageBox.Show("The patient has already filled the form!!");
            else MessageBox.Show("No patient has been addmited!!");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                  Color.Red, 5, ButtonBorderStyle.Solid,
                                  Color.Red, 5, ButtonBorderStyle.Solid,
                                  Color.Red, 5, ButtonBorderStyle.Solid,
                                  Color.Red, 5, ButtonBorderStyle.Solid);
        }
        public void InitializeInfo()
        {
            Patient Zero = PatientList[0];
            Patient_Info.Items.Add("First Name: " + Zero.getFname());
            Patient_Info.Items.Add("Last Name: " + Zero.getLName());
            Patient_Info.Items.Add("ID Number: " + Zero.getId());
            if(Zero.getSex())
                Patient_Info.Items.Add("Sex: Male");
            else Patient_Info.Items.Add("Sex: Female");
            Patient_Info.Items.Add("Age: " + Zero.getAge() + " years old");
            Patient_Info.Items.Add("Height: " + Zero.getHeight() + " Cm");
            Patient_Info.Items.Add("Weight: " + Zero.getWeight() + " Kg");
            Patient_Info.Items.Add("Disease: " + Zero.getIllness());
            Patient_Info.Items.Add("Treatment: " + Zero.getTreatment());
        }
        private void SymptomsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BloodButton_Click(object sender, EventArgs e)
        {
            if (PatientList.Count == 1 && BloodFlag == false)
            {
                using (OpenFileDialog odf = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false})
                    if(odf.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook WB = new XLWorkbook(odf.FileName))
                        {
                            ClosedXML.Excel.IXLWorksheet data = WB.Worksheet(1);
                            if (data.Cell(1, 1).GetValue<String>() != "WBC")
                                MessageBox.Show("The excel file doesn't contain blood test results! Please choose the currect file!");
                            else
                            {
                                Questionnaire f = new Questionnaire();
                                int WBC = Convert.ToInt32(data.Cell(2, 1).GetValue<double>());
                                float Neutrophil = Convert.ToSingle(data.Cell(2, 2).GetValue<double>());
                                float Lymphocytes = Convert.ToSingle(data.Cell(2, 3).GetValue<double>());
                                float RBC = Convert.ToSingle(data.Cell(2, 4).GetValue<double>());
                                float HCT = Convert.ToSingle(data.Cell(2, 5).GetValue<double>());
                                float Urea = Convert.ToSingle(data.Cell(2, 6).GetValue<double>());
                                float Hemoglobin = Convert.ToSingle(data.Cell(2, 7).GetValue<double>());
                                float Crtn = Convert.ToSingle(data.Cell(2, 8).GetValue<double>());
                                int Iron = Convert.ToInt32(data.Cell(2, 9).GetValue<double>());
                                float HDL = Convert.ToSingle(data.Cell(2, 10).GetValue<double>());
                                int AP = Convert.ToInt32(data.Cell(2, 11).GetValue<double>());
                                BloodTest bloodTest = new BloodTest(WBC, Neutrophil, Lymphocytes, RBC, HCT, Urea, Hemoglobin, Iron, Crtn, HDL, AP);
                                PatientList[0].setResults(bloodTest);
                                BloodFlag = true;
                                f.DiseaseInator();
                                Utility.BloodResults();
                                Diagnosticsflag = true; // Prevents doubling of diagnostics
                            }
                        }
                    }
            }
            else if (BloodFlag == true) MessageBox.Show("The patient's blood test has already been imported!!");
            else MessageBox.Show("No patient has been addmited!!");
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (PatientList.Count == 0) {
                PatientForm f = new PatientForm();
                f.ShowDialog();
                if(PatientList.Count != 0)
                InitializeInfo();}
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
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to quit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = PatientList.Count;
            if (QuestionnaireFlag == true && BloodFlag == true && n > 0)
            {
                DiagnosticForm f = new DiagnosticForm();
                f.ShowDialog();
                Patient_Info.Items.Clear();
                InitializeInfo();
                Utility.PatientToExcel();
            }
            else if (n == 0) { 
                MessageBox.Show("No patient has been admited!!");
                return;
            }

            else if (QuestionnaireFlag == false) {
                MessageBox.Show("The patient hasn't filled the question form!");
                return;
            }
            else if (BloodFlag == false) { 
                MessageBox.Show("The patient's blood test hasn't been entered!");
                return;
            }
        }

        
        private void Dismiss_Click(object sender, EventArgs e)
        {
            int n = PatientList.Count;
            if(n == 0) {
                MessageBox.Show("No patient has been admited!!");
                return;
            }
            DialogResult Dismiss;
            if(PatientList[0].getIllness() == "")
                Dismiss = MessageBox.Show("The patient hasn't been diagnosed yet!\n" +
                    "Are you sure you want to dismiss the patient?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else Dismiss = MessageBox.Show("The patient has been diagnosed!\n" +
                    "Are you sure you want to dismiss the patient?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Dismiss == DialogResult.Yes)
                Dismisser();
        }
        public void Dismisser()
        {
            PatientList.Clear();
            BloodTests.Clear();
            Patient_Info.Items.Clear();
            Questionnaire.Diagnostics.Clear();
            Questionnaire.Symptoms.Clear();
            BloodFlag = false;
            SymptomsFlag = false;
            Diagnosticsflag = false;
            QuestionnaireFlag = false;
        }

        private void Patient_Info_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
