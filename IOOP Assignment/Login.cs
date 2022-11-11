using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string stat;
            User UserObj = new User(textBox_Username.Text, textBox_Password.Text);
            stat = UserObj.login();
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            textBox_Username.Text = String.Empty;
            textBox_Password.Text = String.Empty;
        }
    }
}
