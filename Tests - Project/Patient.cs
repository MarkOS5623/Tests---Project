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
        private String _Illness;
        private String _Treatment;
        private float _Age;
        private float _Weight;
        private float _Height;
        private BloodTest _results;
        private bool _Male;
        public Patient()
        {
            _Fname = "John";
            _LName = "Doe";
            _ID = "id";
            _Illness = "";
            _Treatment = "";
            _Age = 0;
            _Weight = 0;
            _Height = 0;
            _results = new BloodTest();
            _Male = false;
        }
        public Patient(String fname, String lname, String id, String ill, float age, float weight, float height, bool male)
        {
            _Fname = fname;
            _LName = lname;
            _ID = id;
            _Age = age;
            _Weight = weight;
            _Height = height;
            _Illness = ill;
            _results = new BloodTest();
            _Male = male;
            _Treatment = "";
        }
        public String getFname() { return _Fname; }
        public String getLName() { return _LName; }
        public String getId() { return _ID; }
        public String getIllness() { return _Illness; }
        public String getTreatment() { return _Treatment; }
        public float getAge() { return _Age; }
        public float getWeight() { return _Weight; }
        public float getHeight() { return _Height; }
        public BloodTest getresults() { return _results; }
        public bool getMale() { return _Male; }
        public void setResults(BloodTest results) { _results = results; }
        public void setTreatment(String treatment) { _Treatment = treatment; }
        public void setIllness(String illeness) { _Illness = illeness; }
    }
}
