namespace POSmachine
{
    partial class admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnthoat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabbthongke = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabpdanhsachmonorder = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenddot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pndanhsachmon = new System.Windows.Forms.Panel();
            this.dgvdanhsachmon = new System.Windows.Forms.DataGridView();
            this.tabpxephangmon = new System.Windows.Forms.TabPage();
            this.cbbrankitems = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnGroupRankItem = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabbnhanvien = new System.Windows.Forms.TabPage();
            this.btnthemnv = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnGroupAccNv = new System.Windows.Forms.Panel();
            this.tabbdanhsachmon = new System.Windows.Forms.TabPage();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnListItemsGroup = new System.Windows.Forms.Panel();
            this.btnclickme = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabbthongke.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabpdanhsachmonorder.SuspendLayout();
            this.pndanhsachmon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachmon)).BeginInit();
            this.tabpxephangmon.SuspendLayout();
            this.pnGroupRankItem.SuspendLayout();
            this.tabbnhanvien.SuspendLayout();
            this.tabbdanhsachmon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(593, 346);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabbthongke);
            this.tabControl1.Controls.Add(this.tabbnhanvien);
            this.tabControl1.Controls.Add(this.tabbdanhsachmon);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 342);
            this.tabControl1.TabIndex = 2;
            // 
            // tabbthongke
            // 
            this.tabbthongke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabbthongke.Controls.Add(this.tabControl2);
            this.tabbthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbthongke.Location = new System.Drawing.Point(4, 29);
            this.tabbthongke.Name = "tabbthongke";
            this.tabbthongke.Padding = new System.Windows.Forms.Padding(3);
            this.tabbthongke.Size = new System.Drawing.Size(661, 309);
            this.tabbthongke.TabIndex = 0;
            this.tabbthongke.Text = "Thống kê";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabpdanhsachmonorder);
            this.tabControl2.Controls.Add(this.tabpxephangmon);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(659, 314);
            this.tabControl2.TabIndex = 0;
            // 
            // tabpdanhsachmonorder
            // 
            this.tabpdanhsachmonorder.BackColor = System.Drawing.SystemColors.Control;
            this.tabpdanhsachmonorder.Controls.Add(this.label3);
            this.tabpdanhsachmonorder.Controls.Add(this.label2);
            this.tabpdanhsachmonorder.Controls.Add(this.btnenddot);
            this.tabpdanhsachmonorder.Controls.Add(this.label1);
            this.tabpdanhsachmonorder.Controls.Add(this.pndanhsachmon);
            this.tabpdanhsachmonorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpdanhsachmonorder.Location = new System.Drawing.Point(4, 22);
            this.tabpdanhsachmonorder.Name = "tabpdanhsachmonorder";
            this.tabpdanhsachmonorder.Padding = new System.Windows.Forms.Padding(3);
            this.tabpdanhsachmonorder.Size = new System.Drawing.Size(651, 288);
            this.tabpdanhsachmonorder.TabIndex = 0;
            this.tabpdanhsachmonorder.Text = "Danh sách món";
            this.tabpdanhsachmonorder.Click += new System.EventHandler(this.tabpdanhsachmon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tỉ lệ tăng trưởng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng danh thu:";
            // 
            // btnenddot
            // 
            this.btnenddot.Location = new System.Drawing.Point(493, 254);
            this.btnenddot.Name = "btnenddot";
            this.btnenddot.Size = new System.Drawing.Size(155, 23);
            this.btnenddot.TabIndex = 3;
            this.btnenddot.Text = "Kết thúc đợt làm việc";
            this.btnenddot.UseVisualStyleBackColor = true;
            this.btnenddot.Click += new System.EventHandler(this.btnenddot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đợt thứ :";
            // 
            // pndanhsachmon
            // 
            this.pndanhsachmon.AutoScroll = true;
            this.pndanhsachmon.BackColor = System.Drawing.SystemColors.Control;
            this.pndanhsachmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pndanhsachmon.Controls.Add(this.dgvdanhsachmon);
            this.pndanhsachmon.Location = new System.Drawing.Point(0, 0);
            this.pndanhsachmon.Name = "pndanhsachmon";
            this.pndanhsachmon.Size = new System.Drawing.Size(484, 282);
            this.pndanhsachmon.TabIndex = 0;
            // 
            // dgvdanhsachmon
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdanhsachmon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdanhsachmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdanhsachmon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdanhsachmon.Location = new System.Drawing.Point(-1, -1);
            this.dgvdanhsachmon.Name = "dgvdanhsachmon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdanhsachmon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdanhsachmon.Size = new System.Drawing.Size(484, 285);
            this.dgvdanhsachmon.TabIndex = 0;
            // 
            // tabpxephangmon
            // 
            this.tabpxephangmon.Controls.Add(this.cbbrankitems);
            this.tabpxephangmon.Controls.Add(this.label4);
            this.tabpxephangmon.Controls.Add(this.pnGroupRankItem);
            this.tabpxephangmon.Location = new System.Drawing.Point(4, 22);
            this.tabpxephangmon.Name = "tabpxephangmon";
            this.tabpxephangmon.Padding = new System.Windows.Forms.Padding(3);
            this.tabpxephangmon.Size = new System.Drawing.Size(651, 288);
            this.tabpxephangmon.TabIndex = 1;
            this.tabpxephangmon.Text = "Xếp hạng món";
            this.tabpxephangmon.UseVisualStyleBackColor = true;
            // 
            // cbbrankitems
            // 
            this.cbbrankitems.FormattingEnabled = true;
            this.cbbrankitems.Items.AddRange(new object[] {
            "Doanh thu",
            "Số lượng bán"});
            this.cbbrankitems.Location = new System.Drawing.Point(527, 13);
            this.cbbrankitems.Name = "cbbrankitems";
            this.cbbrankitems.Size = new System.Drawing.Size(118, 21);
            this.cbbrankitems.TabIndex = 2;
            this.cbbrankitems.SelectedIndexChanged += new System.EventHandler(this.cbbrankitems_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sắp xếp theo :";
            // 
            // pnGroupRankItem
            // 
            this.pnGroupRankItem.AutoScroll = true;
            this.pnGroupRankItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnGroupRankItem.Controls.Add(this.label5);
            this.pnGroupRankItem.Location = new System.Drawing.Point(6, 6);
            this.pnGroupRankItem.Name = "pnGroupRankItem";
            this.pnGroupRankItem.Size = new System.Drawing.Size(402, 271);
            this.pnGroupRankItem.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thứ hạng";
            // 
            // tabbnhanvien
            // 
            this.tabbnhanvien.BackColor = System.Drawing.SystemColors.Control;
            this.tabbnhanvien.Controls.Add(this.btnthemnv);
            this.tabbnhanvien.Controls.Add(this.label8);
            this.tabbnhanvien.Controls.Add(this.label7);
            this.tabbnhanvien.Controls.Add(this.label6);
            this.tabbnhanvien.Controls.Add(this.pnGroupAccNv);
            this.tabbnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbnhanvien.Location = new System.Drawing.Point(4, 29);
            this.tabbnhanvien.Name = "tabbnhanvien";
            this.tabbnhanvien.Padding = new System.Windows.Forms.Padding(3);
            this.tabbnhanvien.Size = new System.Drawing.Size(661, 309);
            this.tabbnhanvien.TabIndex = 1;
            this.tabbnhanvien.Text = "Nhân viên";
            // 
            // btnthemnv
            // 
            this.btnthemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemnv.Location = new System.Drawing.Point(537, 9);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(118, 23);
            this.btnthemnv.TabIndex = 0;
            this.btnthemnv.Text = "Thêm nhân viên";
            this.btnthemnv.UseVisualStyleBackColor = true;
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên nhân viên";
            // 
            // pnGroupAccNv
            // 
            this.pnGroupAccNv.AutoScroll = true;
            this.pnGroupAccNv.Location = new System.Drawing.Point(4, 35);
            this.pnGroupAccNv.Name = "pnGroupAccNv";
            this.pnGroupAccNv.Size = new System.Drawing.Size(651, 271);
            this.pnGroupAccNv.TabIndex = 0;
            // 
            // tabbdanhsachmon
            // 
            this.tabbdanhsachmon.BackColor = System.Drawing.Color.Bisque;
            this.tabbdanhsachmon.Controls.Add(this.btnCreateItem);
            this.tabbdanhsachmon.Controls.Add(this.label11);
            this.tabbdanhsachmon.Controls.Add(this.label10);
            this.tabbdanhsachmon.Controls.Add(this.label9);
            this.tabbdanhsachmon.Controls.Add(this.pnListItemsGroup);
            this.tabbdanhsachmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbdanhsachmon.Location = new System.Drawing.Point(4, 29);
            this.tabbdanhsachmon.Name = "tabbdanhsachmon";
            this.tabbdanhsachmon.Padding = new System.Windows.Forms.Padding(3);
            this.tabbdanhsachmon.Size = new System.Drawing.Size(661, 309);
            this.tabbdanhsachmon.TabIndex = 2;
            this.tabbdanhsachmon.Text = "Danh sách món";
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Location = new System.Drawing.Point(527, 10);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(121, 23);
            this.btnCreateItem.TabIndex = 4;
            this.btnCreateItem.Text = "Thêm món";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giá cả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên món";
            // 
            // pnListItemsGroup
            // 
            this.pnListItemsGroup.AutoScroll = true;
            this.pnListItemsGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnListItemsGroup.Location = new System.Drawing.Point(3, 41);
            this.pnListItemsGroup.Name = "pnListItemsGroup";
            this.pnListItemsGroup.Size = new System.Drawing.Size(653, 262);
            this.pnListItemsGroup.TabIndex = 0;
            // 
            // btnclickme
            // 
            this.btnclickme.BackColor = System.Drawing.Color.Gainsboro;
            this.btnclickme.Location = new System.Drawing.Point(512, 346);
            this.btnclickme.Name = "btnclickme";
            this.btnclickme.Size = new System.Drawing.Size(75, 23);
            this.btnclickme.TabIndex = 3;
            this.btnclickme.Text = "click me";
            this.btnclickme.UseVisualStyleBackColor = false;
            this.btnclickme.Click += new System.EventHandler(this.btnclickme_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 385);
            this.Controls.Add(this.btnclickme);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnthoat);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabbthongke.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabpdanhsachmonorder.ResumeLayout(false);
            this.tabpdanhsachmonorder.PerformLayout();
            this.pndanhsachmon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachmon)).EndInit();
            this.tabpxephangmon.ResumeLayout(false);
            this.tabpxephangmon.PerformLayout();
            this.pnGroupRankItem.ResumeLayout(false);
            this.pnGroupRankItem.PerformLayout();
            this.tabbnhanvien.ResumeLayout(false);
            this.tabbnhanvien.PerformLayout();
            this.tabbdanhsachmon.ResumeLayout(false);
            this.tabbdanhsachmon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabbthongke;
        private System.Windows.Forms.TabPage tabbnhanvien;
        private System.Windows.Forms.TabPage tabbdanhsachmon;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabpdanhsachmonorder;
        private System.Windows.Forms.Panel pndanhsachmon;
        private System.Windows.Forms.TabPage tabpxephangmon;
        private System.Windows.Forms.Button btnclickme;
        private System.Windows.Forms.DataGridView dgvdanhsachmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenddot;
        private System.Windows.Forms.ComboBox cbbrankitems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnGroupRankItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnGroupAccNv;
        private System.Windows.Forms.Button btnthemnv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnListItemsGroup;
        private System.Windows.Forms.Button btnCreateItem;
    }
}