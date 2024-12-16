namespace ProjectCuoiky
{
    partial class FormDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDangnhap = new System.Windows.Forms.TextBox();
            this.textBoxMatkhau = new System.Windows.Forms.TextBox();
            this.buttonDangnhap = new System.Windows.Forms.Button();
            this.buttonDangky = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonCheat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Lithos", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN VÀ KHO HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // textBoxDangnhap
            // 
            this.textBoxDangnhap.Location = new System.Drawing.Point(277, 110);
            this.textBoxDangnhap.Name = "textBoxDangnhap";
            this.textBoxDangnhap.Size = new System.Drawing.Size(320, 20);
            this.textBoxDangnhap.TabIndex = 4;
            // 
            // textBoxMatkhau
            // 
            this.textBoxMatkhau.Location = new System.Drawing.Point(277, 160);
            this.textBoxMatkhau.Name = "textBoxMatkhau";
            this.textBoxMatkhau.PasswordChar = '*';
            this.textBoxMatkhau.Size = new System.Drawing.Size(320, 20);
            this.textBoxMatkhau.TabIndex = 5;
            // 
            // buttonDangnhap
            // 
            this.buttonDangnhap.Location = new System.Drawing.Point(277, 200);
            this.buttonDangnhap.Name = "buttonDangnhap";
            this.buttonDangnhap.Size = new System.Drawing.Size(75, 23);
            this.buttonDangnhap.TabIndex = 6;
            this.buttonDangnhap.Text = "Đăng nhập";
            this.buttonDangnhap.UseVisualStyleBackColor = true;
            this.buttonDangnhap.Click += new System.EventHandler(this.buttonDangnhap_Click);
            // 
            // buttonDangky
            // 
            this.buttonDangky.Location = new System.Drawing.Point(358, 200);
            this.buttonDangky.Name = "buttonDangky";
            this.buttonDangky.Size = new System.Drawing.Size(75, 23);
            this.buttonDangky.TabIndex = 7;
            this.buttonDangky.Text = "Đăng ký";
            this.buttonDangky.UseVisualStyleBackColor = true;
            this.buttonDangky.Click += new System.EventHandler(this.buttonDangky_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(439, 200);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 8;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(522, 200);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 9;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonCheat
            // 
            this.buttonCheat.Location = new System.Drawing.Point(713, 415);
            this.buttonCheat.Name = "buttonCheat";
            this.buttonCheat.Size = new System.Drawing.Size(75, 23);
            this.buttonCheat.TabIndex = 10;
            this.buttonCheat.Text = "cheat";
            this.buttonCheat.UseVisualStyleBackColor = true;
            this.buttonCheat.Click += new System.EventHandler(this.buttonCheat_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 287);
            this.Controls.Add(this.buttonCheat);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonDangky);
            this.Controls.Add(this.buttonDangnhap);
            this.Controls.Add(this.textBoxMatkhau);
            this.Controls.Add(this.textBoxDangnhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.Text = "Form Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDangnhap;
        private System.Windows.Forms.TextBox textBoxMatkhau;
        private System.Windows.Forms.Button buttonDangnhap;
        private System.Windows.Forms.Button buttonDangky;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonCheat;
    }
}

