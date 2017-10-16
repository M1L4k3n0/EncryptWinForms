using ConsoleRedirection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace XOREncryptionDecryption
{
    public partial class Lab3Mod2 : Form
    {
        TextWriter _writer = null;

        public Lab3Mod2()
        {
            // That's our custom TextWriter class
            

            InitializeComponent();
            _writer = new TextBoxStreamWriter(ConsoleBox);
            // Redirect the out Console stream
            Console.SetOut(_writer);
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = EncryptionDecryption.Encode(SourceTextBox.Text, KeyTextBox.Text);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = EncryptionDecryption.Decode(SourceTextBox.Text, KeyTextBox.Text);
        }
    }
}