using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XOREncryptionDecryption
{
    public partial class Lab3Mod2 : Form
    {
        public Lab3Mod2()
        {
            InitializeComponent();
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