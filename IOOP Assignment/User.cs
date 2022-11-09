using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class User
    {
        private string username;
        private string password;

        public User(string a, string b)
        {
            username = a;
            password = b;
        }

        public string login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //SqlCommand objectName = new Constructor(sqlQuery, ConnectionString);
            SqlCommand cmd = new SqlCommand("select count(*) from users where username='" + username + "'and password ='" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username ='" + username + "' and password ='" + password + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    frmAdminHome a = new frmAdminHome();
                    a.ShowDialog();
                }
                else if (userRole == "student")
                {
                    frmMain stu = new frmMain(un);
                    stu.ShowDialog();
                }
                else if (userRole=="reception")
                {

                }
                else if (userRole=="tutor")
                {

                }
            }
            else
                status="Incorrect username/password entered.";
            con.Close();

            return status;
        }
    }
}
