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
    public partial class RegisteryForm : Form
    {
        public RegisteryForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int index;
            LoginForm f = new LoginForm();
            if (Utility.isEmpty(UsernameBox.Text) || Utility.isEmpty(PasswordBox.Text)|| Utility.isEmpty(IDBox.Text))
                MessageBox.Show("Please fill the whole form.");
            else
            {
                Doctor General = new Doctor(UsernameBox.Text, PasswordBox.Text, IDBox.Text);
                if (this.inputTester())
                {
                    this.Hide();
                    LoginForm.DoctorList.Add(General);
                    index = LoginForm.DoctorList.Count - 1;
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
            }
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
        private bool inputTester()
        {
            bool flag = true;
 
            if (!Utility.isValidUsername(UsernameBox.Text))
            {
                flag = false;
                MessageBox.Show("A username most be between 6 to 8 character long with up 2 numbers!");
                UsernameBox.Focus();
            }
            if (!Utility.isValidPassword(PasswordBox.Text))
            {
                flag = false;
                MessageBox.Show("A password most contain at least one letter, one number and one speciel character and have between 8 to 10 character!");
                PasswordBox.Focus();
            }
            if (!Utility.isValidIsraeliID(IDBox.Text))
            {
                flag = false;
                MessageBox.Show("The inputted ID is not vaild.\nPlease input a valid Israeli ID number.");
                IDBox.Focus();
            }
            return flag;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            IDBox.Text = "";
        }
    }
}
