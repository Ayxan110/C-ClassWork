using SaleApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace SaleApp.Forms
{
    public partial class AddAdvertForm : Form
    {
        public AddAdvertForm()
        {
            InitializeComponent();
        }
        private string filename;

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileDialog.FileName);

            }
            filename = fileDialog.FileName;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            MyDbContext dbContext = new MyDbContext();
            Product product = new Product();
            Photo photo = new Photo();

            try
            {
                product.Name = txbx_Name.Text;
                product.Surname = txbx_Surname.Text;
                product.ProductName = txbx_ProductName.Text;
                product.Email = txbx_Email.Text;
                product.PhoneNumber = txbx_Number.Text;
                product.Price = int.Parse(txbx_Price.Text);
                product.Status = Models.DbTables.Status.Waiting;
                Random random = new Random();
                int r = random.Next(1000, 9999);

                product.VerificationCode = r;
                dbContext.Products.Add(product);
                dbContext.SaveChanges();

                photo.Name = filename;
                photo.ProductId = product.ID;
                dbContext.Photos.Add(photo);
                dbContext.SaveChanges();

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("test.testov1110@gmail.com");
                mail.To.Add(txbx_Email.Text);
                mail.Subject = "Verification code";
                mail.Body = product.VerificationCode.ToString();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("test.testov1110@gmail.com", "ayxan110");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");

                VerifyForm verifyForm = new VerifyForm(product.VerificationCode, product.ID);
                verifyForm.ShowDialog();

            }
            catch
            {
                ValidationContext validationContext = new ValidationContext(product);
                List<ValidationResult> results = new List<ValidationResult>();
                Validator.TryValidateObject(product, validationContext, results, true);
                foreach (var item in results)
                {
                    lbl_error.Text += item.ErrorMessage + "\n";
                }
            }
        }
    }
}
