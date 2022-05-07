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
            if (UsernameBox.Text == "" || PasswordBox.Text == "" || IDBox.Text == "")
                MessageBox.Show("Please fill the whole form.");
            else
            {
                Doctor General = new Doctor(UsernameBox.Text, PasswordBox.Text, IDBox.Text);
                if (this.inputTester())
                {
                    LoginForm.DoctorList.Add(General);
                    this.Close();
                }
            }
        }

        private bool isValidIsraeliID(string id)
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

        private bool isValidUsername(string username)
        {
            if (username.Length < 6 && username.Length > 8) return false;
            var LetterNum = username.Count(char.IsLetter);
            var IntNum = username.Count(x => Char.IsDigit(x));
            if (IntNum <= 2 && (username.Length - LetterNum == IntNum))
                return true;
            else return false;
        }

        private bool isValidPassword(string password)
        {
            if (password.Length < 8 && password.Length > 10) return false;
            int IntNum , LetterNum, SpecialNum;
            LetterNum = password.Count(char.IsLetter);
            IntNum = password.Count(x => Char.IsDigit(x));
            SpecialNum = password.Length - IntNum - LetterNum;
            return (IntNum > 0 && LetterNum > 0 && SpecialNum > 0);
        }


        private bool inputTester()
        {
            bool flag = true;
 
            if (!isValidUsername(UsernameBox.Text))
            {
                flag = false;
                MessageBox.Show("A username most be between 6 to 8 character long with up 2 numbers!");
                UsernameBox.Focus();
            }
            if (!isValidPassword(PasswordBox.Text))
            {
                flag = false;
                MessageBox.Show("A password most contain at least one letter, one number and one speciel character and have between 8 to 10 character!");
                PasswordBox.Focus();
            }
            if (!isValidIsraeliID(IDBox.Text))
            {
                flag = false;
                MessageBox.Show("The inputted ID is not vaild.\nPlease input a valid Israeli ID number.");
                IDBox.Focus();
            }
            return flag;
        }
    }
}
