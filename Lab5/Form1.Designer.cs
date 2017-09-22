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
            this.label2.Location = new System.Drawing.Point(212, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BackPack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 13);
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
            this.textBox_output.Location = new System.Drawing.Point(16, 270);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(476, 20);
            this.textBox_output.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 188);
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
            this.label6.Location = new System.Drawing.Point(13, 293);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 379);
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
    }
}

