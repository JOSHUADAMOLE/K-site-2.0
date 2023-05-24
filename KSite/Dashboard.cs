using KSite.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSite
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        static Dashboard _obj;
        public static Dashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBox3.Parent = panel1;
            pictureBox3.BackColor = Color.Transparent;
            button1.BackColor = Color.DarkGray;
            button2.BackColor = Color.DarkGray;
            button3.BackColor = Color.DarkGray;
            button4.BackColor = Color.DarkGray;
            button5.BackColor = Color.DarkGray;
            _obj = this;

            home hm = new home();
            hm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(hm);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("home"))
            {
                home hm = new home();
                hm.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(hm);
            }
            Dashboard.Instance.PnlContainer.Controls["home"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("Store"))
            {
                Store st = new Store();
                st.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(st);
            }
            Dashboard.Instance.PnlContainer.Controls["Store"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            using (FAQ sc = new FAQ())
            {
                sc.StartPosition = FormStartPosition.CenterParent;
                sc.ShowDialog(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            using (OrderStat sc = new OrderStat())
            {
                sc.StartPosition = FormStartPosition.CenterParent;
                sc.ShowDialog(this);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            using (announce sc = new announce())
            {
                sc.StartPosition = FormStartPosition.CenterParent;
                sc.ShowDialog(this);
            }
        }

        public static int parentX, parentY;

        private void store1_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (Popup pp = new Popup())
            {
                pp.StartPosition = FormStartPosition.Manual;
                pp.ShowDialog();

                parentX = this.Location.X;
                parentY = this.Location.Y;
            }
        }
    }
}
