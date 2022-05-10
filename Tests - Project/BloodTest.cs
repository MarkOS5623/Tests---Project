using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests___Project
{
    public class BloodTest
    {
        private int WBC;
        private int AP;
        private int Iron;
        private float RBC;
        private float Urea;
        private float Hemoglobin;
        private float Crtn;
        private float HDL;
        private float Neutrophil;
        private float Lymphocytes;
        private float HCT;

        public BloodTest()
        {
            WBC = 0;
            AP = 0;
            RBC = 0;
            Urea = 0;
            Hemoglobin = 0;
            Crtn = 0;
            HDL = 0;
            Iron = 0;
            Neutrophil = 0;
            Lymphocytes = 0;
            HCT = 0;
        }
        public BloodTest(int wbc, float neutrophil, float lymphocytes, float rbc, float hct, float urea, float hemoglobin, int iron, float crtn, float hdl, int ap)
        {
            WBC = wbc;
            AP = ap;
            RBC = rbc;
            Neutrophil = neutrophil;
            Lymphocytes = lymphocytes;
            HCT = hct;
            Urea = urea;
            Hemoglobin = hemoglobin;
            Crtn = crtn;
            HDL = hdl;
            Iron = iron;
        }
        public int getWBC() { return WBC; }
        public int getIron() { return Iron; }
        public int getAP() { return AP; }
        public float getRBC() { return RBC; }
        public float getUrea() { return Urea; }
        public float getHemoglobin() { return Hemoglobin; }
        public float getCrtn() { return Crtn; }
        public float getHDL() { return HDL; }
        public float getNeutrophil() { return Neutrophil; }
        public float getLymphocytes() { return Lymphocytes; }
        public float getHCT() { return HCT; }
    }
}
