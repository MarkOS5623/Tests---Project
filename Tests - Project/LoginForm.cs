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
        }
        public void createExcel()
        {
            Excel excel = new Excel();
            excel.CreateNewFile();
            excel.CreateNewSheet();
            excel.Save();
            excel.Close();
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
            iExit = MessageBox.Show("Are you sure you want to quit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
                Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisteryForm f = new RegisteryForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DoctorList.Count; i++)
            {
                if (UsernameBox.Text == DoctorList[i].getUsername()) { 
                    if(PasswordBox.Text == DoctorList[i].getPassword())
                    {
                        this.Hide();
                        MainPage f = new MainPage();
                        UsernameBox.Text = "";
                        PasswordBox.Text = "";
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                    else MessageBox.Show("Incorrect password!!");
                }
                else MessageBox.Show("Incorrect username!!");
            }
        }
    }
}