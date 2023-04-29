namespace UPanda
{
    partial class Start
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.Registe_btn = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(201, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPanda";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(201, 384);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(100, 29);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "登入";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Registe_btn
            // 
            this.Registe_btn.Location = new System.Drawing.Point(201, 436);
            this.Registe_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Registe_btn.Name = "Registe_btn";
            this.Registe_btn.Size = new System.Drawing.Size(100, 29);
            this.Registe_btn.TabIndex = 4;
            this.Registe_btn.Text = "註冊";
            this.Registe_btn.UseVisualStyleBackColor = true;
            this.Registe_btn.Click += new System.EventHandler(this.Registe_btn_Click);
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.username_tb.Location = new System.Drawing.Point(159, 249);
            this.username_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(237, 31);
            this.username_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password_tb.Location = new System.Drawing.Point(159, 298);
            this.password_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(237, 31);
            this.password_tb.TabIndex = 2;
            this.password_tb.WordWrap = false;
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.username_lb.Location = new System.Drawing.Point(75, 255);
            this.username_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(49, 20);
            this.username_lb.TabIndex = 3;
            this.username_lb.Text = "帳號";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password_lb.Location = new System.Drawing.Point(75, 304);
            this.password_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(49, 20);
            this.password_lb.TabIndex = 3;
            this.password_lb.Text = "密碼";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources.Register;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UPanda.Properties.Resources.PandaMe1;
            this.pictureBox2.Location = new System.Drawing.Point(112, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.username_lb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.Registe_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start";
            this.Text = "登入";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Registe_btn;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

