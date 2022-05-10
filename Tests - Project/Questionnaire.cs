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

            if (Headaches.Checked) Symptoms.Add("Headaches");

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

        public void AdultdiseaseInator()
        {
            BloodTest bloodTest = MainPage.PatientList[0].getresults();
            if (bloodTest.getWBC() < 4500) {
                Diagnostics.Add("Viral infection");
                Diagnostics.Add("Cancer"); }

            if (bloodTest.getWBC() > 11000) {
                if (Fever.Checked) Diagnostics.Add("Infection");
                Diagnostics.Add("Cancer");
                Diagnostics.Add("Blood disease"); }

            if (bloodTest.getNeutrophil() < 28) {
                Diagnostics.Add("Cancer");
                Diagnostics.Add("Infection"); }

            if (bloodTest.getNeutrophil() > 54) Diagnostics.Add("Infection");

            if (bloodTest.getLymphocytes() < 36) Diagnostics.Add("Blood cell problems");

            if (bloodTest.getLymphocytes() > 52) {
                Diagnostics.Add("Infection");
                Diagnostics.Add("Cancer"); }

            if (bloodTest.getRBC() < 4.5) {
                Diagnostics.Add("Anemia");
                if (Bleeding.Checked) Diagnostics.Add("Bleeding"); }

            if (bloodTest.getRBC() > 6) {
                if (Smoker.Checked || Asthma.Checked) { }
                else Diagnostics.Add("Blood cell problems"); }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getHCT() < 37) {
                    Diagnostics.Add("Anemia");
                    if (Bleeding.Checked) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHCT() > 54) {
                    if (Smoker.Checked) { }
                    else Symptoms.Add("High HCT values"); } }
            else {
                if (bloodTest.getHCT() < 33) {
                    Diagnostics.Add("Anemia");
                    if (Bleeding.Checked) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHCT() > 47) {
                    if (Smoker.Checked) { }
                    else Symptoms.Add("High HCT values"); } }

            if (bloodTest.getUrea() < 17) Diagnostics.Add("Kidney disease");

            if (bloodTest.getUrea() > 43) {
                Diagnostics.Add("Kidney disease");
                Diagnostics.Add("Dehydration"); }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getHemoglobin() < 12) {
                    Diagnostics.Add("Anemia");
                    Diagnostics.Add("Hematological disorder");
                    if (Bleeding.Checked) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHemoglobin() > 18) { } }
            else {
                if (bloodTest.getHemoglobin() < 12) {
                    Diagnostics.Add("Anemia");
                    Diagnostics.Add("Hematological disorder");
                    if (Bleeding.Checked) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHemoglobin() > 16) { } }

            if (bloodTest.getCrtn() < 0.6) Diagnostics.Add("Underwieght");

            if (bloodTest.getCrtn() > 1) {
                if (Diarrhea.Checked) { }
                else {
                    Diagnostics.Add("Kidney disease");
                    Diagnostics.Add("Muscle disease"); } }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getIron() < 60) {
                    if (Bleeding.Checked) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getIron() > 160) {
                    Diagnostics.Add("Iron poisoning"); } }
            else {
                if (bloodTest.getIron() < 48)
                    if (Bleeding.Checked) Diagnostics.Add("Bleeding");
                if (bloodTest.getIron() > 128) Diagnostics.Add("Iron poisoning"); }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getHDL() < 29) {
                    Diagnostics.Add("Hyperlipidemia");
                    Diagnostics.Add("Heart disease"); }
                if (bloodTest.getHDL() > 62) { } }
            else {
                if (bloodTest.getHDL() < 34) {
                    Diagnostics.Add("Hyperlipidemia");
                    Diagnostics.Add("Heart disease"); }
                if (bloodTest.getHDL() > 82) { } }

            if (bloodTest.getAP() < 60) { }

            if (bloodTest.getAP() > 120) {
                Diagnostics.Add("Digestive tract problems");
                Diagnostics.Add("Liver disease");
                Diagnostics.Add("Thyroid gland problems");
                Diagnostics.Add("Using different medicines");}
        }
    }
}
