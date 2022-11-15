using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Requests
    {
        string stuID;
        string subToChange;
        string subToChoose;
        string reason;
        public Requests(string stuID)
        {
            this.stuID = stuID;
        }

        public void GetSubToChange(string subToChange,string subToChoose,string reason)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert [Requests] set " + "Receipient = " + stuID + "Subject To Choose = '" + subToChoose + "Subject To Change = '" + subToChange + "Reason = " + reason + "Status ='Pending' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
    }
}
