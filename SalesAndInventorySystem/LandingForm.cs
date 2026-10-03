using System;
using System.Windows.Forms;

namespace UI
{

    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("Admin");
            loginForm.Show();
            this.Hide();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("Manager");
            loginForm.Show();
            this.Hide();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("Cashier");
            loginForm.Show();
            this.Hide();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {

        }
    }
}