namespace IOOP_Assignment
{
    public partial class TutorClassInfo : Form
    {
        private string name;
        private string username;
        private Schedule subjects;
        public TutorClassInfo(string name, string username)
        {
            InitializeComponent();
            lblName.Text = name;
            this.name = lblName.Text;
            this.username = username;
            subjects = new Schedule(username);
            loadTable();
        }

        private void loadTable()
        {
            for (int i = 0; i < subjects.subject.Count; i++)
            {
                gridClass.Rows.Add(name, subjects.subject[i], subjects.day[i], subjects.startTime[i], subjects.endTime[i], ""); 
                 
                //subjects.subject[i]
            }
        }


        private void btnCInfo_Click(object sender, EventArgs e)
        {
            TutorEditClassInfo s = new TutorEditClassInfo(name, username);
            s.Show();
            this.Hide();
            s.FormClosed += child_FormClosed;
        }

        private void child_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditProfile s = new EditProfile(username);
            s.Show();
            this.Hide();
            s.FormClosed += child_FormClosed;
        }

        private void btnSList_Click(object sender, EventArgs e)
        {
            TutorStudentList s = new TutorStudentList(username);
            s.Show();
            this.Hide();
            s.FormClosed += child_FormClosed;
        }
    }
}