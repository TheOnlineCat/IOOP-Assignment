using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    public partial class ReceptionEditDetail : Form
    {
        public string CurrentID;
        Student student;
        public ReceptionEditDetail(string newID)
        {
            InitializeComponent();
            CurrentID = newID;
            textBox_StudentID.Text = newID;

            /*if (New != true)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "select Name from [User] where Username = '" + ID + "'";
                        textBox_Name.Text = cmd.ExecuteScalar().ToString();
                        textBox_StudentID.Text = newID;

                    }
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "select * from Students where Username = '" + ID + "'";
                        SqlDataReader data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            textBox_Email.Text = data["Email"].ToString();
                            textBox_Contact.Text = data["ContactNumber"].ToString();
                            comboBox_Level.Text = data["Level"].ToString();
                            textBox_Day.Text = Convert.ToDateTime(data["DateEnrolled"]).ToString("dd");
                            textBox_Month.Text = Convert.ToDateTime(data["DateEnrolled"]).ToString("MM");
                            textBox_Year.Text = Convert.ToDateTime(data["DateEnrolled"]).ToString("yyyy");
                            textBox_Address.Text = data["Address"].ToString();
                            textBox_IC.Text = data["IC"].ToString();
                        }
                        data.Close();

                    }
                }
            }
            else
            {
                textBox_StudentID.Text = newID;
            }*/
        }

        public ReceptionEditDetail(Student student)
        {
            InitializeComponent();
            this.student = student;
            textBox_Name.Text = student.name;
            textBox_StudentID.Text = student.StudentID();
            textBox_Email.Text = student.email;
            textBox_Contact.Text = student.contact;
            comboBox_Level.Text = student.level;
            textBox_Day.Text = student.date.ToString("dd");
            textBox_Month.Text = student.date.ToString("MM");
            textBox_Year.Text = student.date.ToString("yyyy");
            textBox_Address.Text = student.address;
            textBox_IC.Text = student.IC;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string date = String.Join("/", new List<string> {
                        textBox_Day.Text.ToString(),
                        textBox_Month.Text.ToString(),
                        textBox_Year.Text.ToString()});

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmdTest = con.CreateCommand())
                {
                    cmdTest.CommandText = "Select count(*) from [User] where Username = '" + textBox_StudentID.Text.ToString() + "'";
                    int count = Convert.ToInt32(cmdTest.ExecuteScalar().ToString());
                    if (count > 0)
                    {

                        student.name = textBox_Name.Text.ToString();
                        student.email = textBox_Email.Text.ToString();
                        student.contact = textBox_Contact.Text.ToString();
                        student.level = comboBox_Level.Text.ToString();
                        student.date = Convert.ToDateTime(date);
                        student.address = textBox_Address.Text.ToString();
                        student.IC = textBox_IC.Text.ToString();

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE [User] set " +
                                "[Name] = '" + student.name + "'" +
                                "where Username = '" + student.StudentID() + "'";
                            cmd.ExecuteNonQuery();

                        }

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE [Students] set " +
                                "Email = '" + textBox_Email.Text.ToString() + "'," +
                                "ContactNumber = '" + textBox_Contact.Text.ToString() + "'," +
                                "Level = '" + comboBox_Level.Text.ToString() + "'," +
                                "DateEnrolled = '" + date + "'," +
                                "Address = '" + textBox_Address.Text.ToString() + "'," +
                                "IC = '" + textBox_IC.Text.ToString() + "'" +
                                "where Username = '" + textBox_StudentID.Text.ToString() + "'";
                            cmd.ExecuteNonQuery();

                        }
                        MessageBox.Show("Edited Student Records.", "Edit Status", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string newdata = String.Join("','", new List<string> {
                            textBox_StudentID.Text.ToString(),
                            textBox_Email.Text.ToString(),
                            textBox_Contact.Text.ToString(),
                            comboBox_Level.Text.ToString(),
                            date,
                            textBox_Address.Text.ToString(),
                            textBox_IC.Text.ToString()
                        });
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO [User](Username, Name, Role, Password) values('" +
                                textBox_StudentID.Text.ToString() + "','" +
                                textBox_Name.Text.ToString() + "','" +
                                "student" + "','" +
                                textBox_StudentID.Text.ToString() + "')";
                            cmd.ExecuteNonQuery();

                        }
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO [Students](Username, Email, ContactNumber, Level, DateEnrolled, Address, IC) values('" + newdata + "')";
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Added new Record.", "Enroll Status", MessageBoxButtons.OK);
                    }
                    this.Close();
                }
            }
        }

    }
}
