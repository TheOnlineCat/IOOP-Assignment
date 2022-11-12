using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    public partial class ReceptionHomepage : Form
    {
        public ReceptionHomepage()
        {
            InitializeComponent();
        }

        public ReceptionHomepage(string Username)
        {
            InitializeComponent();
            label_Username.Text = Username;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string StuID = textBox_Search.Text;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select Name from [User] where Username = '" + StuID + "'";
                    label_StudentName.Text = cmd.ExecuteScalar().ToString();
                    label_StudentID.Text = StuID;

                }
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from Students where Username = '" + StuID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())  
                    {
                        label_Email.Text = "E-mail: " + data["Email"].ToString();
                        label_Contact.Text = "Contact Number: " + data["ContactNumber"].ToString();
                        label_Level.Text = "Level: " + data["Level"].ToString();
                        label_Date.Text = "Date Enrolled: " + data["DateEnrolled"].ToString();
                        label_Address.Text = "Address: " + data["Address"].ToString();
                        label_IC.Text = "IC Number: " + data["IC"].ToString();
                        listBox_Subject.Items.Clear();
                        if (data["Subject1"].ToString() != null) listBox_Subject.Items.Add(data["Subject1"].ToString());
                        if (data["Subject2"].ToString() != null) listBox_Subject.Items.Add(data["Subject2"].ToString());
                        if (data["Subject3"].ToString() != null) listBox_Subject.Items.Add(data["Subject3"].ToString());
                    }
                    data.Close();
                }
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from PaymentInfo where Username = '" + StuID + "'";
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read()) 
                    {
                        label_FeeDue.Text = "Total Due: " + data["Amount"].ToString();
                        label_FeePaid.Text = "Total Paid: " + data["PaidAmount"].ToString();
                        label_FeeOutstand.Text = "Outstanding: " + data["Outstanding"].ToString();
                    }
                    data.Close();
                }
            }

        }

        private void button_Enroll_Click(object sender, EventArgs e)
        {
            ReceptionEditDetail formAddStudent = new ReceptionEditDetail();
            formAddStudent.Show();
        }
    }
}