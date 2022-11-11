using System.Configuration;
using System.Data.SqlClient;

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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string StuID = textBox_Search.Text;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
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

                    }
                }
            }

        }

    }
}