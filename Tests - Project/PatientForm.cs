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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                  Color.Red, 5, ButtonBorderStyle.Solid,
                                  Color.Red, 5, ButtonBorderStyle.Solid,
                                  Color.Red, 5, ButtonBorderStyle.Solid,
                                  Color.Red, 5, ButtonBorderStyle.Solid);
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            bool sex;
            bool flag = true;
            if (SexBox.Items.IndexOf(SexBox) == 0)
                sex = false;
            else sex = true;
            if (!Utility.isValidName(FnameBox.Text)) {
                flag = false;
                MessageBox.Show("A first name must be atleast 2 letter long and have no numbers in it");
                FnameBox.Focus();
            }
            else if (!Utility.isValidName(LnameBox.Text))
            {
                flag = false;
                MessageBox.Show("A last name must be atleast 2 letter long and have no numbers in it");
                LnameBox.Focus();
            }
            else if(!Utility.isValidAge(AgeBox.Text))
            {
                flag = false;
                MessageBox.Show("Please insert an age between 0 and 120");
                AgeBox.Focus();
            }
            else if(!Utility.isValidIsraeliID(IdBox.Text))
            {
                flag = false;
                MessageBox.Show("Please insert a valid Israeli ID");
                IdBox.Focus();
            }
            else if(!Utility.isValidWeight(HeightBox.Text))
            {
                flag = false;
                MessageBox.Show("Height must be a positive integer");
                HeightBox.Focus();
            }
            else if(!Utility.isValidWeight(WeightBox.Text))
            {
                flag = false;
                MessageBox.Show("Weight must be a positive integer");
                WeightBox.Focus();
            }
            if (flag == true) {
                Patient Zero = new Patient(FnameBox.Text, LnameBox.Text, IdBox.Text, "", float.Parse(AgeBox.Text),
                        float.Parse(WeightBox.Text), float.Parse(HeightBox.Text), sex);
                MainPage.PatientList.Add(Zero);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FnameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
