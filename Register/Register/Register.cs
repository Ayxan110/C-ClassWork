using System;
using System.Windows.Forms;

namespace Register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            if (name.Text != null && surname.Text != null && email.Text != null && password.Text != null)
            {
                User user = new User();
                user.name = name.Text;
                user.surname = surname.Text;
                user.email = email.Text;
                user.password = password.Text;
                DataBase.AddUsers(user);
                Login login = new Login();
                login.ShowDialog();
            }
        }
    }
}
