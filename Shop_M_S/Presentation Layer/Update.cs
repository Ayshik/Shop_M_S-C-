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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Users u = new Users();

        private void button3_Click(object sender, EventArgs e)
        {
            AdminP a = new AdminP();
            this.Visible = false;
            a.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.Pno = textBox1.Text;
            u.Pname = textBox2.Text;
            u.Prize = textBox3.Text;
            int i = da.Update(u);
            if (i > 0)
            {
                MessageBox.Show("Succesfully Updated");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
