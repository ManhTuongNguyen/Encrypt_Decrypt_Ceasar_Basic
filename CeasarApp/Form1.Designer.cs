
namespace CeasarApp
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
            this.rbtn_mahoa = new System.Windows.Forms.RadioButton();
            this.rbtn_giaima = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_path = new System.Windows.Forms.TextBox();
            this.btn_perform = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbx_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtn_mahoa
            // 
            this.rbtn_mahoa.AutoSize = true;
            this.rbtn_mahoa.Location = new System.Drawing.Point(35, 13);
            this.rbtn_mahoa.Name = "rbtn_mahoa";
            this.rbtn_mahoa.Size = new System.Drawing.Size(73, 20);
            this.rbtn_mahoa.TabIndex = 0;
            this.rbtn_mahoa.TabStop = true;
            this.rbtn_mahoa.Text = "Mã hóa";
            this.rbtn_mahoa.UseVisualStyleBackColor = true;
            this.rbtn_mahoa.CheckedChanged += new System.EventHandler(this.rbtn_mahoa_CheckedChanged);
            // 
            // rbtn_giaima
            // 
            this.rbtn_giaima.AutoSize = true;
            this.rbtn_giaima.Location = new System.Drawing.Point(197, 13);
            this.rbtn_giaima.Name = "rbtn_giaima";
            this.rbtn_giaima.Size = new System.Drawing.Size(74, 20);
            this.rbtn_giaima.TabIndex = 1;
            this.rbtn_giaima.TabStop = true;
            this.rbtn_giaima.Text = "Giải Mã";
            this.rbtn_giaima.UseVisualStyleBackColor = true;
            this.rbtn_giaima.CheckedChanged += new System.EventHandler(this.rbtn_giaima_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn tệp tin";
            // 
            // tbx_path
            // 
            this.tbx_path.Location = new System.Drawing.Point(35, 68);
            this.tbx_path.Multiline = true;
            this.tbx_path.Name = "tbx_path";
            this.tbx_path.Size = new System.Drawing.Size(452, 36);
            this.tbx_path.TabIndex = 3;
            // 
            // btn_perform
            // 
            this.btn_perform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perform.Location = new System.Drawing.Point(245, 158);
            this.btn_perform.Name = "btn_perform";
            this.btn_perform.Size = new System.Drawing.Size(130, 51);
            this.btn_perform.TabIndex = 4;
            this.btn_perform.Text = "Thực hiện";
            this.btn_perform.UseVisualStyleBackColor = true;
            this.btn_perform.Visible = false;
            this.btn_perform.Click += new System.EventHandler(this.btn_perform_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(493, 68);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 36);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbx_key
            // 
            this.tbx_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_key.Location = new System.Drawing.Point(109, 110);
            this.tbx_key.Multiline = true;
            this.tbx_key.Name = "tbx_key";
            this.tbx_key.Size = new System.Drawing.Size(64, 37);
            this.tbx_key.TabIndex = 6;
            this.tbx_key.TextChanged += new System.EventHandler(this.tbx_key_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_perform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_key);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_perform);
            this.Controls.Add(this.tbx_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_giaima);
            this.Controls.Add(this.rbtn_mahoa);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(617, 288);
            this.MinimumSize = new System.Drawing.Size(617, 288);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_mahoa;
        private System.Windows.Forms.RadioButton rbtn_giaima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_path;
        private System.Windows.Forms.Button btn_perform;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbx_key;
        private System.Windows.Forms.Label label2;
    }
}

