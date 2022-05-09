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
                Diagnostics.Add("Hyperlipidemia");
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

            if (Breathing_Problems.Checked || Asthma.Checked || Smoker.Checked) {
                Diagnostics.Add("Lung disease");
                Symptoms.Add("Asthma");}

            if (Heart_Disease.Checked){
                Diagnostics.Add("Heart disease");
                Symptoms.Add("Heart disease");}

            if (Fainting.Checked) Symptoms.Add("Fainting");

            if (Fainting.Checked || Headaches.Checked) Diagnostics.Add("Dehydration");

            if (Diabetes.Checked) {
                Diagnostics.Add("Adult diabetes");
                Symptoms.Add("Adult diabetes");}

            if (Weakness.Checked || (Headaches.Checked && Breathing_Problems.Checked) || Fainting.Checked) {
                Diagnostics.Add("Anemia");
                Diagnostics.Add("Iron deficiency");
                Diagnostics.Add("Cancer");}

            if (Weakness.Checked && Headaches.Checked && Breathing_Problems.Checked && Fainting.Checked) Diagnostics.Add("Cancer");

            if (Weakness.Checked && Headaches.Checked && Nause.Checked) Diagnostics.Add("Iron poisoning");


            if(Diarrhea.Checked && Abdominal_Pains.Checked) Diagnostics.Add("Digestive tract problems");

            if (Weakness.Checked || Headaches.Checked || Breathing_Problems.Checked)
                Diagnostics.Add("Viral infection");

            if (Muscle_Pain.Checked) Symptoms.Add("Muscle disease");

            if(Weakness.Checked && (Underweight.Checked || Overweight.Checked)) Symptoms.Add("Thyroid gland problems");
            this.Hide();
            MainPage f = new MainPage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
