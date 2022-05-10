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
    public partial class Questionnaire : Form
    {

        public static List<String> Diagnostics = new List<String>(); // list containing possible diagnostics
        public static List<String> Symptoms = new List<String>(); // list containing the patients symptoms
        public Questionnaire()
        {
            InitializeComponent();
        }
        private void Smoker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (Underweight.Checked){
                Diagnostics.Add("Underweight");
                Symptoms.Add("Underweight");}

            if (Overweight.Checked) {
                Diagnostics.Add("Overweight");
                Symptoms.Add("Overweight");}

            if (Bleeding.Checked){
                Diagnostics.Add("Bleeding");
                Symptoms.Add("Bleeding"); }
            

            if (Smoker.Checked) {
                Diagnostics.Add("Smoker");
                Symptoms.Add("Smoker");}

            if (Weakness.Checked) Symptoms.Add("Weakness");

            if (Breathing_Problems.Checked) {
                Symptoms.Add("Breathing Problems");}

            if (Asthma.Checked) { 
                Diagnostics.Add("Lung disease");
                Symptoms.Add("Asthma");}

            if (Heart_Disease.Checked){
                Diagnostics.Add("Heart disease");
                Symptoms.Add("Heart disease");}

            if (Fainting.Checked) Symptoms.Add("Fainting");

            if (Headaches.Checked) Symptoms.Add("Dehydration");

            if (Diabetes.Checked) {
                Diagnostics.Add("Adult diabetes");
                Symptoms.Add("Adult diabetes");}

            if (Muscle_Pain.Checked) Symptoms.Add("Muscle Pain");

            if(Nause.Checked) Symptoms.Add("Nause");

            if (Abdominal_Pains.Checked) Symptoms.Add("Abdominal Pains");

            if (Diarrhea.Checked) Symptoms.Add("Diarrhea");

            if (Fever.Checked) Symptoms.Add("Fever");

            this.Hide();
            MainPage f = new MainPage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
