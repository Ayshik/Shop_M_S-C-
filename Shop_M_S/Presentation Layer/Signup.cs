using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_M_S.Data_Acccess_Layer;
using Shop_M_S.Bussiness_Logic_Layer;

namespace Shop_M_S.Presentation_Layer
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Users u = new Users();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.Name = textBox1.Text;
            u.Address = textBox3.Text;
            u.Phone = textBox4.Text;
            u.Gender = comboBox1.Text;
            u.Password = textBox2.Text;
            int i = da.CreateAccount(u);
            if (i > 0)
            {
                MessageBox.Show("Succesfully Created");
            }
            else
            {
                MessageBox.Show("Something Wrong try again");
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Visible = false;
            a.Visible = true;
        }
    }
}
