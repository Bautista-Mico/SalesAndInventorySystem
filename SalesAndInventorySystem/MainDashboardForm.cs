using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
            Text = "Main Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1100, 700);

            Label title = new Label
            {
                Text = "Inventory Audit & Analytics Dashboard",
                Dock = DockStyle.Top,
                Height = 60,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 20F, FontStyle.Bold)
            };

            Controls.Add(title);
        }
    }
}
