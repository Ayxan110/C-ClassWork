using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsService.ProductsService;

namespace WindowsFormsService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_GetAll_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            dataGridView1.DataSource = client.GetAllProducts();
        }

        private void Btn_GetById_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            dataGridView1.DataSource = client.GetProductById(int.Parse(txbx_Id.Text));
        }
    }
}
