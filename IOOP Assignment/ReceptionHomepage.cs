namespace IOOP_Assignment
{
    public partial class ReceptionHomepage : Form
    {
        public ReceptionHomepage()
        {
            InitializeComponent();
        }

        public ReceptionHomepage(string Name)
        {
            InitializeComponent();
            label_Username.Text = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}