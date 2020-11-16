namespace POSmachine
{
    partial class giamgia
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn20percent = new System.Windows.Forms.Button();
            this.btn40percent = new System.Windows.Forms.Button();
            this.btn50percent = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btndongy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn muốn chọn loại giảm giá nào?";
            // 
            // btn20percent
            // 
            this.btn20percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20percent.ForeColor = System.Drawing.Color.Blue;
            this.btn20percent.Location = new System.Drawing.Point(51, 65);
            this.btn20percent.Name = "btn20percent";
            this.btn20percent.Size = new System.Drawing.Size(65, 46);
            this.btn20percent.TabIndex = 2;
            this.btn20percent.Text = "20%";
            this.btn20percent.UseVisualStyleBackColor = true;
            this.btn20percent.Click += new System.EventHandler(this.btn20percent_Click);
            // 
            // btn40percent
            // 
            this.btn40percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn40percent.ForeColor = System.Drawing.Color.Blue;
            this.btn40percent.Location = new System.Drawing.Point(143, 65);
            this.btn40percent.Name = "btn40percent";
            this.btn40percent.Size = new System.Drawing.Size(65, 46);
            this.btn40percent.TabIndex = 3;
            this.btn40percent.Text = "40%";
            this.btn40percent.UseVisualStyleBackColor = true;
            this.btn40percent.Click += new System.EventHandler(this.btn40percent_Click);
            // 
            // btn50percent
            // 
            this.btn50percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50percent.ForeColor = System.Drawing.Color.Blue;
            this.btn50percent.Location = new System.Drawing.Point(234, 65);
            this.btn50percent.Name = "btn50percent";
            this.btn50percent.Size = new System.Drawing.Size(65, 46);
            this.btn50percent.TabIndex = 4;
            this.btn50percent.Text = "50%";
            this.btn50percent.UseVisualStyleBackColor = true;
            this.btn50percent.Click += new System.EventHandler(this.btn50percent_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Red;
            this.btnhuy.ForeColor = System.Drawing.Color.White;
            this.btnhuy.Location = new System.Drawing.Point(249, 134);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(98, 23);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Không giảm giá";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btndongy
            // 
            this.btndongy.BackColor = System.Drawing.Color.DarkGreen;
            this.btndongy.ForeColor = System.Drawing.Color.White;
            this.btndongy.Location = new System.Drawing.Point(185, 134);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(58, 23);
            this.btndongy.TabIndex = 6;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = false;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // giamgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 169);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btn50percent);
            this.Controls.Add(this.btn40percent);
            this.Controls.Add(this.btn20percent);
            this.Controls.Add(this.label2);
            this.Name = "giamgia";
            this.Text = "giamgia";
            this.Load += new System.EventHandler(this.giamgia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn20percent;
        private System.Windows.Forms.Button btn40percent;
        private System.Windows.Forms.Button btn50percent;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndongy;
    }
}