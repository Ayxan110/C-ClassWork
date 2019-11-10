namespace WindowsFormsApp1
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
            this.calculate = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.calconsole = new System.Windows.Forms.TextBox();
            this.div = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.calculate.Location = new System.Drawing.Point(341, 333);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(52, 96);
            this.calculate.TabIndex = 34;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.percent.Location = new System.Drawing.Point(341, 282);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(52, 45);
            this.percent.TabIndex = 33;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Image = global::WindowsFormsApp1.Properties.Resources.delete_M0H_icon;
            this.delete.Location = new System.Drawing.Point(341, 231);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(52, 45);
            this.delete.TabIndex = 32;
            this.delete.UseVisualStyleBackColor = true;
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dot.Location = new System.Drawing.Point(176, 384);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(52, 45);
            this.dot.TabIndex = 31;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.c.Location = new System.Drawing.Point(32, 384);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(52, 45);
            this.c.TabIndex = 30;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // calconsole
            // 
            this.calconsole.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.calconsole.Cursor = System.Windows.Forms.Cursors.No;
            this.calconsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.calconsole.Location = new System.Drawing.Point(32, 118);
            this.calconsole.Name = "calconsole";
            this.calconsole.ReadOnly = true;
            this.calconsole.Size = new System.Drawing.Size(361, 53);
            this.calconsole.TabIndex = 29;
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.div.Location = new System.Drawing.Point(278, 384);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(45, 45);
            this.div.TabIndex = 27;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mul.Location = new System.Drawing.Point(278, 333);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(45, 45);
            this.mul.TabIndex = 26;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sub.Location = new System.Drawing.Point(278, 282);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(45, 45);
            this.sub.TabIndex = 25;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.add.Location = new System.Drawing.Point(278, 231);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 45);
            this.add.TabIndex = 28;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button7.Location = new System.Drawing.Point(32, 333);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 45);
            this.button7.TabIndex = 24;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button9.Location = new System.Drawing.Point(176, 333);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 45);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button0.Location = new System.Drawing.Point(101, 384);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(52, 45);
            this.button0.TabIndex = 23;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6.Location = new System.Drawing.Point(176, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 45);
            this.button6.TabIndex = 22;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button8.Location = new System.Drawing.Point(101, 333);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 45);
            this.button8.TabIndex = 19;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.Location = new System.Drawing.Point(101, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 45);
            this.button5.TabIndex = 20;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.Location = new System.Drawing.Point(32, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 45);
            this.button4.TabIndex = 18;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(176, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(101, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(32, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(129, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "CALCULATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.c);
            this.Controls.Add(this.calconsole);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.TextBox calconsole;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

