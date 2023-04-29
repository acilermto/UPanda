namespace UPanda
{
    partial class Product_Choose
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Oder_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Total_lb = new System.Windows.Forms.Label();
            this.fType_cbo = new System.Windows.Forms.ComboBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Currency_lb = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.realname_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resName_lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(101, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品類別篩選";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 410);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(939, 124);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(356, 170);
            this.dataGridView2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 19.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(464, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "商品品項";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1050, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "您選擇的品項";
            // 
            // Oder_btn
            // 
            this.Oder_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Oder_btn.Location = new System.Drawing.Point(1233, 497);
            this.Oder_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Oder_btn.Name = "Oder_btn";
            this.Oder_btn.Size = new System.Drawing.Size(195, 54);
            this.Oder_btn.TabIndex = 11;
            this.Oder_btn.Text = "確認送出";
            this.Oder_btn.UseVisualStyleBackColor = true;
            this.Oder_btn.Click += new System.EventHandler(this.Oder_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1227, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "總計:";
            // 
            // Total_lb
            // 
            this.Total_lb.AutoSize = true;
            this.Total_lb.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Total_lb.Location = new System.Drawing.Point(1303, 396);
            this.Total_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total_lb.Name = "Total_lb";
            this.Total_lb.Size = new System.Drawing.Size(56, 31);
            this.Total_lb.TabIndex = 14;
            this.Total_lb.Text = "100";
            this.Total_lb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Total_lb.Click += new System.EventHandler(this.Total_lb_Click);
            // 
            // fType_cbo
            // 
            this.fType_cbo.FormattingEnabled = true;
            this.fType_cbo.Location = new System.Drawing.Point(92, 297);
            this.fType_cbo.Margin = new System.Windows.Forms.Padding(4);
            this.fType_cbo.Name = "fType_cbo";
            this.fType_cbo.Size = new System.Drawing.Size(156, 23);
            this.fType_cbo.TabIndex = 15;
            this.fType_cbo.SelectedIndexChanged += new System.EventHandler(this.fType_cbo_SelectedIndexChanged);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.Back_btn.Location = new System.Drawing.Point(-41, 497);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(283, 48);
            this.Back_btn.TabIndex = 16;
            this.Back_btn.Text = "回上層";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Currency_lb
            // 
            this.Currency_lb.AutoSize = true;
            this.Currency_lb.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Currency_lb.Location = new System.Drawing.Point(1367, 396);
            this.Currency_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Currency_lb.Name = "Currency_lb";
            this.Currency_lb.Size = new System.Drawing.Size(38, 31);
            this.Currency_lb.TabIndex = 14;
            this.Currency_lb.Text = "元";
            this.Currency_lb.Click += new System.EventHandler(this.Currency_lb_Click);
            // 
            // address_tb
            // 
            this.address_tb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.address_tb.Location = new System.Drawing.Point(939, 433);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4);
            this.address_tb.Multiline = true;
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(252, 124);
            this.address_tb.TabIndex = 19;
            // 
            // realname_tb
            // 
            this.realname_tb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.realname_tb.Location = new System.Drawing.Point(939, 350);
            this.realname_tb.Margin = new System.Windows.Forms.Padding(4);
            this.realname_tb.Name = "realname_tb";
            this.realname_tb.Size = new System.Drawing.Size(252, 34);
            this.realname_tb.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(934, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "外送地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(934, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "姓名";
            // 
            // resName_lb
            // 
            this.resName_lb.AutoSize = true;
            this.resName_lb.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resName_lb.Location = new System.Drawing.Point(85, 168);
            this.resName_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resName_lb.Name = "resName_lb";
            this.resName_lb.Size = new System.Drawing.Size(77, 38);
            this.resName_lb.TabIndex = 0;
            this.resName_lb.Text = "商品";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(87, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "店家名稱:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources.圖片;
            this.pictureBox1.Location = new System.Drawing.Point(-53, -153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1629, 725);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UPanda.Properties.Resources._107_2;
            this.pictureBox2.Location = new System.Drawing.Point(-53, -48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1026, 730);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Product_Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 570);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.realname_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.fType_cbo);
            this.Controls.Add(this.Currency_lb);
            this.Controls.Add(this.Total_lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Oder_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resName_lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_Choose";
            this.Text = "餐點選擇";
            this.Load += new System.EventHandler(this.Product_Choose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Oder_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Total_lb;
        private System.Windows.Forms.ComboBox fType_cbo;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label Currency_lb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox realname_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resName_lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

