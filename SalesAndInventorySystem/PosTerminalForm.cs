using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class PosTerminalForm : Form
    {
        public PosTerminalForm()
        {
            InitializeComponent();
            Text = "Point of Sale";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 650);

            Label title = new Label
            {
                Text = "Cashier Point of Sale",
                Dock = DockStyle.Top,
                Height = 60,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 20F, FontStyle.Bold)
            };

            Controls.Add(title);
        }
    }
}
