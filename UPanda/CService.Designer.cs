namespace UPanda
{
    partial class CService
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderNumber_cbo = new System.Windows.Forms.ComboBox();
            this.item_cbo = new System.Windows.Forms.ComboBox();
            this.commment_tb = new System.Windows.Forms.TextBox();
            this.send_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.return_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂單編號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "投訴項目";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "具體描述";
            // 
            // orderNumber_cbo
            // 
            this.orderNumber_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderNumber_cbo.FormattingEnabled = true;
            this.orderNumber_cbo.Location = new System.Drawing.Point(105, 139);
            this.orderNumber_cbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderNumber_cbo.Name = "orderNumber_cbo";
            this.orderNumber_cbo.Size = new System.Drawing.Size(151, 23);
            this.orderNumber_cbo.TabIndex = 4;
            // 
            // item_cbo
            // 
            this.item_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item_cbo.FormattingEnabled = true;
            this.item_cbo.Location = new System.Drawing.Point(105, 205);
            this.item_cbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item_cbo.Name = "item_cbo";
            this.item_cbo.Size = new System.Drawing.Size(205, 23);
            this.item_cbo.TabIndex = 5;
            // 
            // commment_tb
            // 
            this.commment_tb.Location = new System.Drawing.Point(105, 288);
            this.commment_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commment_tb.Multiline = true;
            this.commment_tb.Name = "commment_tb";
            this.commment_tb.Size = new System.Drawing.Size(336, 106);
            this.commment_tb.TabIndex = 6;
            // 
            // send_bt
            // 
            this.send_bt.Location = new System.Drawing.Point(105, 499);
            this.send_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send_bt.Name = "send_bt";
            this.send_bt.Size = new System.Drawing.Size(336, 38);
            this.send_bt.TabIndex = 8;
            this.send_bt.Text = "送出";
            this.send_bt.UseVisualStyleBackColor = true;
            this.send_bt.Click += new System.EventHandler(this.send_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(103, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "請提供您的訂單編號並簡述您所面臨到的問題，\r\n\r\nUPanda客服團隊很樂意為您服務";
            // 
            // return_bt
            // 
            this.return_bt.Location = new System.Drawing.Point(105, 558);
            this.return_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.return_bt.Name = "return_bt";
            this.return_bt.Size = new System.Drawing.Size(336, 34);
            this.return_bt.TabIndex = 10;
            this.return_bt.Text = "返回";
            this.return_bt.UseVisualStyleBackColor = true;
            this.return_bt.Click += new System.EventHandler(this.return_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 19F);
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "客服中心";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources.CService;
            this.pictureBox1.Location = new System.Drawing.Point(67, -115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 734);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UPanda.Properties.Resources.CService;
            this.pictureBox2.Location = new System.Drawing.Point(-12, -115);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(575, 734);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // CService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 608);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_bt);
            this.Controls.Add(this.send_bt);
            this.Controls.Add(this.commment_tb);
            this.Controls.Add(this.item_cbo);
            this.Controls.Add(this.orderNumber_cbo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CService";
            this.Text = "客服中心";
            this.Load += new System.EventHandler(this.CService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orderNumber_cbo;
        private System.Windows.Forms.ComboBox item_cbo;
        private System.Windows.Forms.TextBox commment_tb;
        private System.Windows.Forms.Button send_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button return_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}