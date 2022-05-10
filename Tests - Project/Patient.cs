using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests___Project
{
    public class Patient
    {
        private String _Fname;
        private String _LName;
        private String _ID;
        private String _BP;
        private String _Illness;
        private float _Age;
        private float _Weight;
        private float _Height;
        private BloodTest _results;
        public Patient()
        {
            _Fname = "John";
            _LName = "Doe";
            _ID = "id";
            _BP = "XX/XX";
            _Illness = "";
            _Age = 0;
            _Weight = 0;
            _Height = 0;
            _results = new BloodTest();
        }
        public Patient(String fname, String lname, String id, String bp, String ill, float age, float weight, float height)
        {
            _Fname = fname;
            _LName = lname;
            _ID = id;
            _BP = bp;
            _Age = age;
            _Weight = weight;
            _Height = height;
            _Illness = ill;
            _results = new BloodTest();
        }
        public String getFname() { return _Fname; }
        public String getLName() { return _LName; }
        public String getId() { return _ID; }
        public String getBP() { return _BP; }
        public String getIllness() { return _Illness; }
        public float getAge() { return _Age; }
        public float getWeight() { return _Weight; }
        public float getHeight() { return _Height; }
        public BloodTest getresults() { return _results; }
        public void setResults(BloodTest results) { _results = results; }

    }
}
