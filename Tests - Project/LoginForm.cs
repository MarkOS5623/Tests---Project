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
            OpenFile();
        }

        public void OpenFile()
        {
            Excel excel = new Excel(@"C:\Users\marko\source\repos\Tests - Project\Tests - Project\TEST.xlsx", 1);
            excel.WriteToCell(0, 1, "Beans");
            excel.Save();
            MessageBox.Show(excel.ReadCell(0, 1));
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
            RegisteryForm f2 = new RegisteryForm();
            f2.ShowDialog();
        }
    }
}