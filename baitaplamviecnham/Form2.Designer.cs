namespace baitaplamviecnham
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnnap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtchon = new System.Windows.Forms.DomainUpDown();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttkd = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Song Nhẫn";
            // 
            // btnnap
            // 
            this.btnnap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnap.Location = new System.Drawing.Point(552, 81);
            this.btnnap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnap.Name = "btnnap";
            this.btnnap.Size = new System.Drawing.Size(128, 72);
            this.btnnap.TabIndex = 6;
            this.btnnap.Text = "Nạp";
            this.btnnap.UseVisualStyleBackColor = true;
            this.btnnap.Click += new System.EventHandler(this.btnnap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn đồ uống:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tài khoản dư:";
            // 
            // txtchon
            // 
            this.txtchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchon.Location = new System.Drawing.Point(254, 188);
            this.txtchon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtchon.Name = "txtchon";
            this.txtchon.ReadOnly = true;
            this.txtchon.Size = new System.Drawing.Size(288, 26);
            this.txtchon.TabIndex = 10;
            this.txtchon.Text = "Sting";
            // 
            // txtgia
            // 
            this.txtgia.BackColor = System.Drawing.SystemColors.Info;
            this.txtgia.Location = new System.Drawing.Point(256, 248);
            this.txtgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgia.Name = "txtgia";
            this.txtgia.ReadOnly = true;
            this.txtgia.Size = new System.Drawing.Size(286, 26);
            this.txtgia.TabIndex = 11;
            this.txtgia.Text = "10.000";
            // 
            // txttkd
            // 
            this.txttkd.BackColor = System.Drawing.SystemColors.Info;
            this.txttkd.Location = new System.Drawing.Point(254, 304);
            this.txttkd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttkd.Name = "txttkd";
            this.txttkd.ReadOnly = true;
            this.txttkd.Size = new System.Drawing.Size(286, 26);
            this.txttkd.TabIndex = 12;
            this.txttkd.Text = "10.000";
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(567, 226);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(189, 48);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.Location = new System.Drawing.Point(504, 353);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(252, 62);
            this.btnthanhtoan.TabIndex = 14;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttkd);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtchon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnnap);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown txtchon;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttkd;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthanhtoan;
    }
}