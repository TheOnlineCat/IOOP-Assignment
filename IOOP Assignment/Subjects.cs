using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Subjects
    {
        private string username;
        public List<string> subject = new List<string>();
        public List<string> day = new List<string>();
        public List<TimeOnly> startTime = new List<TimeOnly>();
        public List<TimeOnly> endTime = new List<TimeOnly>();
        public List<decimal> charges = new List<decimal>();

        public Subjects(string username)
        {
            this.username = username;
            loadTable();    
        }

        public void loadTable()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from Schedule where Username = '" + username + "'";
                    //MessageBox.Show(cmd.ExecuteScalar().ToString());
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        subject.Add(data["Subject"].ToString());
                        day.Add(data["Day"].ToString());
                        startTime.Add(TimeOnly.FromDateTime(Convert.ToDateTime(data["StartTime"].ToString())));
                        endTime.Add(TimeOnly.FromDateTime(Convert.ToDateTime(data["EndTime"].ToString())));
                        //charges.Add(Convert.ToDecimal(data["Charges"]));
                    }
                    data.Close();
                }
            }
        }

    }
}
