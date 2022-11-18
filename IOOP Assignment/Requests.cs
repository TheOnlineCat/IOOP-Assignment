using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    internal class Requests
    {
        string stuID;
        string subToChange;
        string subToChoose;
        string reason;
        Student student;
        string ShowReq;
        string ShowStatus;
        
        public Requests()
        {

        }
        public Requests(string stuID)
        {
            this.stuID = stuID;
        }

        public Requests(string subToChange, string subToChoose, string reason)
        {
            this.subToChange = subToChange;
            this.subToChoose = subToChoose;
            this.reason = reason;
        }

        public void GetSubToChange(string subToChange, string subToChoose, string reason)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert [Requests] set " + "Receipient = " + stuID + "Subject To Choose = '" + subToChoose + "Subject To Change = '" + subToChange + "Reason = " + reason + "Status ='Pending' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string ViewReq_Status()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Subject To Change,Subject To Choose,Status from [Requests] where Username = '" + stuID + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ShowReq = reader[0].ToString()+" "+"To"+reader[1].ToString();
                ShowStatus = reader[2].ToString();
            }
            return ShowReq;
            return ShowStatus;
        }

        public void DelReq()
        {

        }

        
    }
    
}

