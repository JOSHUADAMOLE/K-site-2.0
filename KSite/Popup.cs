using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSite
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void Popup_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Dashboard.parentX = 1137, Dashboard.parentY = 320);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Show the login form
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
