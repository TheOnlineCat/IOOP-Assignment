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
            this.IC = IC;
            this.address = address;
            this.email = email;
            this.contact = contactNum;
            this.subject[0] = sub1;
            this.subject[1] = sub2;
            this.subject[2] = sub3;
        }*/
        public void SaveData()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [Students] set " +
                        "Email = '" + this.email + "'," +
                        "ContactNumber = '" + this.contact + "'," +
                        "Level = '" + this.level + "'," +
                        "DateEnrolled = '" + this.date.ToString("dd/MM/yyyy") + "'," +
                        "Address = '" + this.address + "'," +
                        "IC = '" + this.IC + "'" +
                        "where Username = '" + StudentID() + "'";
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public string StudentID()
        {
            return studentID;
        }

        public static bool Exists(string ID)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmdTest = con.CreateCommand())
                {
                    cmdTest.CommandText = "Select count(*) from [Student] where Username = '" + ID + "'";
                    int count = Convert.ToInt32(cmdTest.ExecuteScalar().ToString());
                    if (count > 0) return true;
                    else return false;
                }
            }
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select Name from [User] where Username = '" + studentID + "' and role = 'student'";
                    try
                    {
                        name = cmd.ExecuteScalar().ToString();
                    }
                    catch(Exception ex) { return; }
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

        

    }
}
