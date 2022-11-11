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
        private ArrayList Data = new ArrayList();
        private SqlCommand cmd = new SqlCommand("select * from Schedule");

        public TutorEditClassInfo()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            gridList.Rows.Add("", "", "", "");
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            gridList.Rows.RemoveAt(gridList.CurrentCell.RowIndex);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /*
            for (int index = 0; 0  < gridList.Rows.Count; index++) 
            {
                //gridList.Rows[index].Cell
            }    
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Schedule(Subject, Day, StartTime, EndTime) VALUES (" + ")");
            ArrayList data = new ArrayList();
            MessageBox.Show(cmd.ExecuteReader().ToString());
            */
        }
    }
}
