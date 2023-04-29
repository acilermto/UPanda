namespace UPanda
{
    partial class Take_Product
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConfirmOrder_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 19.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(208, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "外送員取餐中";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(975, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "已取餐";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(1138, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "已送達";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(788, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "您的品項";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(795, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(507, 385);
            this.dataGridView1.TabIndex = 6;
            // 
            // ConfirmOrder_btn
            // 
            this.ConfirmOrder_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.ConfirmOrder_btn.Location = new System.Drawing.Point(795, 583);
            this.ConfirmOrder_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmOrder_btn.Name = "ConfirmOrder_btn";
            this.ConfirmOrder_btn.Size = new System.Drawing.Size(507, 50);
            this.ConfirmOrder_btn.TabIndex = 7;
            this.ConfirmOrder_btn.Text = "完成訂單";
            this.ConfirmOrder_btn.UseVisualStyleBackColor = true;
            this.ConfirmOrder_btn.Visible = false;
            this.ConfirmOrder_btn.Click += new System.EventHandler(this.ConfirmOrder_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.back_btn.Location = new System.Drawing.Point(795, 662);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(507, 45);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "回首頁";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(20, 156);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(734, 551);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Url = new System.Uri("https://www.google.com.tw/maps/dir/900屏東縣屏東市瑞民路2號/900屏東縣屏東市廣東路7-5號/", System.UriKind.Absolute);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources._107_2;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1397, 819);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Take_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 750);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ConfirmOrder_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Take_Product";
            this.Text = "餐點進度";
            this.Load += new System.EventHandler(this.Take_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ConfirmOrder_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

