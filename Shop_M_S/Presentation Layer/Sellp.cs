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
    public partial class Sellp : Form
    {
        public Sellp()
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

        private void button1_Click(object sender, EventArgs e)
        {
            u.Pno = textBox1.Text;
            dt = da.UserDetails(u);
            if (dt.Rows.Count == 1)
            {

                label6.Text = dt.Rows[0][1].ToString();
                label7.Text = dt.Rows[0][2].ToString();
               
               
            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                label10.Text = (Convert.ToInt16(textBox2.Text) * Convert.ToInt16(label7.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >= label10.Text.Length)
            {
                label13.Text = (Convert.ToInt16(textBox3.Text) - Convert.ToInt16(label10.Text)).ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printD.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreview.Document = printD;
            printPreview.ShowDialog();
        }

        private void printD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Screenshot__24_;
                Image newImage = bmp;
            e.Graphics.DrawImage( newImage, 25, 25, newImage.Width, newImage.Height);

            e.Graphics.DrawString("Customer Name:  " + textBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 150));

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 200));

            e.Graphics.DrawString("Product Description", new Font("Arial", 12), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12), Brushes.Black, new Point(500, 220));
            e.Graphics.DrawString("Price", new Font("Arial", 12), Brushes.Black, new Point(700, 220));

            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 240));


            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString(label6.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));
            e.Graphics.DrawString("TK" +label7.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 290));
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 290));
            e.Graphics.DrawString("Total Prize :" +label10.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 310));

            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 350));
            e.Graphics.DrawString("Paid Money :" +textBox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 390));

            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 430));
            e.Graphics.DrawString("Return Money :" +label13.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 480));






        }
    }
}
