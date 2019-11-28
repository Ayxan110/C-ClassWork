using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = @"Data Source=CAPR3\PLUTOSQL; Initial Catalog=BooksDB; Integrated Security=true;";
            using (SqlConnection sqlConnection = new SqlConnection(sql))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Books", sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            books.Add(new Book
                            {
                                ID = (int)dataReader["ID"],
                                Name = dataReader["Name"].ToString(),
                                Author = dataReader["Author"].ToString(),
                                Pagesize = (int)dataReader["Pagesize"],
                            });
                        }
                    }
                }
            }
            dataGridView1.DataSource = books;
        }
    }
}
