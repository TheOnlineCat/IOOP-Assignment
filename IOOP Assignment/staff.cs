using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;
using System.Configuration;

namespace IOOP_Assignment
{
    public class staff
    {
        private string staffID;
        private string staffName;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());

        public static ArrayList ViewAll()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("se1ect Name from User", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));//add element into arraylist
            }
            con.Close();
            return nm;

        }
    }
}

    
