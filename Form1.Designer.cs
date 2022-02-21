﻿namespace DecryptAndEncrypt
{
    partial class EncryptAndDecrypt
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cesarCode = new System.Windows.Forms.RadioButton();
            this.md5Code = new System.Windows.Forms.RadioButton();
            this.cesarCodeLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.leftTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.encryptButton = new System.Windows.Forms.Button();
            this.rightTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.md5CodeLabel = new System.Windows.Forms.Label();
            this.md5TextHash = new System.Windows.Forms.TextBox();
            this.cesarCodeShift = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cesarCodeShift)).BeginInit();
            this.SuspendLayout();
            // 
            // cesarCode
            // 
            this.cesarCode.Location = new System.Drawing.Point(12, 12);
            this.cesarCode.Name = "cesarCode";
            this.cesarCode.Size = new System.Drawing.Size(194, 23);
            this.cesarCode.TabIndex = 0;
            this.cesarCode.TabStop = true;
            this.cesarCode.Text = "Szyfr Cezara";
            this.cesarCode.UseVisualStyleBackColor = true;
            this.cesarCode.CheckedChanged += new System.EventHandler(this.cesarCode_CheckedChanged);
            // 
            // md5Code
            // 
            this.md5Code.Location = new System.Drawing.Point(741, 12);
            this.md5Code.Name = "md5Code";
            this.md5Code.Size = new System.Drawing.Size(122, 23);
            this.md5Code.TabIndex = 1;
            this.md5Code.TabStop = true;
            this.md5Code.Text = "Szyfr MD5";
            this.md5Code.UseVisualStyleBackColor = true;
            this.md5Code.CheckedChanged += new System.EventHandler(this.md5Code_CheckedChanged);
            // 
            // cesarCodeLabel
            // 
            this.cesarCodeLabel.AutoSize = true;
            this.cesarCodeLabel.Location = new System.Drawing.Point(8, 38);
            this.cesarCodeLabel.Name = "cesarCodeLabel";
            this.cesarCodeLabel.Size = new System.Drawing.Size(160, 19);
            this.cesarCodeLabel.TabIndex = 3;
            this.cesarCodeLabel.Text = "Podaj przesunięcie";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(370, 12);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(132, 39);
            this.openFileButton.TabIndex = 4;
            this.openFileButton.Text = "Otwórz plik";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // leftTextBox
            // 
            this.leftTextBox.Location = new System.Drawing.Point(12, 110);
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.Size = new System.Drawing.Size(317, 439);
            this.leftTextBox.TabIndex = 5;
            this.leftTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(370, 63);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(132, 35);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Szyfruj";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // rightTextBox
            // 
            this.rightTextBox.Location = new System.Drawing.Point(546, 110);
            this.rightTextBox.Name = "rightTextBox";
            this.rightTextBox.Size = new System.Drawing.Size(317, 439);
            this.rightTextBox.TabIndex = 7;
            this.rightTextBox.Text = "";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(370, 110);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(132, 35);
            this.decryptButton.TabIndex = 8;
            this.decryptButton.Text = "Deszyfruj";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(370, 517);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(132, 32);
            this.clearAllButton.TabIndex = 9;
            this.clearAllButton.Text = "Czyść";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // md5CodeLabel
            // 
            this.md5CodeLabel.AutoSize = true;
            this.md5CodeLabel.Location = new System.Drawing.Point(737, 38);
            this.md5CodeLabel.Name = "md5CodeLabel";
            this.md5CodeLabel.Size = new System.Drawing.Size(98, 19);
            this.md5CodeLabel.TabIndex = 10;
            this.md5CodeLabel.Text = "Podaj hash";
            // 
            // md5TextHash
            // 
            this.md5TextHash.Location = new System.Drawing.Point(731, 63);
            this.md5TextHash.Name = "md5TextHash";
            this.md5TextHash.Size = new System.Drawing.Size(141, 27);
            this.md5TextHash.TabIndex = 11;
            // 
            // cesarCodeShift
            // 
            this.cesarCodeShift.Location = new System.Drawing.Point(12, 64);
            this.cesarCodeShift.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.cesarCodeShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cesarCodeShift.Name = "cesarCodeShift";
            this.cesarCodeShift.Size = new System.Drawing.Size(120, 27);
            this.cesarCodeShift.TabIndex = 12;
            this.cesarCodeShift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EncryptAndDecrypt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.cesarCodeShift);
            this.Controls.Add(this.md5TextHash);
            this.Controls.Add(this.md5CodeLabel);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.rightTextBox);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.leftTextBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.cesarCodeLabel);
            this.Controls.Add(this.md5Code);
            this.Controls.Add(this.cesarCode);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "EncryptAndDecrypt";
            this.Text = "DecryptAndEncrypt";
            ((System.ComponentModel.ISupportInitialize)(this.cesarCodeShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cesarCode;
        private System.Windows.Forms.RadioButton md5Code;
        private System.Windows.Forms.Label cesarCodeLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.RichTextBox leftTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.RichTextBox rightTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label md5CodeLabel;
        private System.Windows.Forms.TextBox md5TextHash;
        private System.Windows.Forms.NumericUpDown cesarCodeShift;
    }
}
