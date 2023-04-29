namespace UPanda
{
    partial class Product_Check
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.total_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realname_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 23.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(478, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "您選擇的品項";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(683, 510);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "總計:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.total_lb.Location = new System.Drawing.Point(809, 510);
            this.total_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(74, 40);
            this.total_lb.TabIndex = 3;
            this.total_lb.Text = "100";
            this.total_lb.Click += new System.EventHandler(this.total_lb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 23.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(174, 488);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "外送資訊";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(684, 610);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "請稍候，外送員即將為您取餐";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(686, 806);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "回首頁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(686, 695);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 68);
            this.button2.TabIndex = 8;
            this.button2.Text = "查看餐點進度";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(891, 510);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "元";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(176, 577);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "姓名";
            // 
            // realname_tb
            // 
            this.realname_tb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.realname_tb.Location = new System.Drawing.Point(183, 650);
            this.realname_tb.Margin = new System.Windows.Forms.Padding(4);
            this.realname_tb.Name = "realname_tb";
            this.realname_tb.ReadOnly = true;
            this.realname_tb.Size = new System.Drawing.Size(311, 34);
            this.realname_tb.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(185, 705);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "外送地址";
            // 
            // address_tb
            // 
            this.address_tb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.address_tb.Location = new System.Drawing.Point(183, 763);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4);
            this.address_tb.Multiline = true;
            this.address_tb.Name = "address_tb";
            this.address_tb.ReadOnly = true;
            this.address_tb.Size = new System.Drawing.Size(311, 130);
            this.address_tb.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources.圖片15;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 979);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Product_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 896);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.realname_tb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_Check";
            this.Text = "訂單建立";
            this.Load += new System.EventHandler(this.Product_Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox realname_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

