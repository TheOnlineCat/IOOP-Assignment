using System.Configuration;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System;

namespace IOOP_Assignment
{
    public partial class ReceptionHomepage : Form
    {
        private string StudentID;
        private Student student;
        public ReceptionHomepage()
        {
            InitializeComponent();
        }

        public ReceptionHomepage(string Username)
        {
            InitializeComponent();
            label_Username.Text = Username;
        }

        private void loadStudent(string StuID)
        {
            student = new Student(StuID);
            label_StudentName.Text = student.name;
            label_StudentID.Text = student.StudentID();
            label_Email.Text = "E-mail: " + student.email;
            label_Contact.Text = "Contact Number: " + student.contact;
            label_Level.Text = "Level: " + student.level;
            label_Date.Text = "Date Enrolled: " + student.date;
            label_Address.Text = "Address: " + student.address;
            label_IC.Text = "IC Number: " + student.IC;
            listBox_Subject.Items.Clear();
            if (student.subject.Count > 0) 
            {
                foreach (string subj in student.subject)
                {
                    if (subj != null) listBox_Subject.Items.Add(subj);
                }
            }

            /*using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select Name from [User] where Username = '" + StuID + "' and role = 'student'";
                    try
                    {
                        label_StudentName.Text = cmd.ExecuteScalar().ToString();
                    }
                    catch(NullReferenceException e)
                    {
                        MessageBox.Show("Record Does not Exist.");
                        return;
                    }
                    label_StudentID.Text = StuID;

                }
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from Students where Username = '" + StuID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        label_Email.Text = "E-mail: " + data["Email"];
                        label_Contact.Text = "Contact Number: " + data["ContactNumber"];
                        label_Level.Text = "Level: " + data["Level"];
                        label_Date.Text = "Date Enrolled: " + Convert.ToDateTime(data["DateEnrolled"]).ToString("dd/MM/yyyy");
                        label_Address.Text = "Address: " + data["Address"];
                        label_IC.Text = "IC Number: " + data["IC"];
                        listBox_Subject.Items.Clear();
                        if (data["Subject1"].ToString() != null) listBox_Subject.Items.Add(data["Subject1"]);
                        if (data["Subject2"].ToString() != null) listBox_Subject.Items.Add(data["Subject2"]);
                        if (data["Subject3"].ToString() != null) listBox_Subject.Items.Add(data["Subject3"]);
                    }
                    data.Close();
                }
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from PaymentInfo where Username = '" + StuID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        label_FeeDue.Text = "Total Due: " + data["Amount"];
                        label_FeePaid.Text = "Total Paid: " + data["PaidAmount"];
                        label_FeeOutstand.Text = "Outstanding: " + data["Outstanding"];
                    }
                    data.Close();
                }
            }*/
        }


        private void button_Search_Click(object sender, EventArgs e)
        {
            StudentID = textBox_Search.Text;
            loadStudent(StudentID);

        }

        private void button_Enroll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select Username from [User] order by Username desc";
                    int Highest = Convert.ToInt32(cmd.ExecuteScalar().ToString().Remove(0, 2));
                    string ID = (Highest + 1).ToString().PadLeft(3, '0');
                    string NewID = "ET" + ID;
                    ReceptionEditDetail formAddStudent = new ReceptionEditDetail(student);
                    formAddStudent.Show();
                    StudentID = formAddStudent.CurrentID;
                    formAddStudent.FormClosing += EditFormClosing;
                }
            }
            
        }

        private void button_EditDetails_Click(object sender, EventArgs e)
        {
            if (label_StudentID.Text != "Student ID")
            {
                ReceptionEditDetail formAddStudent = new ReceptionEditDetail(student);
                formAddStudent.Show();
                StudentID = formAddStudent.CurrentID;
                formAddStudent.FormClosing += EditFormClosing;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_StudentID.Text == "Student ID")
            {
                return;
            }
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "DELETE FROM [Students] where Username = '" + label_StudentID.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                    } finally { cmd.Dispose(); }
                    try
                    {
                        cmd.CommandText = "DELETE FROM [PaymentInfo] where Username = '" + label_StudentID.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                    } finally { cmd.Dispose(); }
                    try
                    {
                        cmd.CommandText = "DELETE FROM [User] where Username = '" + label_StudentID.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                    } finally { cmd.Dispose(); }
                }
            }
        }

        private void EditFormClosing(object sender, FormClosingEventArgs e)
        {
            loadStudent(StudentID);
        }
    }
}