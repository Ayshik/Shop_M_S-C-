using Shop_M_S.Presentation_Layer;
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
namespace Shop_M_S
{
    public partial class Login : Form
    {

        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Boolean state = false;
        Users em = new Users();

        public Login()
        {
            InitializeComponent();

            textBox2.PasswordChar = '#';
            textBox2.MaxLength = 10;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == " " || textBox2.Text == " ")
            {
                MessageBox.Show("TextBox cannot be empty");
            }
            else
            {
                em.UserId = textBox1.Text;
                em.Password = textBox2.Text;



                {
                    if (state == false)
                    {
                        dt = da.LoginC(em);

                        if (dt.Rows.Count ==1)
                        {
                            state = true;
                            AdminP a = new AdminP();
                            this.Visible = false;
                            a.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                        if (state == false)
                        {
                            MessageBox.Show("Error 69....Invalid id,No ID found in Database");
                        }

                    }


                }
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup acc = new Signup();
            this.Visible = false;
            acc.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
