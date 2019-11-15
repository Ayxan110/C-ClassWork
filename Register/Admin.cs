using System;
using System.Drawing;
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
            ListBox listBox = new ListBox();
            listBox.Location = new Point(150,80);
            listBox.Size = new Size(400, 350);
            Button button = new Button();
            button.Location = new Point(660, 85);
            button.Size = new Size(100, 45);
            Controls.AddRange(new Control { button, listBox} );
        }
    }
}
