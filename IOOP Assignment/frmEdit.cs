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
    public partial class frmEdit : Form
    {
        Student student;
        public frmEdit()
        {
            InitializeComponent();
        }

        public frmEdit(Student student)
        {
            InitializeComponent();
            student.Name=lblOutputName.ToString();
            student.IC=lblIC.ToString();
            student.Address=txtAdd.ToString();
            student.Email=txtEmail.ToString();
            student.Contact=txtContact.ToString();
            student.Level=lblLvl.ToString();
        }


        private void lblIC_Click(object sender, EventArgs e)
        {

        }

        private void grpEdit_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            

        }

        private void frmEdit_Load_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
