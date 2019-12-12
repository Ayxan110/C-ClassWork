using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            string url = $"https://www.cbar.az/currencies/{dateTimePicker1.Value.ToString(dateTimePicker1.CustomFormat.ToString())}.xml";

            ValCurs valCurs = new ValCurs();

            HttpClient httpClient = new HttpClient();
            Stream fs = httpClient.GetAsync(url).GetAwaiter().GetResult().Content.ReadAsStreamAsync().GetAwaiter().GetResult();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));
            valCurs = (ValCurs)xmlSerializer.Deserialize(fs);

            dataGridView1.DataSource = valCurs.ValType.SelectMany(x => x.Valute).ToList();
        }
    }
}
