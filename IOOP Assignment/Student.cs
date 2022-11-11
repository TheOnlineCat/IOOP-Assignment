using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Student:User
    {
        private string studentID;
        public string name;
        public string level;
        public string IC;
        public string address;
        public string email;
        public string contact;
        public DateTime date;
        public List<string> subject;
        public string feeTotal;
        public string feePaid;
        public string feeOutstand;


        public Student(string studentID) : base(studentID)
        {
            this.studentID = studentID;
            LoadData();
        }

/*        public Student(string name, string studentID, string level, string iC, string address, string email, string contactNum, string sub1, string sub2, string sub3) : this(name, studentID)
        {
            this.level = level;
            IC = iC;
            this.address = address;
            this.email = email;
            this.contact = contactNum;
            this.subject[0] = sub1;
            this.subject[1] = sub2;
            this.subject[2] = sub3;
        }*/

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select Name from [User] where Username = '" + studentID + "' and role = 'student'";
                    name = cmd.ExecuteScalar().ToString();
                }


                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from Students where Username = '" + studentID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        level = data["Level"].ToString();
                        IC = data["IC"].ToString();
                        address = data["Address"].ToString();
                        email = data["Email"].ToString();
                        contact = data["ContactNumber"].ToString();
                        date = Convert.ToDateTime(data["DateEnrolled"]);
                        subject = new List<string> { data["Subject1"].ToString(), data["Subject2"].ToString(), data["Subject3"].ToString() };
                    }
                    data.Close();
                }

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from PaymentInfo where Username = '" + studentID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        feeTotal = data["Amount"].ToString();
                        feePaid = data["PaidAmount"].ToString();
                        feeOutstand = data["Outstanding"].ToString();
                    }
                    data.Close();
                }
            }
        }

        public string StudentID()
        {
            return studentID;
        }

    }
}
