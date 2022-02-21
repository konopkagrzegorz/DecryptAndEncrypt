﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecryptAndEncrypt
{
    public partial class EncryptAndDecrypt : Form
    {

        private Boolean cesarCodeEnabled = false;
        private Boolean md5CodeEnabled = false;

        public EncryptAndDecrypt()
        {
            InitializeComponent();
            leftTextBox.Enabled = false;
            rightTextBox.Enabled = false;
            encryptButton.Enabled = false;
            decryptButton.Enabled = false;
        }

        private void cesarCode_CheckedChanged(object sender, EventArgs e)
        {
            if (cesarCode.Checked)
            {
                cesarCodeEnabled = true;
                md5Code.Checked = false;
                md5TextHash.Enabled = false;
            } else
            {
                cesarCodeEnabled = false;
                md5TextHash.Enabled = true;
            }

        }

        private void md5Code_CheckedChanged(object sender, EventArgs e)
        {
            if (md5Code.Checked)
            {
                md5CodeEnabled = true;
                cesarCode.Checked = false;
                cesarCodeShift.Enabled = false;
            } else
            {
                md5CodeEnabled = false;
                cesarCodeShift.Enabled = true;
            }

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Text|*.txt";
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                encryptButton.Enabled = true;
                decryptButton.Enabled = true;
                string path = openFileDialog1.FileName;
                string text = System.IO.File.ReadAllText(path);
                leftTextBox.AppendText(text);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cesarCodeShift.Value) > 0 && cesarCodeEnabled == true)
            {
                rightTextBox.AppendText(CesarCipher.encrypt(leftTextBox.Text, Convert.ToInt32(cesarCodeShift.Value)));
            }

            if (md5TextHash.TextLength > 0 && md5CodeEnabled == true)
            {
                rightTextBox.AppendText(MD5Cipher.encrypt(leftTextBox.Text, md5TextHash.Text));
            }
        }


        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cesarCodeShift.Value) > 0 && cesarCodeEnabled == true)
            {
                rightTextBox.AppendText(CesarCipher.decrypt(leftTextBox.Text, Convert.ToInt32(cesarCodeShift.Value)));
            }

            if (md5TextHash.TextLength > 0 && md5CodeEnabled == true)
            {
                rightTextBox.AppendText(MD5Cipher.decrypt(leftTextBox.Text,md5TextHash.Text));
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            leftTextBox.Clear();
            rightTextBox.Clear();
            cesarCodeShift.Value = cesarCodeShift.Minimum;
            md5TextHash.Clear();
            rightTextBox.Clear();
            encryptButton.Enabled = false;
            decryptButton.Enabled = false;
        }
    }
}