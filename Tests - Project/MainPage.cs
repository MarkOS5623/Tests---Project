using System;
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
        public static List<String> BloodTests = new List<String>();
        //flags for checks
        public static bool flag = false;
        public static bool flag2 = false;
        public static bool flag3 = false;
        public static bool flag4 = false;

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
            InitializeTable();
            DiagnosticForm f = new DiagnosticForm();
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
                BloodTest bloodTest = Utility.ExcelToBlood();
                PatientList[0].setResults(bloodTest);
                flag = true;
                f.AdultdiseaseInator();
                Utility.BloodResults();
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
            DiagnosticForm f = new DiagnosticForm();
            f.ShowDialog();
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
            SymptomsBox.Items.Clear();
            Illments.Items.Clear();
            Questionnaire.Diagnostics.Clear();
            Questionnaire.Symptoms.Clear();
            flag = false;
            flag2 = false;
            flag3 = false;
            flag4 = false;
        }

        private void Patient_Info_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
