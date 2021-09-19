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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Users u = new Users();
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res.Equals(DialogResult.Yes))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("value cannot be null or 0");
                }

                else
                {
                    u.Pno = (textBox1.Text);
                    da.Delete(u);
                    MessageBox.Show("Successfully deleted");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminP a = new AdminP();
            this.Visible = false;
            a.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
