namespace Tests___Project

{
    public partial class LoginForm : Form
    {
        public static List<Doctor> DoctorList = new List<Doctor>();
        public LoginForm()
        {
            DoctorList = new List<Doctor>();
            DoctorList.Add(new Doctor("Admin45", "Admin45!", "315126201"));
            //Utility.createExcel();
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
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
                if (UsernameBox.Text == DoctorList[i].getUsername())
                {
                    if (PasswordBox.Text == DoctorList[i].getPassword())
                    {
                        this.Hide();
                        MainPage f = new MainPage();
                        UsernameBox.Text = "";
                        PasswordBox.Text = "";
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                        return;
                    }
                }
            }
            MessageBox.Show("Username or password are incorrect!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}