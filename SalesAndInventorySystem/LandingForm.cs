using BusinessLogic.Controller;
using BusinessLogic.Repository;
using Model;
using SalesAndInventorySystem;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LandingForm : Form
    {
        public static string AuthenticatedUserRole { get; set; } = string.Empty;
        public LandingForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();

            using (AdminLoginForm login = new AdminLoginForm())
            {
                if (login.ShowDialog(this) == DialogResult.OK)
                {
                    AuthenticatedUserRole = "Admin";
                    using (AdminPortalForm adminPortal = new AdminPortalForm())
                    {
                        adminPortal.ShowDialog(this);
                    }
                }
            }

            Show();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
            // In-memory data is empty on every start, so create the default admin account.
            var users = new UserController(new UserRepository());
            if (!users.GetAll().Any(u => u.Role == "Admin"))
            {
                users.Create(new User { Username = "admin", FullName = "System Administrator", Role = "Admin" }, "admin123");
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            AuthenticatedUserRole = "Store Manager";
            this.Hide();

            using (StoreManagerLoginForm managerLogin = new StoreManagerLoginForm())
            {
                DialogResult result = managerLogin.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    using (StoreManagerDashboardForm managerDashboard = new StoreManagerDashboardForm())
                    {
                        managerDashboard.ShowDialog(this);
                    }
                }
            }

            this.Show();
        }

    

        private void btnCashier_Click(object sender, EventArgs e)
        {
            AuthenticatedUserRole = "Cashier";
            using (CashierLoginForm cashierLogin = new CashierLoginForm())
            {
                if (cashierLogin.ShowDialog(this) == DialogResult.OK)
                {
                    // Open the cashier/POS screen only after successful authentication.
                    Hide();
                    using (Form posForm = new PosTerminalForm())
                    {
                        posForm.ShowDialog(this);
                    }

                    Show();
                }
            }
        }



        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }
    }
}
