namespace IOOP_Assignment
{
    public partial class frmSchedule : Form
    {
        Student student;
        public frmSchedule(Student student)
        {
            InitializeComponent();
            this.student = student;
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {

        }

        private void frmSchedule_Load_1(object sender, EventArgs e)
        {

        }

        private void grdSch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}