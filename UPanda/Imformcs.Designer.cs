namespace UPanda
{
    partial class Imformcs
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
            this.storeItem_gv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status_lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cusomer_gv = new System.Windows.Forms.DataGridView();
            this.store_gv = new System.Windows.Forms.DataGridView();
            this.return_bt = new System.Windows.Forms.Button();
            this.cservice_bt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.orderNumber_lb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toatlMoney_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storeItem_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusomer_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 19F);
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品資訊";
            // 
            // storeItem_gv
            // 
            this.storeItem_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeItem_gv.Location = new System.Drawing.Point(438, 156);
            this.storeItem_gv.Name = "storeItem_gv";
            this.storeItem_gv.RowTemplate.Height = 27;
            this.storeItem_gv.Size = new System.Drawing.Size(341, 302);
            this.storeItem_gv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品品項";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "訂單狀態";
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Location = new System.Drawing.Point(691, 46);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(62, 15);
            this.status_lb.TabIndex = 6;
            this.status_lb.Text = "(已完成)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "訂購人資訊";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "店家資訊";
            // 
            // cusomer_gv
            // 
            this.cusomer_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusomer_gv.Location = new System.Drawing.Point(34, 156);
            this.cusomer_gv.Name = "cusomer_gv";
            this.cusomer_gv.RowTemplate.Height = 27;
            this.cusomer_gv.Size = new System.Drawing.Size(343, 108);
            this.cusomer_gv.TabIndex = 9;
            // 
            // store_gv
            // 
            this.store_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.store_gv.Location = new System.Drawing.Point(34, 334);
            this.store_gv.Name = "store_gv";
            this.store_gv.RowTemplate.Height = 27;
            this.store_gv.Size = new System.Drawing.Size(343, 124);
            this.store_gv.TabIndex = 10;
            // 
            // return_bt
            // 
            this.return_bt.BackColor = System.Drawing.Color.AliceBlue;
            this.return_bt.Location = new System.Drawing.Point(34, 562);
            this.return_bt.Name = "return_bt";
            this.return_bt.Size = new System.Drawing.Size(745, 34);
            this.return_bt.TabIndex = 11;
            this.return_bt.Text = "返回";
            this.return_bt.UseVisualStyleBackColor = false;
            this.return_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // cservice_bt
            // 
            this.cservice_bt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cservice_bt.Location = new System.Drawing.Point(34, 611);
            this.cservice_bt.Name = "cservice_bt";
            this.cservice_bt.Size = new System.Drawing.Size(745, 30);
            this.cservice_bt.TabIndex = 12;
            this.cservice_bt.Text = "客服中心";
            this.cservice_bt.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "訂單編號";
            // 
            // orderNumber_lb
            // 
            this.orderNumber_lb.AutoSize = true;
            this.orderNumber_lb.Location = new System.Drawing.Point(435, 46);
            this.orderNumber_lb.Name = "orderNumber_lb";
            this.orderNumber_lb.Size = new System.Drawing.Size(48, 15);
            this.orderNumber_lb.TabIndex = 14;
            this.orderNumber_lb.Text = "(U001)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "總計金額";
            // 
            // toatlMoney_lb
            // 
            this.toatlMoney_lb.AutoSize = true;
            this.toatlMoney_lb.Location = new System.Drawing.Point(702, 504);
            this.toatlMoney_lb.Name = "toatlMoney_lb";
            this.toatlMoney_lb.Size = new System.Drawing.Size(35, 15);
            this.toatlMoney_lb.TabIndex = 16;
            this.toatlMoney_lb.Text = "1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources._107_2;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 691);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Imformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 688);
            this.Controls.Add(this.toatlMoney_lb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.orderNumber_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cservice_bt);
            this.Controls.Add(this.return_bt);
            this.Controls.Add(this.store_gv);
            this.Controls.Add(this.cusomer_gv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.storeItem_gv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Imformcs";
            this.Text = "Imformcs";
            ((System.ComponentModel.ISupportInitialize)(this.storeItem_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusomer_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView storeItem_gv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView cusomer_gv;
        private System.Windows.Forms.DataGridView store_gv;
        private System.Windows.Forms.Button return_bt;
        private System.Windows.Forms.Button cservice_bt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label orderNumber_lb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label toatlMoney_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}