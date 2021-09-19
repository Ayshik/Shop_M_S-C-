using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_M_S.Presentation_Layer
{
    public partial class AdminP : Form
    {
        public AdminP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sellp sp = new Sellp();
            this.Visible = false;
            sp.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login sp = new Login();
            this.Visible = false;
            sp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddP ap = new AddP();
            this.Visible = false;
            ap.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update au = new Update();
            this.Visible = false;
            au.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete au = new Delete();
            this.Visible = false;
            au.Visible = true;
        }
    }
}
