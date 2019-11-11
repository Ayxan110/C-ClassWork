using System;
using System.Windows.Forms;

namespace Register
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public string username;

        private void Admin_Load(object sender, EventArgs e)
        {
            if (username=="Admin")
            {
                foreach (User item in DataBase.GetAllUsers())
                {
                    if (item == null) continue; 
                    listBox1.Items.Add($"{item.email} {item.name} {item.surname}");
                }
            }
        }
    }
}
