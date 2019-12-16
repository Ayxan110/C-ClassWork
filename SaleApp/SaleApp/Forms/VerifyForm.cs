using SaleApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.Forms
{
    public partial class VerifyForm : Form
    {
        private int icode;
        private int iid;
        public VerifyForm()
        {
            InitializeComponent();

        }
        public VerifyForm(int ecode,int eid)
        {
            InitializeComponent();
            icode = ecode;
            iid = eid;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txbx_Code.Text == icode.ToString())
            {
                MyDbContext db = new MyDbContext();
                var person = db.Products.Where(y => y.ID == iid).FirstOrDefault();
                person.Status = Models.DbTables.Status.Accepted;
                db.SaveChanges();
            }
        }
    }
}
