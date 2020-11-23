namespace POSmachine
{
    partial class nhanvien
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
            this.lbChangeText = new System.Windows.Forms.Label();
            this.pnBarCategories = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btngiamgia = new System.Windows.Forms.Button();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbChangeText
            // 
            this.lbChangeText.AutoSize = true;
            this.lbChangeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeText.Location = new System.Drawing.Point(383, 16);
            this.lbChangeText.Name = "lbChangeText";
            this.lbChangeText.Size = new System.Drawing.Size(39, 16);
            this.lbChangeText.TabIndex = 0;
            this.lbChangeText.Text = "POS";
            this.lbChangeText.Click += new System.EventHandler(this.lbChangeText_Click);
            // 
            // pnBarCategories
            // 
            this.pnBarCategories.AutoScroll = true;
            this.pnBarCategories.Location = new System.Drawing.Point(203, 48);
            this.pnBarCategories.Name = "pnBarCategories";
            this.pnBarCategories.Size = new System.Drawing.Size(78, 298);
            this.pnBarCategories.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày:";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Crimson;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthoat.Image = global::POSmachine.Properties.Resources.rsz_exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(535, 356);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(69, 32);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btngiamgia
            // 
            this.btngiamgia.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btngiamgia.FlatAppearance.BorderSize = 0;
            this.btngiamgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiamgia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btngiamgia.Image = global::POSmachine.Properties.Resources.rsz_price_tag;
            this.btngiamgia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiamgia.Location = new System.Drawing.Point(182, 11);
            this.btngiamgia.Name = "btngiamgia";
            this.btngiamgia.Size = new System.Drawing.Size(99, 23);
            this.btngiamgia.TabIndex = 10;
            this.btngiamgia.Text = "Thêm giảm giá";
            this.btngiamgia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngiamgia.UseVisualStyleBackColor = false;
            this.btngiamgia.Click += new System.EventHandler(this.btngiamgia_Click);
            // 
            // btninhoadon
            // 
            this.btninhoadon.BackColor = System.Drawing.Color.Green;
            this.btninhoadon.FlatAppearance.BorderSize = 0;
            this.btninhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninhoadon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btninhoadon.Image = global::POSmachine.Properties.Resources.rsz_printer;
            this.btninhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninhoadon.Location = new System.Drawing.Point(93, 11);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(83, 23);
            this.btninhoadon.TabIndex = 7;
            this.btninhoadon.Text = "In hóa đơn";
            this.btninhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninhoadon.UseVisualStyleBackColor = false;
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlammoi.FlatAppearance.BorderSize = 0;
            this.btnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoi.ForeColor = System.Drawing.Color.Black;
            this.btnlammoi.Image = global::POSmachine.Properties.Resources.rsz_renew;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlammoi.Location = new System.Drawing.Point(12, 11);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 6;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 393);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btngiamgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.pnBarCategories);
            this.Controls.Add(this.lbChangeText);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên ";
            this.Load += new System.EventHandler(this.nhanvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChangeText;
        private System.Windows.Forms.Panel pnBarCategories;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiamgia;
        private System.Windows.Forms.Button btnthoat;
    }
}