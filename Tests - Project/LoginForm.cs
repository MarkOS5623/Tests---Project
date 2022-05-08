namespace Tests___Project

{
    public partial class LoginForm : Form
    {
        public static List<Doctor> DoctorList = new List<Doctor>();
        public LoginForm()
        {
            DoctorList = new List<Doctor>();
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Users\markos\Documents\UserData.xlsx") == false)
            {
                Excel excel = new Excel();
                excel.CreateNewFile();
                excel.CreateNewSheet();
                excel.SaveAs(@"UserData.xlsx");
                excel.Close();
            }
        }

        public static void WriteToExcel(int col, int row, String s)
        {
            Excel excel = new Excel(@"UserData.xlsx", 1);
            excel.WriteToCell(col, row, s);
            excel.Save();
            excel.Close();
        }
       
        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to quit the program?\nQuitting the program will erase the inputted information.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
                Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisteryForm f = new RegisteryForm();
            f.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel(@"UserData.xlsx", 1);
            for (int i = 0; i < DoctorList.Count; i++)
            {
                if (UsernameBox.Text == excel.ReadCell(i,0)) { 
                    if(PasswordBox.Text == excel.ReadCell(i, 1))
                    {
                        MainPage f = new MainPage();
                        UsernameBox.Text = "";
                        PasswordBox.Text = "";
                        excel.Close();
                        f.ShowDialog();
                    }
                    else MessageBox.Show("Incorrect password!!");
                }
                else MessageBox.Show("Incorrect username!!");
            }
            excel.Close();
        }
    }
}