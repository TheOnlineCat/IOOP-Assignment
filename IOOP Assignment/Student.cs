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
        private string _studentID;
        private string _name;
        private string _level;
        private string _ic;
        private string _address;
        private string _email;
        private string _contact;
        private DateTime _date;
        private List<string> _subject;
        private string _feeTotal;
        private string _feePaid;
        private string _feeOutstand;

        public Student(string studentID) : base(studentID)
        {
            this._studentID = studentID;
            LoadData();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public string IC
        {
            get { return _ic; }
            set { _ic = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public List<string> GetSubjects()
        {
            return _subject;
        }

        public string SetSubject(string replace, string insert)
        {
            for (int i = 0; i < _subject.Count(); i++)
            {
                if (_subject[i] == replace)
                {
                    _subject[i] = insert;
                    return(replace);
                }
            }
            return null;
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
                        "Email = '" + this._email + "'," +
                        "ContactNumber = '" + this._contact + "'," +
                        "Level = '" + this._level + "'," +
                        "DateEnrolled = '" + this._date.ToString("MM/dd/yyyy") + "'," +
                        "Address = '" + this._address + "'," +
                        "IC = '" + this._ic + "'" +
                        "where Username = '" + StudentID() + "'";
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public string StudentID()
        {
            return _studentID;
        }

        public static bool Exists(string ID)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmdTest = con.CreateCommand())
                {
                    cmdTest.CommandText = "Select count(*) from [Students] where Username = '" + ID + "'";
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
                    cmd.CommandText = "select Name from [User] where Username = '" + _studentID + "' and role = 'student'";
                    try
                    {
                        _name = cmd.ExecuteScalar().ToString();
                    }
                    catch(Exception ex) { return; }
                }


                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from Students where Username = '" + _studentID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        _level = data["Level"].ToString();
                        _ic = data["IC"].ToString();
                        _address = data["Address"].ToString();
                        _email = data["Email"].ToString();
                        _contact = data["ContactNumber"].ToString();
                        _date = Convert.ToDateTime(data["DateEnrolled"]);
                        _subject = new List<string> { data["Subject1"].ToString(), data["Subject2"].ToString(), data["Subject3"].ToString() };
                    }
                    data.Close();
                }

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from PaymentInfo where Username = '" + _studentID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        _feeTotal = data["Amount"].ToString();
                        _feePaid = data["PaidAmount"].ToString();
                        _feeOutstand = data["Outstanding"].ToString();
                    }
                    data.Close();
                }
            }
        }

        

    }
}
