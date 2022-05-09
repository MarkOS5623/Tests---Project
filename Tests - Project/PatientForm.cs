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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Patient Zero = new Patient(FnameBox.Text,LnameBox.Text,IdBox.Text,BPBox.Text, "",float.Parse(AgeBox.Text),
                float.Parse(WeightBox.Text),float.Parse(HeightBox.Text));
            MainPage.PatientList.Add(Zero);
            this.Hide();
            MainPage f = new MainPage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
