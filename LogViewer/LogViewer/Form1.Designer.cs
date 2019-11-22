namespace LogViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_write = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_write
            // 
            this.txbx_write.Location = new System.Drawing.Point(73, 117);
            this.txbx_write.Name = "txbx_write";
            this.txbx_write.Size = new System.Drawing.Size(242, 20);
            this.txbx_write.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_send.Location = new System.Drawing.Point(127, 206);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(123, 31);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(441, 117);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(264, 173);
            this.listBox.TabIndex = 2;
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_read.Location = new System.Drawing.Point(509, 341);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(123, 31);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "READ";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txbx_write);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_write;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn_read;
    }
}

