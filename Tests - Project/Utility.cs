using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Excel = ClosedXML.Excel;
using System.Runtime.InteropServices;

namespace Tests___Project {
    public class Utility {
        static XLWorkbook tData = new XLWorkbook("Resorces/TestData.xlsx");
        static XLWorkbook docDB = new XLWorkbook("Resorces/DoctorDB.xlsx");
        static XLWorkbook patDB = new XLWorkbook("Resorces/PatientDB.xlsx");
        public static void BloodResults() {
            BloodTest bloodTest = MainPage.PatientList[0].getresults();

            if (bloodTest.getWBC() < 4500) MainPage.BloodTests.Add("WBC - " + bloodTest.getWBC() + " - LOW");

            else if (bloodTest.getWBC() > 11000) MainPage.BloodTests.Add("WBC - " + bloodTest.getWBC() + " - HIGH");

            else MainPage.BloodTests.Add("WBC - " + bloodTest.getWBC() + " - Normal");

            if (bloodTest.getNeutrophil() < 28) MainPage.BloodTests.Add("Neutrophil - " + bloodTest.getNeutrophil() + "% - LOW");

            else if (bloodTest.getNeutrophil() > 54) MainPage.BloodTests.Add("Neutrophil - " + bloodTest.getNeutrophil() + "% - HIGH");

            else MainPage.BloodTests.Add("Neutrophil - " + bloodTest.getNeutrophil() + "% - Normal");

            if (bloodTest.getLymphocytes() < 36) 
                MainPage.BloodTests.Add("Lymphocytes - " + bloodTest.getLymphocytes() + "% - Low");

            else if 
                (bloodTest.getLymphocytes() > 52) MainPage.BloodTests.Add("Lymphocytes - " + bloodTest.getLymphocytes() + " % - High");

            else MainPage.BloodTests.Add("Lymphocytes - " + bloodTest.getLymphocytes() + "% - Normal");

            if (bloodTest.getRBC() < 4.5) MainPage.BloodTests.Add("RBC - " + bloodTest.getRBC() + " - Low");

            else if (bloodTest.getRBC() > 6) MainPage.BloodTests.Add("RBC - " + bloodTest.getRBC() + " - High");

            else MainPage.BloodTests.Add("RBC - " + bloodTest.getRBC() + " - Normal");

            if (MainPage.PatientList[0].getSex()) {
                if (bloodTest.getHCT() < 37) MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + "% - Low");
                else if (bloodTest.getHCT() > 54) MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + "% - High");
                else MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + "% - Normal");
            }
            else {
                if (bloodTest.getHCT() < 33) MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + "% - Low");
                else if (bloodTest.getHCT() > 47) MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + "% - High");
                else MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + "% - Normal");
            }

            if (bloodTest.getUrea() < 17) MainPage.BloodTests.Add("Urea - " + bloodTest.getUrea() + " - Low");

            else if (bloodTest.getUrea() > 43) MainPage.BloodTests.Add("Urea - " + bloodTest.getUrea() + " - High");

            else MainPage.BloodTests.Add("Urea - " + bloodTest.getUrea() + " - Normal");

            if (MainPage.PatientList[0].getSex()) {
                if (bloodTest.getHemoglobin() < 12) MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - Low");
                else if (bloodTest.getHemoglobin() > 18) MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - High");
                else MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - Normal");
            }
            else {
                if (bloodTest.getHemoglobin() < 12) MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - Low");
                else if (bloodTest.getHemoglobin() > 16) MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - High");
                else MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - Normal");
            }

            if (bloodTest.getCrtn() < 0.6) MainPage.BloodTests.Add("Crtn - " + bloodTest.getCrtn() + " - Low");

            else if (bloodTest.getCrtn() > 1) MainPage.BloodTests.Add("Crtn - " + bloodTest.getCrtn() + " - High");

            else MainPage.BloodTests.Add("Crtn - " + bloodTest.getCrtn() + " - Normal");

            if (MainPage.PatientList[0].getSex()) {
                if (bloodTest.getIron() < 60) MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - Low");
                else if (bloodTest.getIron() > 160) MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - High");
                else MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - Normal");
            }
            else {
                if (bloodTest.getIron() < 48) MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - Low");
                else if (bloodTest.getIron() > 128) MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - High");
                else MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - Normal");
            }

            if (MainPage.PatientList[0].getSex()) {
                if (bloodTest.getHDL() < 29) MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - Low");
                else if (bloodTest.getHDL() > 62) MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - High");
                else MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - Normal");
            }
            else {
                if (bloodTest.getHDL() < 34) MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - Low");
                else if (bloodTest.getHDL() > 82) MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - High");
                else MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - Normal");
            }

            if (bloodTest.getAP() < 60) MainPage.BloodTests.Add("AP - " + bloodTest.getAP() + " - Low");

            else if (bloodTest.getAP() > 120) MainPage.BloodTests.Add("AP - " + bloodTest.getAP() + " - High");

            else MainPage.BloodTests.Add("AP - " + bloodTest.getAP() + " - Normal");
        }

        public static BloodTest ExcelToBlood() {
            int WBC = Convert.ToInt32(ReadCell(1, 2, 1));
            float Neutrophil = Convert.ToSingle(ReadCell(1, 2, 2));
            float Lymphocytes = Convert.ToSingle(ReadCell(1, 2, 3));
            float RBC = Convert.ToSingle(ReadCell(1, 2, 4));
            float HCT = Convert.ToSingle(ReadCell(1, 2, 5));
            float Urea = Convert.ToSingle(ReadCell(1, 2, 6));
            float Hemoglobin = Convert.ToSingle(ReadCell(1, 2, 7));
            float Crtn = Convert.ToSingle(ReadCell(1, 2, 8));
            int Iron = Convert.ToInt32(ReadCell(1, 2, 9));
            float HDL = Convert.ToSingle(ReadCell(1, 2, 10));
            int AP = Convert.ToInt32(ReadCell(1, 2, 11));
            BloodTest bloodTest = new BloodTest(WBC, Neutrophil, Lymphocytes, RBC, HCT, Urea, Hemoglobin, Iron, Crtn, HDL, AP);
            return bloodTest;
        }
        public static String ReadCell(int choice, int row, int col) {
            ClosedXML.Excel.IXLWorksheet data = tData.Worksheet(1); //default selection in order to allow return
            switch(choice) {
                case 1: data = tData.Worksheet(1); break;
                case 2: data = docDB.Worksheet(1); break;
                case 3: data = patDB.Worksheet(1); break;
                default: MessageBox.Show("Unauthorized selection");break;
            }
            return data.Cell(row, col).GetValue<string>();
        }
        public static void WriteCell(int choice, int row, int col,string info) {
            ClosedXML.Excel.IXLWorksheet data = tData.Worksheet(1); //default selection in order to allow return
            switch (choice) {
                case 1: data = tData.Worksheet(1); break;
                case 2: data = docDB.Worksheet(1); break;
                case 3: data = patDB.Worksheet(1); break;
                default: MessageBox.Show("Unauthorized selection"); break;
            }
            data.Cell(row, col).SetValue<string>(info);
        }
        public static void SaveExcel(int choice)
        {
            ClosedXML.Excel.IXLWorksheet data = tData.Worksheet(1); //default selection in order to allow return
            switch (choice)
            {
                case 1: tData.Save(); break;
                case 2: docDB.Save(); break;
                case 3: patDB.Save(); break;
                default: MessageBox.Show("Unauthorized selection"); break;
            }
        }
        public static bool isValidIsraeliID(string id)
        {
            if (id.Length < 9) return false;
            int counter = 0, incNum;
            var i = 0;
            for (i = 0; i < 9; i++)
            {
                incNum = id[i] - '0';
                incNum *= (i % 2) + 1;
                if (incNum > 9) incNum -= 9;
                counter += incNum;
            }
            return (counter % 10 == 0);
        }
        public static void CreateExcel() {
            if (File.Exists("Resorces/DoctorDB.xlsx") == false)
            {
                XLWorkbook docDB = new XLWorkbook();
                docDB.Worksheets.Add("DoctorDB.xlsx");
                docDB.SaveAs("Resorces/DoctorDB.xlsx");
            }
            if (File.Exists("Resorces/PatientDB.xlsx") == false)
            {
                XLWorkbook patDB = new XLWorkbook();
                patDB.Worksheets.Add("PatientDB.xlsx");
                patDB.SaveAs("Resorces/PatientDB.xlsx");
            }
            if (File.Exists("Resorces/TestData.xlsx") == false)
            {
                XLWorkbook tData = new XLWorkbook();
                tData.Worksheets.Add("TestData.xlsx");
                tData.SaveAs("Resorces/TestData.xlsx");
            }
            docDB.Worksheet(1).Cell("A1").SetValue("User name");
            docDB.Worksheet(1).Cell("B1").SetValue("Password");
            docDB.Worksheet(1).Cell("C1").SetValue("ID number");
            docDB.SaveAs("Resorces/DoctorDB.xlsx");
            patDB.Worksheet(1).Cell("A1").SetValue("First name");
            patDB.Worksheet(1).Cell("B1").SetValue("Last name");
            patDB.Worksheet(1).Cell("C1").SetValue("ID number");
            patDB.Worksheet(1).Cell("D1").SetValue("Age");
            patDB.Worksheet(1).Cell("E1").SetValue("Wieght");
            patDB.Worksheet(1).Cell("F1").SetValue("Height");
            patDB.Worksheet(1).Cell("G1").SetValue("Sex");
            patDB.Worksheet(1).Cell("H1").SetValue("WBC");
            patDB.Worksheet(1).Cell("I1").SetValue("Neut");
            patDB.Worksheet(1).Cell("J1").SetValue("Lymph");
            patDB.Worksheet(1).Cell("K1").SetValue("RBC");
            patDB.Worksheet(1).Cell("L1").SetValue("HCT");
            patDB.Worksheet(1).Cell("M1").SetValue("Urea");
            patDB.Worksheet(1).Cell("N1").SetValue("Hb");
            patDB.Worksheet(1).Cell("O1").SetValue("Crtn");
            patDB.Worksheet(1).Cell("P1").SetValue("Iron");
            patDB.Worksheet(1).Cell("Q1").SetValue("HDL");
            patDB.Worksheet(1).Cell("R1").SetValue("AP");
            patDB.Worksheet(1).Cell("S1").SetValue("Diagnosis");
            patDB.Worksheet(1).Cell("T1").SetValue("Treatment");
            patDB.SaveAs("Resorces/PatientDB.xlsx");
            tData.Worksheet(1).Cell("A1").SetValue("WBC");
            tData.Worksheet(1).Cell("B1").SetValue("Neut");
            tData.Worksheet(1).Cell("C1").SetValue("Lymph");
            tData.Worksheet(1).Cell("D1").SetValue("RBC");
            tData.Worksheet(1).Cell("E1").SetValue("HCT");
            tData.Worksheet(1).Cell("F1").SetValue("Urea");
            tData.Worksheet(1).Cell("G1").SetValue("Hb");
            tData.Worksheet(1).Cell("H1").SetValue("Crtn");
            tData.Worksheet(1).Cell("I1").SetValue("Iron");
            tData.Worksheet(1).Cell("J1").SetValue("HDL");
            tData.Worksheet(1).Cell("K1").SetValue("AP");
            tData.SaveAs("Resorces/TestData.xlsx");
        }

        public static bool isValidUsername(string username)
        {
            if (username.Length < 6 && username.Length > 8) return false;
            var LetterNum = username.Count(char.IsLetter);
            var IntNum = username.Count(x => Char.IsDigit(x));
            if (IntNum <= 2 && (username.Length - LetterNum == IntNum))
                return true;
            else return false;
        }
        public static bool isEmpty(string s) { return s.Length == 0; }
        public static bool isValidName(string name)
        {
            if (name.Length < 2) return false;
            var LetterNum = name.Count(char.IsLetter);
            var IntNum = name.Count(x => Char.IsDigit(x));
            if (IntNum == 0 && (name.Length == LetterNum))
                return true;
            else return false;
        }
        public static bool isValidAge(string age)
        {
            if (!isEmpty(age))
            {
                var IntNum = age.Count(x => Char.IsDigit(x));
                int Age = Int32.Parse(age);
                if (age.Length == IntNum && Age > 0 && Age <= 120)
                    return true;
                else return false;
            } else return false;
        }
        public static bool isValidWeight(string weight)
        {
            if (!isEmpty(weight))
            {
                var IntNum = weight.Count(x => Char.IsDigit(x));
                int Weight = Int32.Parse(weight);
                if (weight.Length == IntNum && Weight > 0)
                    return true;
                else return false;
            }
            else return false;
        }
        public static bool isValidPassword(string password)
        {
            if (password.Length < 8 && password.Length > 10) return false;
            int IntNum, LetterNum, SpecialNum;
            LetterNum = password.Count(char.IsLetter);
            IntNum = password.Count(x => Char.IsDigit(x));
            SpecialNum = password.Length - IntNum - LetterNum;
            return (IntNum > 0 && LetterNum > 0 && SpecialNum > 0);
        }
        public static void PatientToExcel()
        {
            Patient Zero = MainPage.PatientList[0];
            BloodTest bt = Zero.getresults();
            int i = 1;
            bool Flag = false;
            while (Flag == false)
            {
                if (ReadCell(3, i, 1) == "")
                {
                    WriteCell(3, i, 1, Zero.getFname());
                    WriteCell(3, i, 2, Zero.getLName());
                    WriteCell(3, i, 3, Zero.getId());
                    WriteCell(3, i, 4, Convert.ToString(Zero.getAge()));
                    WriteCell(3, i, 5, Convert.ToString(Zero.getWeight()));
                    WriteCell(3, i, 6, Convert.ToString(Zero.getHeight()));
                    if (Zero.getSex())
                        WriteCell(3, i, 7, "Male");
                    else
                        WriteCell(3, i, 7, "Female");
                    WriteCell(3, i, 8, Convert.ToString(bt.getWBC()));
                    WriteCell(3, i, 9, Convert.ToString(bt.getNeutrophil()));
                    WriteCell(3, i, 10, Convert.ToString(bt.getLymphocytes()));
                    WriteCell(3, i, 11, Convert.ToString(bt.getRBC()));
                    WriteCell(3, i, 12, Convert.ToString(bt.getHCT()));
                    WriteCell(3, i, 13, Convert.ToString(bt.getUrea()));
                    WriteCell(3, i, 14, Convert.ToString(bt.getHemoglobin()));
                    WriteCell(3, i, 15, Convert.ToString(bt.getCrtn()));
                    WriteCell(3, i, 16, Convert.ToString(bt.getIron()));
                    WriteCell(3, i, 17, Convert.ToString(bt.getHDL()));
                    WriteCell(3, i, 18, Convert.ToString(bt.getAP()));
                    WriteCell(3, i, 19, Zero.getIllness());
                    WriteCell(3, i, 20, Zero.getTreatment());
                    SaveExcel(3);
                    Flag = true;
                }
                else i++;
            }
        }
    }
}
