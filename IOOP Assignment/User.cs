﻿using System;
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
    internal class User
    {
        private string username;
        private string password;

        public User(string a, string b)
        {
            username = a;
            password = b;
        }

        public string login()
        {
            string status = null;
            
            //SqlCommand objectName = new Constructor(sqlQuery, ConnectionString);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [User] WHERE Username = '" + username + "' and Password = '" + password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from [User] where Username ='" + username + "' and Password ='" + password + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    
                }
                else if (userRole == "student")
                {
                    frmMain stu = new frmMain(username);
                    stu.ShowDialog();
                }
                else if (userRole=="reception")
                {
                    ReceptionHomepage recepForm = new ReceptionHomepage(username);
                    recepForm.ShowDialog();
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