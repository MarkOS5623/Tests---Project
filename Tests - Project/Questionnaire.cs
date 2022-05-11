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

        public bool Alreadyin(String s, List<String> list)
        {
            int n = list.Count;
            for (int i = 0; i < n; i++)
            {
                if (list[i] == s) return true;
            }
            return false;
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (Underweight.Checked){
                Diagnostics.Add("Underweight");
                Symptoms.Add("Underweight");}

            if (Overweight.Checked) {
                Diagnostics.Add("Overweight");
                if (!Alreadyin("Overweight", Symptoms))
                    Symptoms.Add("Overweight");}

            if (Bleeding.Checked){
                Diagnostics.Add("Bleeding");
                if (!Alreadyin("Bleeding", Symptoms))
                    Symptoms.Add("Bleeding"); }
            

            if (Smoker.Checked) {
                Diagnostics.Add("Smoker");
                if (!Alreadyin("Smoker", Symptoms))
                    Symptoms.Add("Smoker");}

            if (Weakness.Checked && !Alreadyin("Weakness", Symptoms)) Symptoms.Add("Weakness");

            if (Breathing_Problems.Checked && !Alreadyin("Breathing Problems", Symptoms)) Symptoms.Add("Breathing Problems");

            if (Asthma.Checked) { 
                Diagnostics.Add("Lung disease");
                if (!Alreadyin("Asthma", Symptoms))
                    Symptoms.Add("Asthma");}

            if (Heart_Disease.Checked){
                Diagnostics.Add("Heart disease");
                if (!Alreadyin("Heart disease", Symptoms))
                    Symptoms.Add("Heart disease");}

            if (Fainting.Checked && !Alreadyin("Fainting", Symptoms)) Symptoms.Add("Fainting");

            if (Headaches.Checked && !Alreadyin("Headaches", Symptoms)) Symptoms.Add("Headaches");

            if (Diabetes.Checked) {
                Diagnostics.Add("Adult diabetes");
                if (!Alreadyin("Diabetes", Symptoms))
                    Symptoms.Add("Diabetes");}

            if (Muscle_Pain.Checked && (!Alreadyin("Muscle Pain", Symptoms))) Symptoms.Add("Muscle Pain");

            if(Nause.Checked && (!Alreadyin("Nause", Symptoms))) Symptoms.Add("Nause");

            if (Abdominal_Pains.Checked && (!Alreadyin("Abdominal Pains", Symptoms))) Symptoms.Add("Abdominal Pains");

            if (Diarrhea.Checked && (!Alreadyin("Diarrhea", Symptoms))) Symptoms.Add("Diarrhea");

            if (Fever.Checked && (!Alreadyin("Fever", Symptoms))) Symptoms.Add("Fever");

            this.Hide();
            MainPage f = new MainPage();
            MainPage.flag2 = true;
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        public void AdultdiseaseInator()
        {
            BloodTest bloodTest = MainPage.PatientList[0].getresults();
            if (bloodTest.getWBC() < 4500) {
                if(!Alreadyin("Viral infection", Diagnostics))
                    Diagnostics.Add("Viral infection");
                if (!Alreadyin("Cancer", Diagnostics))
                    Diagnostics.Add("Cancer"); }

            if (bloodTest.getWBC() > 11000) {
                if (Fever.Checked && !Alreadyin("Infection", Diagnostics)) Diagnostics.Add("Infection");
                if (!Alreadyin("Cancer", Diagnostics))
                    Diagnostics.Add("Cancer");
                if (!Alreadyin("Blood disease", Diagnostics))
                    Diagnostics.Add("Blood disease"); }

            if (bloodTest.getNeutrophil() < 28) {
                if (!Alreadyin("Cancer", Diagnostics))
                    Diagnostics.Add("Cancer");
                if (!Alreadyin("Infection", Diagnostics))
                    Diagnostics.Add("Infection"); }

            if (bloodTest.getNeutrophil() > 54 && !Alreadyin("Infection", Diagnostics)) Diagnostics.Add("Infection");

            if (bloodTest.getLymphocytes() < 36 && !Alreadyin("Blood cell problems", Diagnostics)) Diagnostics.Add("Blood cell problems");

            if (bloodTest.getLymphocytes() > 52) {
                if (!Alreadyin("Infection", Diagnostics))
                    Diagnostics.Add("Infection");
                if (!Alreadyin("Cancer", Diagnostics))
                    Diagnostics.Add("Cancer"); }

            if (bloodTest.getRBC() < 4.5) {
                if (!Alreadyin("Anemia", Diagnostics))
                    Diagnostics.Add("Anemia");
                if (Bleeding.Checked && (!Alreadyin("Bleeding", Diagnostics))) Diagnostics.Add("Bleeding"); }

            if (bloodTest.getRBC() > 6) {
                if (Smoker.Checked || Asthma.Checked) { }
                else if (!Alreadyin("Blood cell problems", Diagnostics)) Diagnostics.Add("Blood cell problems"); }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getHCT() < 37) {
                    if (!Alreadyin("Anemia", Diagnostics))
                        Diagnostics.Add("Anemia");
                    if (Bleeding.Checked && (!Alreadyin("Bleeding", Diagnostics))) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHCT() > 54) {
                    if (Smoker.Checked) { }
                    else Symptoms.Add("High HCT values"); } }
            else {
                if (bloodTest.getHCT() < 33) {
                    if (!Alreadyin("Anemia", Diagnostics))
                        Diagnostics.Add("Anemia");
                    if (Bleeding.Checked && (!Alreadyin("Bleeding", Diagnostics))) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHCT() > 47) {
                    if (Smoker.Checked) { }
                    else Symptoms.Add("High HCT values"); } }

            if (bloodTest.getUrea() < 17 && (!Alreadyin("Kidney disease", Diagnostics))) Diagnostics.Add("Kidney disease");

            if (bloodTest.getUrea() > 43) {
                if (!Alreadyin("Kidney disease", Diagnostics))
                    Diagnostics.Add("Kidney disease");
                if (!Alreadyin("Dehydration", Diagnostics))
                    Diagnostics.Add("Dehydration"); }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getHemoglobin() < 12) {
                    if (!Alreadyin("Anemia", Diagnostics))
                        Diagnostics.Add("Anemia");
                    if (!Alreadyin("Hematological disorder", Diagnostics))
                        Diagnostics.Add("Hematological disorder");
                    if (Bleeding.Checked && (!Alreadyin("Bleeding", Diagnostics))) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHemoglobin() > 18) { } }
            else {
                if (bloodTest.getHemoglobin() < 12) {
                    if (!Alreadyin("Anemia", Diagnostics))
                        Diagnostics.Add("Anemia");
                    if (!Alreadyin("Hematological disorder", Diagnostics))
                        Diagnostics.Add("Hematological disorder");
                    if (Bleeding.Checked && (!Alreadyin("Bleeding", Diagnostics))) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getHemoglobin() > 16) { } }

            if (bloodTest.getCrtn() < 0.6 && (!Alreadyin("Malnourished", Diagnostics))) Diagnostics.Add("Malnourished");

            if (bloodTest.getCrtn() > 1) {
                if (Diarrhea.Checked) { }
                else {
                    if (!Alreadyin("Kidney disease", Diagnostics))
                        Diagnostics.Add("Kidney disease");
                    if (!Alreadyin("Muscle disease", Diagnostics))
                        Diagnostics.Add("Muscle disease"); } }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getIron() < 60) {
                    if (Bleeding.Checked && (!Alreadyin("Bleeding", Diagnostics))) Diagnostics.Add("Bleeding"); }
                if (bloodTest.getIron() > 160) {
                    if (!Alreadyin("Iron poisoning", Diagnostics))
                        Diagnostics.Add("Iron poisoning"); } }
            else {
                if (bloodTest.getIron() < 48)
                    if (Bleeding.Checked && (!Alreadyin("Bleeding", Diagnostics))) Diagnostics.Add("Bleeding");
                if (bloodTest.getIron() > 128)
                    if (!Alreadyin("Iron poisoning", Diagnostics))
                        Diagnostics.Add("Iron poisoning"); }

            if (MainPage.PatientList[0].getMale()) {
                if (bloodTest.getHDL() < 29) {
                    if (!Alreadyin("Hyperlipidemia", Diagnostics))
                        Diagnostics.Add("Hyperlipidemia");
                    if (!Alreadyin("Heart disease", Diagnostics))
                        Diagnostics.Add("Heart disease"); }
                if (bloodTest.getHDL() > 62) { } }
            else {
                if (bloodTest.getHDL() < 34) {
                    if (!Alreadyin("Hyperlipidemia", Diagnostics))
                        Diagnostics.Add("Hyperlipidemia");
                    if (!Alreadyin("Heart disease", Diagnostics))
                        Diagnostics.Add("Heart disease");
                }
                if (bloodTest.getHDL() > 82) { } }

            if (bloodTest.getAP() < 60) { }

            if (bloodTest.getAP() > 120) {
                if (!Alreadyin("Digestive tract problems", Diagnostics))
                    Diagnostics.Add("Digestive tract problems");
                if (!Alreadyin("Liver disease", Diagnostics))
                    Diagnostics.Add("Liver disease");
                if (!Alreadyin("Thyroid gland problems", Diagnostics))
                    Diagnostics.Add("Thyroid gland problems");
                if (!Alreadyin("Using different medicines", Diagnostics))
                    Diagnostics.Add("Using different medicines");}
        }
    }
}
