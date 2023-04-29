namespace UPanda
{
    partial class Center
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
            this.username_lb = new System.Windows.Forms.Label();
            this.logout_lb = new System.Windows.Forms.LinkLabel();
            this.store_bt = new System.Windows.Forms.Button();
            this.cservice_bt = new System.Windows.Forms.Button();
            this.past_bt = new System.Windows.Forms.Button();
            this.gender_lb = new System.Windows.Forms.Label();
            this.vieworder_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F);
            this.label1.Location = new System.Drawing.Point(541, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello!";
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("新細明體", 9F);
            this.username_lb.Location = new System.Drawing.Point(592, 9);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(92, 15);
            this.username_lb.TabIndex = 4;
            this.username_lb.Text = "(使用者名稱)";
            // 
            // logout_lb
            // 
            this.logout_lb.AutoSize = true;
            this.logout_lb.Location = new System.Drawing.Point(747, 9);
            this.logout_lb.Name = "logout_lb";
            this.logout_lb.Size = new System.Drawing.Size(37, 15);
            this.logout_lb.TabIndex = 5;
            this.logout_lb.TabStop = true;
            this.logout_lb.Text = "登出";
            this.logout_lb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_lb_LinkClicked);
            // 
            // store_bt
            // 
            this.store_bt.BackColor = System.Drawing.Color.White;
            this.store_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.store_bt.FlatAppearance.BorderSize = 0;
            this.store_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.store_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.store_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.store_bt.Font = new System.Drawing.Font("微軟正黑體", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.store_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.store_bt.Location = new System.Drawing.Point(505, 233);
            this.store_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.store_bt.Name = "store_bt";
            this.store_bt.Size = new System.Drawing.Size(227, 98);
            this.store_bt.TabIndex = 9;
            this.store_bt.Text = "開始購物";
            this.store_bt.UseVisualStyleBackColor = false;
            this.store_bt.Click += new System.EventHandler(this.store_bt_Click);
            // 
            // cservice_bt
            // 
            this.cservice_bt.BackColor = System.Drawing.Color.White;
            this.cservice_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cservice_bt.FlatAppearance.BorderSize = 0;
            this.cservice_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cservice_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cservice_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cservice_bt.Font = new System.Drawing.Font("微軟正黑體", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.cservice_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cservice_bt.Location = new System.Drawing.Point(505, 515);
            this.cservice_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cservice_bt.Name = "cservice_bt";
            this.cservice_bt.Size = new System.Drawing.Size(227, 102);
            this.cservice_bt.TabIndex = 8;
            this.cservice_bt.Text = "客服中心";
            this.cservice_bt.UseVisualStyleBackColor = false;
            this.cservice_bt.Click += new System.EventHandler(this.cservice_bt_Click);
            // 
            // past_bt
            // 
            this.past_bt.BackColor = System.Drawing.Color.White;
            this.past_bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.past_bt.FlatAppearance.BorderSize = 0;
            this.past_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.past_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.past_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.past_bt.Font = new System.Drawing.Font("微軟正黑體", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.past_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.past_bt.Location = new System.Drawing.Point(505, 380);
            this.past_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.past_bt.Name = "past_bt";
            this.past_bt.Size = new System.Drawing.Size(227, 102);
            this.past_bt.TabIndex = 7;
            this.past_bt.Text = "歷史紀錄";
            this.past_bt.UseVisualStyleBackColor = false;
            this.past_bt.Click += new System.EventHandler(this.past_bt_Click);
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("新細明體", 9F);
            this.gender_lb.Location = new System.Drawing.Point(695, 9);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(37, 15);
            this.gender_lb.TabIndex = 0;
            this.gender_lb.Text = "性別";
            // 
            // vieworder_btn
            // 
            this.vieworder_btn.BackColor = System.Drawing.Color.White;
            this.vieworder_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.vieworder_btn.FlatAppearance.BorderSize = 0;
            this.vieworder_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.vieworder_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.vieworder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vieworder_btn.Font = new System.Drawing.Font("微軟正黑體", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.vieworder_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vieworder_btn.Location = new System.Drawing.Point(505, 233);
            this.vieworder_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vieworder_btn.Name = "vieworder_btn";
            this.vieworder_btn.Size = new System.Drawing.Size(227, 98);
            this.vieworder_btn.TabIndex = 11;
            this.vieworder_btn.Text = "餐點進度";
            this.vieworder_btn.UseVisualStyleBackColor = false;
            this.vieworder_btn.Visible = false;
            this.vieworder_btn.Click += new System.EventHandler(this.vieworder_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UPanda.Properties.Resources.PandaMe1;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 59F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Image = global::UPanda.Properties.Resources.圖片1;
            this.label3.Location = new System.Drawing.Point(100, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 124);
            this.label3.TabIndex = 6;
            this.label3.Text = "UPanda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources.圖片1;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1472, 1106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 628);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.vieworder_btn);
            this.Controls.Add(this.cservice_bt);
            this.Controls.Add(this.store_bt);
            this.Controls.Add(this.past_bt);
            this.Controls.Add(this.logout_lb);
            this.Controls.Add(this.username_lb);
            this.Controls.Add(this.gender_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Center";
            this.Text = "首頁";
            this.Load += new System.EventHandler(this.Center_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.LinkLabel logout_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cservice_bt;
        private System.Windows.Forms.Button past_bt;
        private System.Windows.Forms.Button store_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gender_lb;
        private System.Windows.Forms.Button vieworder_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}