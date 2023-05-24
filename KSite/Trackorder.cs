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
    public partial class Trackorder : Form
    {
        public Trackorder()
        {
            InitializeComponent();
        }

        private void Trackorder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Get the reference to the OrderStats form
            OrderStat orderStats = Application.OpenForms.OfType<OrderStat>().FirstOrDefault();
            if (orderStats != null)
            {
                orderStats.Close(); // Close the OrderStats form
            }

            // Get the reference to the Dashboard form
            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show(); // Show the Dashboard form
            }

            this.Close(); // Close the TrackOrder form
        }
    }
}
