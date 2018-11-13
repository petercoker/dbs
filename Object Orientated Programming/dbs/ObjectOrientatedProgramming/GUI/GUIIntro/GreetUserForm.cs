using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.GUIIntro
{
    public partial class GreetUserForm : Form
    {
        public GreetUserForm()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, System.EventArgs e)
        {

            string firstName, lastName;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;

            lblGreeting.Text = $"Hello {firstName} {lastName}";

            MessageBox.Show($"Welcome {firstName} {lastName}");
        }

        private void GreetUserForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
