using System;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        using (CashierLoginForm loginForm = new CashierLoginForm())
        {
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Branch navigation based on authenticated user role[cite: 37]
                string userRole = loginForm.AuthenticatedUserRole;

                switch (userRole)
                {
                    case "Cashier":
                    case "Sales Clerk":
                        // Redirect Cashier to the Point of Sale screen[cite: 37, 44]
                        Application.Run(new PosTerminalForm());
                        break;

                    case "Store Manager":
                    case "Administrator":
                        // Redirect Manager/Admin to Inventory Audit & Analytics[cite: 37, 53]
                        Application.Run(new MainDashboardForm());
                        break;

                    default:
                        MessageBox.Show("Unrecognized user role.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
    }
}