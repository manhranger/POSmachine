namespace POSmachine
{
    partial class editItem
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
            this.txtbEditCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbEditCategory = new System.Windows.Forms.ComboBox();
            this.lbThongbao = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btndongy = new System.Windows.Forms.Button();
            this.txtbEditMoTa = new System.Windows.Forms.TextBox();
            this.txtbEditItemname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbEditCost
            // 
            this.txtbEditCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEditCost.Location = new System.Drawing.Point(136, 103);
            this.txtbEditCost.Name = "txtbEditCost";
            this.txtbEditCost.Size = new System.Drawing.Size(199, 22);
            this.txtbEditCost.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Sửa giá bán :";
            // 
            // cbbEditCategory
            // 
            this.cbbEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEditCategory.FormattingEnabled = true;
            this.cbbEditCategory.Location = new System.Drawing.Point(136, 141);
            this.cbbEditCategory.Name = "cbbEditCategory";
            this.cbbEditCategory.Size = new System.Drawing.Size(199, 21);
            this.cbbEditCategory.TabIndex = 36;
            // 
            // lbThongbao
            // 
            this.lbThongbao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongbao.ForeColor = System.Drawing.Color.Red;
            this.lbThongbao.Location = new System.Drawing.Point(27, 262);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(300, 23);
            this.lbThongbao.TabIndex = 35;
            this.lbThongbao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(260, 289);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(179, 289);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(75, 23);
            this.btndongy.TabIndex = 33;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // txtbEditMoTa
            // 
            this.txtbEditMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEditMoTa.Location = new System.Drawing.Point(136, 180);
            this.txtbEditMoTa.Multiline = true;
            this.txtbEditMoTa.Name = "txtbEditMoTa";
            this.txtbEditMoTa.Size = new System.Drawing.Size(199, 72);
            this.txtbEditMoTa.TabIndex = 32;
            // 
            // txtbEditItemname
            // 
            this.txtbEditItemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEditItemname.Location = new System.Drawing.Point(136, 63);
            this.txtbEditItemname.Name = "txtbEditItemname";
            this.txtbEditItemname.Size = new System.Drawing.Size(199, 22);
            this.txtbEditItemname.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Chỉnh sửa món";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sửa mô tả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Chọn chủ đề :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sửa tên món :";
            // 
            // editItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 327);
            this.Controls.Add(this.txtbEditCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbEditCategory);
            this.Controls.Add(this.lbThongbao);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.txtbEditMoTa);
            this.Controls.Add(this.txtbEditItemname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editItem";
            this.Load += new System.EventHandler(this.editItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbEditCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbEditCategory;
        private System.Windows.Forms.Label lbThongbao;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.TextBox txtbEditMoTa;
        private System.Windows.Forms.TextBox txtbEditItemname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}