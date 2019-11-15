using System;
using System.Windows.Forms;

namespace Register
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string login = email.Text;
            string pass = password.Text;
            if (DataBase.CheckUser(login, pass))
            {
                TicketPage ticketpage = new TicketPage();
                ticketpage.ShowDialog();
            }
        }
    }
}
