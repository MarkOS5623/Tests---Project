using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests___Project
{
    public class Utility
    {
        public static void BloodResults()
        {
            BloodTest bloodTest = MainPage.PatientList[0].getresults();

            if (bloodTest.getWBC() < 4500) MainPage.BloodTests.Add(bloodTest.getWBC() + " - LOW");

            else if (bloodTest.getWBC() > 11000) MainPage.BloodTests.Add(bloodTest.getWBC() + " - HIGH");

            else MainPage.BloodTests.Add("WBC - " + bloodTest.getWBC() + " - Normal");

            if (bloodTest.getNeutrophil() < 28) MainPage.BloodTests.Add(bloodTest.getNeutrophil() + " - LOW");

            else if (bloodTest.getNeutrophil() > 54) MainPage.BloodTests.Add(bloodTest.getNeutrophil() + " - HIGH");

            else MainPage.BloodTests.Add("Neutrophil - " + bloodTest.getNeutrophil() + " - Normal");

            if (bloodTest.getLymphocytes() < 36) MainPage.BloodTests.Add("Low Lymphocytes count");

            else if (bloodTest.getLymphocytes() > 52) MainPage.BloodTests.Add("High Lymphocytes count");

            else MainPage.BloodTests.Add("Lymphocytes - " + bloodTest.getLymphocytes() + " - Normal");

            if (bloodTest.getRBC() < 4.5) MainPage.BloodTests.Add("Low red cells count");

            else if (bloodTest.getRBC() > 6) MainPage.BloodTests.Add("High red cells count");

            else MainPage.BloodTests.Add("RBC - " + bloodTest.getRBC() + " - Normal");

            if (MainPage.PatientList[0].getMale())
            {
                if (bloodTest.getHCT() < 37) MainPage.BloodTests.Add("Low HCT count");
                else if (bloodTest.getHCT() > 54) MainPage.BloodTests.Add("High HCT count");
                else MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + " - Normal");
            }
            else
            {
                if (bloodTest.getHCT() < 33) MainPage.BloodTests.Add("Low HCT count");
                else if (bloodTest.getHCT() > 47) MainPage.BloodTests.Add("High HCT count");
                else MainPage.BloodTests.Add("HCT - " + bloodTest.getHCT() + " - Normal");
            }

            if (bloodTest.getUrea() < 17) MainPage.BloodTests.Add("Low urea count");

            else if (bloodTest.getUrea() > 43) MainPage.BloodTests.Add("High urea count");

            else MainPage.BloodTests.Add("Urea - " + bloodTest.getUrea() + " - Normal");

            if (MainPage.PatientList[0].getMale())
            {
                if (bloodTest.getHemoglobin() < 12) MainPage.BloodTests.Add("Low hemoglobin count");
                else if (bloodTest.getHemoglobin() > 18) MainPage.BloodTests.Add("High hemoglobin count");
                else MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - Normal");
            }
            else
            {
                if (bloodTest.getHemoglobin() < 12) MainPage.BloodTests.Add("Low hemoglobin count");
                else if (bloodTest.getHemoglobin() > 16) MainPage.BloodTests.Add("High hemoglobin count");
                else MainPage.BloodTests.Add("Hemoglobin - " + bloodTest.getHemoglobin() + " - Normal");
            }

            if (bloodTest.getCrtn() < 0.6) MainPage.BloodTests.Add("Low creatin count");

            else if (bloodTest.getCrtn() > 1) MainPage.BloodTests.Add("High creatin count");

            else MainPage.BloodTests.Add("Crtn - " + bloodTest.getCrtn() + " - Normal");

            if (MainPage.PatientList[0].getMale())
            {
                if (bloodTest.getIron() < 60) MainPage.BloodTests.Add("Low iron count");
                else if (bloodTest.getIron() > 160) MainPage.BloodTests.Add("High iron count");
                else MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - Normal");
            }
            else
            {
                if (bloodTest.getIron() < 48) MainPage.BloodTests.Add("Low iron count");
                else if (bloodTest.getIron() > 128) MainPage.BloodTests.Add("High iron count");
                else MainPage.BloodTests.Add("Iron - " + bloodTest.getIron() + " - Normal");
            }

            if (MainPage.PatientList[0].getMale())
            {
                if (bloodTest.getHDL() < 29) MainPage.BloodTests.Add("Low HDL count");
                else if (bloodTest.getHDL() > 62) MainPage.BloodTests.Add("High HDL count");
                else MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - Normal");
            }
            else
            {
                if (bloodTest.getHDL() < 34) MainPage.BloodTests.Add("Low HDL count");
                else if (bloodTest.getHDL() > 82) MainPage.BloodTests.Add("High HDL count");
                else MainPage.BloodTests.Add("HDL - " + bloodTest.getHDL() + " - Normal");
            }

            if (bloodTest.getAP() < 60) MainPage.BloodTests.Add("Low AP count");

            else if (bloodTest.getAP() > 120) MainPage.BloodTests.Add("High AP count");

            else MainPage.BloodTests.Add("AP - " + bloodTest.getAP() + " - Normal");
        }

        public static BloodTest ExcelToBlood()
        {
            Excel excel = new Excel(@"Data.xlsx", 1);
            int WBC = Convert.ToInt32(excel.ReadCell(2, 1));
            float Neutrophil = Convert.ToSingle(excel.ReadCell(2, 2));
            float Lymphocytes = Convert.ToSingle(excel.ReadCell(2, 3));
            float RBC = Convert.ToSingle(excel.ReadCell(2, 4));
            float HCT = Convert.ToSingle(excel.ReadCell(2, 5));
            float Urea = Convert.ToSingle(excel.ReadCell(2, 6));
            float Hemoglobin = Convert.ToSingle(excel.ReadCell(2, 7));
            float Crtn = Convert.ToSingle(excel.ReadCell(2, 8));
            int Iron = Convert.ToInt32(excel.ReadCell(2, 9));
            float HDL = Convert.ToSingle(excel.ReadCell(2, 10));
            int AP = Convert.ToInt32(excel.ReadCell(2, 11));
            BloodTest bloodTest = new BloodTest(WBC, Neutrophil, Lymphocytes, RBC, HCT, Urea, Hemoglobin, Iron, Crtn, HDL, AP);
            excel.Close();
            return bloodTest;
        }

        public static bool isValidIsraeliID(string id)
        {
            if (id.Length < 9) return false;
            int counter = 0, incNum, i;
            for (i = 0; i < 9; i++)
            {
                incNum = id[i] - '0';
                incNum *= (i % 2) + 1;
                if (incNum > 9) incNum -= 9;
                counter += incNum;
            }
            return (counter % 10 == 0);
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
        public static void createExcel()
        {
            Excel excel = new Excel(@"Data.xlsx", 1);
            excel.CreateNewFile();
            excel.CreateNewSheet();
            excel.Save();
            excel.Close();
        }

        public static void WriteToExcel(int row, int col, String s)
        {
            Excel excel = new Excel(@"UserData.xlsx", 1);
            excel.WriteToCell(col, row, s);
            excel.Save();
            excel.Close();
        }
    }
}
