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
        Dictionary<String, String> Dict = new Dictionary<String, String>() {   
            { "Anemia", "Two 10mg B12 pills a day for a month"}, { "Bleeding", "Go to the Hospital" },
            { "Hyperlipidemia", "One 5mg Simbobil pill a day for a week, Dietian visit"},
            { "Blood cell problems", "Two 10mg B12 pills a day for a month + One 5mg polyc acid pill a day for a Month" },
            { "Hematological disorder ", "Hormone shot" }, { "Iron deficiency", "Two 10mg B12 pills a day for a month"},
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
            this.Hide();
            Questionnaire f = new Questionnaire();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        public void InitializeTable()
        {
            int n = Questionnaire.Symptoms.Count;
            for (int i = 0; i < n; i++)
            {
                SymptomsBox.Items.Add(Questionnaire.Symptoms[i]);
            }
            int k = Questionnaire.Diagnostics.Count;
            for (int i = 0; i < k; i++)
            {
                Illments.Items.Add(Questionnaire.Diagnostics[i]);
            }
        }
        private void SymptomsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
