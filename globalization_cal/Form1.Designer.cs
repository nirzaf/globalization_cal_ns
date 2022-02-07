namespace globalization_cal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yesr_textBox1 = new System.Windows.Forms.TextBox();
            this.month_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.day_textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.month_namelabel4 = new System.Windows.Forms.Label();
            this.day_week_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cal_day_in_weeklabel8 = new System.Windows.Forms.Label();
            this.cal_day_in_monthlabel7 = new System.Windows.Forms.Label();
            this.cal_month_namelabel6 = new System.Windows.Forms.Label();
            this.cal_year_numlabel5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year:";
            // 
            // yesr_textBox1
            // 
            this.yesr_textBox1.Location = new System.Drawing.Point(355, 22);
            this.yesr_textBox1.Name = "yesr_textBox1";
            this.yesr_textBox1.Size = new System.Drawing.Size(215, 20);
            this.yesr_textBox1.TabIndex = 2;
            // 
            // month_textBox2
            // 
            this.month_textBox2.Location = new System.Drawing.Point(355, 49);
            this.month_textBox2.Name = "month_textBox2";
            this.month_textBox2.Size = new System.Drawing.Size(215, 20);
            this.month_textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month:";
            // 
            // day_textBox3
            // 
            this.day_textBox3.Location = new System.Drawing.Point(355, 75);
            this.day_textBox3.Name = "day_textBox3";
            this.day_textBox3.Size = new System.Drawing.Size(215, 20);
            this.day_textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day:";
            // 
            // month_namelabel4
            // 
            this.month_namelabel4.Location = new System.Drawing.Point(577, 55);
            this.month_namelabel4.Name = "month_namelabel4";
            this.month_namelabel4.Size = new System.Drawing.Size(100, 23);
            this.month_namelabel4.TabIndex = 7;
            this.month_namelabel4.Text = "-";
            // 
            // day_week_textBox1
            // 
            this.day_week_textBox1.Location = new System.Drawing.Point(355, 101);
            this.day_week_textBox1.Name = "day_week_textBox1";
            this.day_week_textBox1.Size = new System.Drawing.Size(215, 20);
            this.day_week_textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Day in Week:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 325);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::globalization_cal.Properties.Resources.calander;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cal_day_in_weeklabel8);
            this.panel2.Controls.Add(this.cal_day_in_monthlabel7);
            this.panel2.Controls.Add(this.cal_month_namelabel6);
            this.panel2.Controls.Add(this.cal_year_numlabel5);
            this.panel2.Location = new System.Drawing.Point(11, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 189);
            this.panel2.TabIndex = 0;
            // 
            // cal_day_in_weeklabel8
            // 
            this.cal_day_in_weeklabel8.BackColor = System.Drawing.Color.Transparent;
            this.cal_day_in_weeklabel8.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_day_in_weeklabel8.ForeColor = System.Drawing.Color.Black;
            this.cal_day_in_weeklabel8.Location = new System.Drawing.Point(13, 133);
            this.cal_day_in_weeklabel8.Name = "cal_day_in_weeklabel8";
            this.cal_day_in_weeklabel8.Size = new System.Drawing.Size(150, 43);
            this.cal_day_in_weeklabel8.TabIndex = 14;
            this.cal_day_in_weeklabel8.Text = "Sunday";
            this.cal_day_in_weeklabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cal_day_in_monthlabel7
            // 
            this.cal_day_in_monthlabel7.BackColor = System.Drawing.Color.Transparent;
            this.cal_day_in_monthlabel7.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_day_in_monthlabel7.ForeColor = System.Drawing.Color.Black;
            this.cal_day_in_monthlabel7.Location = new System.Drawing.Point(34, 85);
            this.cal_day_in_monthlabel7.Name = "cal_day_in_monthlabel7";
            this.cal_day_in_monthlabel7.Size = new System.Drawing.Size(105, 43);
            this.cal_day_in_monthlabel7.TabIndex = 13;
            this.cal_day_in_monthlabel7.Text = "27";
            this.cal_day_in_monthlabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cal_month_namelabel6
            // 
            this.cal_month_namelabel6.BackColor = System.Drawing.Color.Transparent;
            this.cal_month_namelabel6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_month_namelabel6.ForeColor = System.Drawing.Color.White;
            this.cal_month_namelabel6.Location = new System.Drawing.Point(65, 44);
            this.cal_month_namelabel6.Name = "cal_month_namelabel6";
            this.cal_month_namelabel6.Size = new System.Drawing.Size(98, 27);
            this.cal_month_namelabel6.TabIndex = 12;
            this.cal_month_namelabel6.Text = "June";
            this.cal_month_namelabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cal_year_numlabel5
            // 
            this.cal_year_numlabel5.AutoSize = true;
            this.cal_year_numlabel5.BackColor = System.Drawing.Color.Transparent;
            this.cal_year_numlabel5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_year_numlabel5.ForeColor = System.Drawing.Color.White;
            this.cal_year_numlabel5.Location = new System.Drawing.Point(9, 45);
            this.cal_year_numlabel5.Name = "cal_year_numlabel5";
            this.cal_year_numlabel5.Size = new System.Drawing.Size(50, 22);
            this.cal_year_numlabel5.TabIndex = 11;
            this.cal_year_numlabel5.Text = "2019";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Get Info Hijri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(425, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Get Info  Jap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Get Info  Per";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(425, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Get Info  Kor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 325);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.day_week_textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.month_namelabel4);
            this.Controls.Add(this.day_textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month_textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yesr_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yesr_textBox1;
        private System.Windows.Forms.TextBox month_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox day_textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label month_namelabel4;
        private System.Windows.Forms.TextBox day_week_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cal_day_in_weeklabel8;
        private System.Windows.Forms.Label cal_day_in_monthlabel7;
        private System.Windows.Forms.Label cal_month_namelabel6;
        private System.Windows.Forms.Label cal_year_numlabel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

