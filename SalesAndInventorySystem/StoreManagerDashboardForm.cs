using System;
using System.Windows.Forms;

namespace SalesAndInventorySystem
{
    public partial class StoreManagerDashboardForm : Form
    {
        public StoreManagerDashboardForm(string username = "", string role = "")
        {
            InitializeComponent();

            lblWelcome.Text = string.IsNullOrWhiteSpace(username)
                ? "Welcome, Store Manager"
                : $"Welcome, {username} ({role})";
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sales module coming soon.", "Sales");
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inventory module coming soon.", "Inventory");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports module coming soon.", "Reports");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}