using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class EditProfile : Form
    {
        public EditProfile(string name, string username)
        {
            InitializeComponent();
            grpPass.Visible = false;
            lblName.Text = name;    

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpPass.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    if (txtPassword.Text == txtCPassword.Text && txtCurrPassword.Text == txtCPassword.Text )
                    {
                        cmd.CommandText = "UPDATE [User] SET ('" + txtUsername.Text.ToString() + "', '" + txtName.Text.ToString() + "', 'tutor','" + txtCPassword.Text.ToString() + "')";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Password do not match");
                    }
                }



            }
                

        }
    }
}
