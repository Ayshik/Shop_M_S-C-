using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_M_S.Data_Acccess_Layer;

namespace Shop_M_S.Bussiness_Logic_Layer
{
    public class Users
    {


        DataAccess da = new DataAccess();


        public string Name { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
        public string Pno { get; set; }
        public string Pname { get; set; }
        public String Prize { get; set; }

    }
}
