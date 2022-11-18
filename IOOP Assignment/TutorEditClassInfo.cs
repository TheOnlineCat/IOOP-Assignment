using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace IOOP_Assignment
{
    public partial class TutorEditClassInfo : Form
    {
        private string username;
        private string name;
        private Schedule subjects;
        private Tutor tutor;

        public TutorEditClassInfo(string name, string username)
        {
            InitializeComponent();
            lblName.Text = name;
            this.username = username;
            this.name = name;
            tutor = new Tutor(username);
            subjects = new Schedule(username);
            loadTable();
        }

        private void loadTable()
        {
            for (int i = 0; i < subjects.Subject.Count; i++)
            {
                gridList.Rows.Add(name, subjects.SubjectName[i], subjects.Day[i], subjects.StartTime[i], subjects.EndTime[i], (new Subject(subjects.Subject[i])).ChargeRate);
            }
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            gridList.Rows.Add(name, "", "", "");
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            gridList.Rows.RemoveAt(gridList.CurrentCell.RowIndex);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal charges;
            if ( decimal.TryParse(txtCRate.Text.ToString(), out charges) == false)
            {
                MessageBox.Show("Enter a Valid Price for Charge Rate", "Price Error", MessageBoxButtons.OK);
                return;
            }

            Subject subObj = new Subject(tutor.Subject);
            subObj.ChargeRate = charges;
            subObj.SaveSubject();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    for (int index = 0; index < gridList.Rows.Count; index++)
                    {
                        string subjectname = gridList.Rows[index].Cells[1].Value.ToString();
                        string day = gridList.Rows[index].Cells[2].Value.ToString();
                        string startTime = gridList.Rows[index].Cells[3].Value.ToString();
                        string endTime = gridList.Rows[index].Cells[4].Value.ToString();
                        
                        
                        cmd.CommandText = "INSERT INTO Schedule(Username, Subject, SubjectName, Day, StartTime, EndTime) VALUES ('"+ username + "','" + tutor.Subject + "','" + subjectname + "','" + day + "','" + startTime + "','" + endTime + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Schedule updated successfully");
                    }  
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
