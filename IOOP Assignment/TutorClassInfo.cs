namespace IOOP_Assignment
{
    public partial class TutorClassInfo : Form
    {   
        public TutorClassInfo(string Name)
        {
            InitializeComponent();
            lblName.Text = Name;
        }


        private void btnCInfo_Click(object sender, EventArgs e)
        {
            TutorEditClassInfo s = new TutorEditClassInfo();
            s.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TutorEditProfile s = new TutorEditProfile();
            s.Show();
            this.Hide();
        }

        private void btnSList_Click(object sender, EventArgs e)
        {
            TutorStudentList s = new TutorStudentList();
            s.Show();
            this.Hide();
        }
    }
}