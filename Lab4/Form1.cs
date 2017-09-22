using ExercisesProject.Exercises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[][] keySquare = MainLogic.GetStaticKeySquare();
            string keyWord = "кот";
            string clearText = textBox1.Text;
            string cipherText = MainLogic.Cipher(clearText, keySquare, keyWord);
            textBox2.Text = cipherText;

        }
    }
}
