
namespace ATBMTT_B1_Ceasar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_needEncrypt = new System.Windows.Forms.TextBox();
            this.tbx_keyEncrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.tbx_needDecrypt = new System.Windows.Forms.TextBox();
            this.tbx_keyDecrypt = new System.Windows.Forms.TextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.tbx_Decrypted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuỗi cần mã hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi cần giải mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "key giải mã:";
            // 
            // tbx_needEncrypt
            // 
            this.tbx_needEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbx_needEncrypt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbx_needEncrypt.Location = new System.Drawing.Point(22, 41);
            this.tbx_needEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_needEncrypt.Multiline = true;
            this.tbx_needEncrypt.Name = "tbx_needEncrypt";
            this.tbx_needEncrypt.Size = new System.Drawing.Size(281, 75);
            this.tbx_needEncrypt.TabIndex = 1;
            this.tbx_needEncrypt.Text = "Nhập chuỗi...";
            this.tbx_needEncrypt.TextChanged += new System.EventHandler(this.tbx_needEncrypt_TextChanged);
            // 
            // tbx_keyEncrypt
            // 
            this.tbx_keyEncrypt.Location = new System.Drawing.Point(132, 125);
            this.tbx_keyEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_keyEncrypt.Multiline = true;
            this.tbx_keyEncrypt.Name = "tbx_keyEncrypt";
            this.tbx_keyEncrypt.Size = new System.Drawing.Size(80, 22);
            this.tbx_keyEncrypt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "key mã hóa:";
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(118, 151);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(106, 23);
            this.btn_Encrypt.TabIndex = 3;
            this.btn_Encrypt.Text = "Mã Hóa";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Visible = false;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // tbx_needDecrypt
            // 
            this.tbx_needDecrypt.Location = new System.Drawing.Point(22, 198);
            this.tbx_needDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_needDecrypt.Multiline = true;
            this.tbx_needDecrypt.Name = "tbx_needDecrypt";
            this.tbx_needDecrypt.Size = new System.Drawing.Size(281, 75);
            this.tbx_needDecrypt.TabIndex = 4;
            // 
            // tbx_keyDecrypt
            // 
            this.tbx_keyDecrypt.Location = new System.Drawing.Point(132, 286);
            this.tbx_keyDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_keyDecrypt.Multiline = true;
            this.tbx_keyDecrypt.Name = "tbx_keyDecrypt";
            this.tbx_keyDecrypt.Size = new System.Drawing.Size(80, 22);
            this.tbx_keyDecrypt.TabIndex = 5;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(118, 313);
            this.btn_decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(106, 23);
            this.btn_decrypt.TabIndex = 6;
            this.btn_decrypt.Text = "Giải Mã";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // tbx_Decrypted
            // 
            this.tbx_Decrypted.Location = new System.Drawing.Point(22, 363);
            this.tbx_Decrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_Decrypted.Multiline = true;
            this.tbx_Decrypted.Name = "tbx_Decrypted";
            this.tbx_Decrypted.Size = new System.Drawing.Size(281, 75);
            this.tbx_Decrypted.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chuỗi sau khi giải mã";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Encrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_Decrypted);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.tbx_keyDecrypt);
            this.Controls.Add(this.tbx_needDecrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_keyEncrypt);
            this.Controls.Add(this.tbx_needEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 505);
            this.MinimumSize = new System.Drawing.Size(345, 505);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_needEncrypt;
        private System.Windows.Forms.TextBox tbx_keyEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox tbx_needDecrypt;
        private System.Windows.Forms.TextBox tbx_keyDecrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox tbx_Decrypted;
        private System.Windows.Forms.Label label5;
    }
}

