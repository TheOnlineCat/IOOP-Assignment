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
    public partial class TutorEditProfile : Form
    {
        public TutorEditProfile()
        {
            InitializeComponent();
            grpPass.Visible = false;
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpPass.Visible = true;
        }
    }
}
