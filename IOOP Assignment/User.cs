using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class User
    {
        private string username;
        private string name;

        public User(string a)
        {
            username = a;
        }

        public void ChangeName(string Name)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [User] set " +
                        "[Name] = '" + Name + "'" +
                        "where Username = '" + username + "'";
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public Form login(string password)
        {
            //SqlCommand objectName = new Constructor(sqlQuery, ConnectionString);
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [User] WHERE Username = '" + username + "' and Password = '" + password + "'", con);
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                if (count > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("select Role from [User] where Username ='" + username + "' and Password ='" + password + "'", con);
                    SqlCommand cmd3 = new SqlCommand("select Name from [User] where Username ='" + username + "' and Password ='" + password + "'", con);
                    string userRole = cmd2.ExecuteScalar().ToString();
                    string name = cmd3.ExecuteScalar().ToString();
                    //I FUCKING LOVE DICKS
                    if (userRole == "admin")
                    {

                    }
                    else if (userRole == "student")
                    {
                        frmMain stu = new frmMain(name, username);
                        stu.Show();
                        return (stu);
                    }
                    else if (userRole == "reception")
                    {
                        ReceptionHomepage recepForm = new ReceptionHomepage(name);
                        recepForm.Show();
                        return (recepForm);
                    }
                    else if (userRole == "tutor")
                    {
                        TutorClassInfo tut = new TutorClassInfo(name, username);
                        tut.Show();
                        return (tut);
                    }
                }
                return null;
            }
        }
    }
}
