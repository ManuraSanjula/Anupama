namespace Anupama
{
    public partial class Form1 : Form
    {
        String userName;
        public Form1(String userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new update().Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new login().Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            new Regisation().Show();
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            new update().Show();
        }
    }
}