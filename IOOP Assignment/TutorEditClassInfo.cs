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

namespace IOOP_Assignment
{
    public partial class TutorEditClassInfo : Form
    {
        private string username;
        private string name;
        private Subjects subjects;
        public TutorEditClassInfo(string name, string username)
        {
            InitializeComponent();
            lblName.Text = name;
            this.username = username;
            this.name = name;
            subjects = new Subjects(username);
            loadTable();
        }

        private void loadTable()
        {
            for (int i = 0; i < subjects.subject.Count; i++)
            {
                gridList.Rows.Add(name, subjects.subject[i], subjects.day[i], subjects.startTime[i], subjects.endTime[i], "");

                //subjects.subject[i]
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
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    for (int index = 0; index < gridList.Rows.Count; index++)
                    {
                        string subject = gridList.Rows[index].Cells[1].Value.ToString();
                        string day = gridList.Rows[index].Cells[2].Value.ToString();
                        string startTime = gridList.Rows[index].Cells[3].Value.ToString();
                        string endTime = gridList.Rows[index].Cells[4].Value.ToString();
                        cmd.CommandText = "INSERT INTO Schedule(Username, Subject, Day, StartTime, EndTime) VALUES ('"+ username +"','" + subject + "','" + day + "','" + startTime + "','" + endTime + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Schedule updated successfully");
                    }
                }
               
            }

        }
    }
}
