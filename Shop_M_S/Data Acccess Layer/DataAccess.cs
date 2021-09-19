using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Shop_M_S.Bussiness_Logic_Layer;

namespace Shop_M_S.Data_Acccess_Layer
{
    public class DataAccess
    {
        SqlConnection con;
        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=AYSH-STAR;Integrated Security=SSPI;Initial Catalog=A-shop");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public DataTable LoginC(Users e)
        {
            string query = string.Format("Select * from Login where UserId= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }
        public int CreateAccount(Users u)
        {
            int i = 0;
            string query = "INSERT INTO Login(Name,Password,Gender,Phone,Address) VALUES (' " + u.Name + " ', ' " + u.Password + " ', ' " + u.Gender + " ', ' " + u.Phone + " ', ' " + u.Address + " ')";
            SqlCommand cmd = new SqlCommand(query, con);



            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }


        public int AddP(Users u)
        {
            int i = 0;
            string query = "INSERT INTO Product(Pno,Pname,Prize) VALUES (' " + u.Pno + " ', ' " + u.Pname + " ', ' " + u.Prize + " ')";
            SqlCommand cmd = new SqlCommand(query, con);



            
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
            
        }


        public int Update(Users u)
        {
            int i = 0;
            string query = string.Format("UPDATE Product SET Pname='{0}', Prize='{1}' WHERE Pno={2}", u.Pname, u.Prize, u.Pno);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;
        }

        public bool Delete(Users u)
        {

            string query = string.Format("DELETE FROM Product WHERE Pno ={0}", u.Pno);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;

        }

        public DataTable UserDetails(Users u)
        {
            string query = string.Format("Select * from Product where Pno='{0}'", u.Pno);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }
    }
}
