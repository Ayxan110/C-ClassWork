using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogViewer
{
    public partial class Form1 : Form
    {
        Database db;
        public Form1()
        {
            InitializeComponent();
            db = new FileReader();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            db.AddText(txbx_write.Text);
            txbx_write.Clear();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach(var item in db.Read())
            {
                listBox.Items.Add(item);
            }
        }
    }
}
