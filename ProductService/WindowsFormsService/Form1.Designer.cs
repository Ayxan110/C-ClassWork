namespace WindowsFormsService
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
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.btn_GetById = new System.Windows.Forms.Button();
            this.txbx_Id = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txbx_Name = new System.Windows.Forms.TextBox();
            this.txbx_Price = new System.Windows.Forms.TextBox();
            this.txbx_Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetAll.Location = new System.Drawing.Point(70, 29);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(166, 49);
            this.btn_GetAll.TabIndex = 0;
            this.btn_GetAll.Text = "Get all Products";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.Btn_GetAll_Click);
            // 
            // btn_GetById
            // 
            this.btn_GetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_GetById.Location = new System.Drawing.Point(378, 30);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(166, 49);
            this.btn_GetById.TabIndex = 1;
            this.btn_GetById.Text = "Get product by id";
            this.btn_GetById.UseVisualStyleBackColor = true;
            this.btn_GetById.Click += new System.EventHandler(this.Btn_GetById_Click);
            // 
            // txbx_Id
            // 
            this.txbx_Id.Location = new System.Drawing.Point(569, 45);
            this.txbx_Id.Name = "txbx_Id";
            this.txbx_Id.Size = new System.Drawing.Size(72, 20);
            this.txbx_Id.TabIndex = 2;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Insert.Location = new System.Drawing.Point(70, 112);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(166, 48);
            this.btn_Insert.TabIndex = 3;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // txbx_Name
            // 
            this.txbx_Name.Location = new System.Drawing.Point(70, 190);
            this.txbx_Name.Name = "txbx_Name";
            this.txbx_Name.Size = new System.Drawing.Size(166, 20);
            this.txbx_Name.TabIndex = 4;
            // 
            // txbx_Price
            // 
            this.txbx_Price.Location = new System.Drawing.Point(70, 240);
            this.txbx_Price.Name = "txbx_Price";
            this.txbx_Price.Size = new System.Drawing.Size(166, 20);
            this.txbx_Price.TabIndex = 4;
            // 
            // txbx_Count
            // 
            this.txbx_Count.Location = new System.Drawing.Point(70, 287);
            this.txbx_Count.Name = "txbx_Count";
            this.txbx_Count.Size = new System.Drawing.Size(166, 20);
            this.txbx_Count.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 195);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_Count);
            this.Controls.Add(this.txbx_Price);
            this.Controls.Add(this.txbx_Name);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txbx_Id);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_GetAll);
            this.Name = "Form1";
            this.Text = "Get product by id";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_GetById;
        private System.Windows.Forms.TextBox txbx_Id;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txbx_Name;
        private System.Windows.Forms.TextBox txbx_Price;
        private System.Windows.Forms.TextBox txbx_Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

