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
            Excel ex = new Excel();
            ex.CreateNewFile();
            ex.CreateNewSheet();
            ex.SaveAs(@"Data");
            ex.Close();
            
        }

        public void OpenFile()
        {
            Excel excel = new Excel(@"Data.xlsx", 1);
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
            for (int i = 0; i < DoctorList.Count; i++)
            {
                if (UsernameBox.Text == DoctorList[i].getUsername()) { 
                    if(PasswordBox.Text == DoctorList[i].getPassword())
                    {
                        MainPage f = new MainPage();
                        UsernameBox.Text = "";
                        PasswordBox.Text = "";
                        f.ShowDialog();
                    }
                    else MessageBox.Show("Incorrect password!!");
                }
                else MessageBox.Show("Incorrect username!!");
            }
        }
    }
}