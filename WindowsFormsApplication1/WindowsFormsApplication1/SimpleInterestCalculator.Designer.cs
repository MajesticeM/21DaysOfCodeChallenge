namespace WindowsFormsApplication1
{
    partial class SimpleInterestCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Years = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_InterestRate = new System.Windows.Forms.TextBox();
            this.textBox3_Answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1_PrincipalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2_an = new System.Windows.Forms.TextBox();
            this.textBox4_pa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5_noy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6_ir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Number of Years:";
            // 
            // Years
            // 
            this.Years.Location = new System.Drawing.Point(314, 32);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(163, 29);
            this.Years.TabIndex = 2;
            this.Years.TextChanged += new System.EventHandler(this.Years_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Interest rate:";
            // 
            // textbox_InterestRate
            // 
            this.textbox_InterestRate.Location = new System.Drawing.Point(314, 84);
            this.textbox_InterestRate.Name = "textbox_InterestRate";
            this.textbox_InterestRate.Size = new System.Drawing.Size(163, 29);
            this.textbox_InterestRate.TabIndex = 4;
            this.textbox_InterestRate.TextChanged += new System.EventHandler(this.InterestRate_TextChanged);
            // 
            // textBox3_Answer
            // 
            this.textBox3_Answer.Location = new System.Drawing.Point(314, 207);
            this.textBox3_Answer.Name = "textBox3_Answer";
            this.textBox3_Answer.Size = new System.Drawing.Size(163, 29);
            this.textBox3_Answer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1_PrincipalAmount
            // 
            this.textBox1_PrincipalAmount.Location = new System.Drawing.Point(314, 137);
            this.textBox1_PrincipalAmount.Name = "textBox1_PrincipalAmount";
            this.textBox1_PrincipalAmount.Size = new System.Drawing.Size(163, 29);
            this.textBox1_PrincipalAmount.TabIndex = 8;
            this.textBox1_PrincipalAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Principal Amount (R):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox3_Answer);
            this.groupBox1.Controls.Add(this.textBox1_PrincipalAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Years);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textbox_InterestRate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 270);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple Interest Calculator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2_an);
            this.groupBox2.Controls.Add(this.textBox4_pa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox5_noy);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox6_ir);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(501, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 270);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compound Interest Calculator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter Number of Years:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2_an
            // 
            this.textBox2_an.Location = new System.Drawing.Point(255, 207);
            this.textBox2_an.Name = "textBox2_an";
            this.textBox2_an.Size = new System.Drawing.Size(167, 29);
            this.textBox2_an.TabIndex = 5;
            // 
            // textBox4_pa
            // 
            this.textBox4_pa.Location = new System.Drawing.Point(272, 124);
            this.textBox4_pa.Name = "textBox4_pa";
            this.textBox4_pa.Size = new System.Drawing.Size(163, 29);
            this.textBox4_pa.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enter Principal Amount:";
            // 
            // textBox5_noy
            // 
            this.textBox5_noy.Location = new System.Drawing.Point(272, 32);
            this.textBox5_noy.Name = "textBox5_noy";
            this.textBox5_noy.Size = new System.Drawing.Size(163, 29);
            this.textBox5_noy.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Enter Interest rate:";
            // 
            // textBox6_ir
            // 
            this.textBox6_ir.Location = new System.Drawing.Point(272, 74);
            this.textBox6_ir.Name = "textBox6_ir";
            this.textBox6_ir.Size = new System.Drawing.Size(163, 29);
            this.textBox6_ir.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "(Interest must be in decimals)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "(Interest must be in decimals)";
            // 
            // SimpleInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(989, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "SimpleInterestCalculator";
            this.Text = "Simple and Compound Interest Calculator";
            this.Load += new System.EventHandler(this.SimpleInterestCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Years;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_InterestRate;
        private System.Windows.Forms.TextBox textBox3_Answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1_PrincipalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2_an;
        private System.Windows.Forms.TextBox textBox4_pa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5_noy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6_ir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}