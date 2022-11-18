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

namespace IOOP_Assignment
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
            groupBoxStaff.Hide();
            groupBoxReport.Hide();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            groupBoxStaff.Show();
            groupBoxReport.Hide();

            //arraylist allows you to create dynamic size array
            ArrayList name = new ArrayList();
            //call static method--> className.method(..)
            name = staff.ViewAll();
            foreach (var item in name)
            {
                listBoxStaff.Items.Add(item);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            groupBoxReport.Show();
            groupBoxStaff.Hide();
        }

        private void listBoxStaff_Load(object sender, EventArgs e)
        {
            //arraylist allows you to create dynamic size array
            ArrayList name = new ArrayList();
            //call static method--> className.method(..)
            name = staff.ViewAll();
            foreach (var item in name)
            {
                listBoxStaff.Items.Add(item);
            }
        }
    }
}
