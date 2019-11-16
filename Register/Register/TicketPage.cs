using System;
using System.Drawing;
using System.Windows.Forms;

namespace Register
{
    public partial class TicketPage : Form
    {
        public TicketPage()
        {
            InitializeComponent();
        }
        public string username;

        private void Newbtn_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.ShowDialog();
        }
    }
}
