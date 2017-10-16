namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_input = new System.Windows.Forms.TextBox();
            this.textBox_el = new System.Windows.Forms.TextBox();
            this.textBox_el1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PublicBox = new System.Windows.Forms.TextBox();
            this.PrivateBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MEssagebox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BackPack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "El-Gamal";
            // 
            // P
            // 
            this.P.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(35, 73);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(20, 13);
            this.P.TabIndex = 3;
            this.P.Text = "P=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Q=";
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(61, 70);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 20);
            this.textBox_p.TabIndex = 5;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(61, 100);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(100, 20);
            this.textBox_q.TabIndex = 6;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(12, 300);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(842, 20);
            this.textBox_output.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Output";
            // 
            // textBox_n
            // 
            this.textBox_n.Enabled = false;
            this.textBox_n.Location = new System.Drawing.Point(61, 156);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 20);
            this.textBox_n.TabIndex = 13;
            // 
            // textBox_d
            // 
            this.textBox_d.Enabled = false;
            this.textBox_d.Location = new System.Drawing.Point(61, 126);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 20);
            this.textBox_d.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "n=";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "d=";
            // 
            // textbox_input
            // 
            this.textbox_input.Location = new System.Drawing.Point(19, 34);
            this.textbox_input.Name = "textbox_input";
            this.textbox_input.Size = new System.Drawing.Size(142, 20);
            this.textbox_input.TabIndex = 14;
            this.textbox_input.Text = "иванов";
            // 
            // textBox_el
            // 
            this.textBox_el.Location = new System.Drawing.Point(711, 34);
            this.textBox_el.Name = "textBox_el";
            this.textBox_el.Size = new System.Drawing.Size(143, 20);
            this.textBox_el.TabIndex = 15;
            this.textBox_el.Text = "иванов";
            // 
            // textBox_el1
            // 
            this.textBox_el1.Location = new System.Drawing.Point(733, 70);
            this.textBox_el1.Name = "textBox_el1";
            this.textBox_el1.Size = new System.Drawing.Size(121, 20);
            this.textBox_el1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Encrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(708, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "k";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Генерация ключей";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PublicBox
            // 
            this.PublicBox.Location = new System.Drawing.Point(243, 34);
            this.PublicBox.Multiline = true;
            this.PublicBox.Name = "PublicBox";
            this.PublicBox.Size = new System.Drawing.Size(426, 52);
            this.PublicBox.TabIndex = 21;
            // 
            // PrivateBox
            // 
            this.PrivateBox.Location = new System.Drawing.Point(243, 96);
            this.PrivateBox.Multiline = true;
            this.PrivateBox.Name = "PrivateBox";
            this.PrivateBox.Size = new System.Drawing.Size(426, 50);
            this.PrivateBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "public key";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "private key";
            // 
            // MEssagebox
            // 
            this.MEssagebox.Location = new System.Drawing.Point(243, 183);
            this.MEssagebox.Multiline = true;
            this.MEssagebox.Name = "MEssagebox";
            this.MEssagebox.Size = new System.Drawing.Size(426, 50);
            this.MEssagebox.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(535, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Шифрование";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(395, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Дешифровка";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 379);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MEssagebox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PrivateBox);
            this.Controls.Add(this.PublicBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_el1);
            this.Controls.Add(this.textBox_el);
            this.Controls.Add(this.textbox_input);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_input;
        private System.Windows.Forms.TextBox textBox_el;
        private System.Windows.Forms.TextBox textBox_el1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PublicBox;
        private System.Windows.Forms.TextBox PrivateBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MEssagebox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

