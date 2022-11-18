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
    public partial class frmViewStatus : Form
    {
        Student student;
        string ViewRequests;
        public frmViewStatus()
        {
            InitializeComponent();
        }

        public frmViewStatus(Student student)
        {
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmViewStatus_Load(object sender, EventArgs e)
        {

        }

         private void frmViewStatus_Load_1(object sender, EventArgs e)
        {

        }

        private void lstDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            Requests ViewReq = new Requests();
            ViewRequests = ViewReq.ViewReq_Status();

        }

        private void lblName_StuID_Click(object sender, EventArgs e)
        {
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
        }
    }
}
