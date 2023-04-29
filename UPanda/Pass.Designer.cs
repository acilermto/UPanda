namespace UPanda
{
    partial class Pass
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
            this.CService_bt = new System.Windows.Forms.Button();
            this.return_bt = new System.Windows.Forms.Button();
            this.past_gv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.past_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CService_bt
            // 
            this.CService_bt.BackColor = System.Drawing.Color.White;
            this.CService_bt.FlatAppearance.BorderSize = 0;
            this.CService_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CService_bt.Location = new System.Drawing.Point(-3, 572);
            this.CService_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CService_bt.Name = "CService_bt";
            this.CService_bt.Size = new System.Drawing.Size(799, 44);
            this.CService_bt.TabIndex = 2;
            this.CService_bt.Text = "客服中心";
            this.CService_bt.UseVisualStyleBackColor = false;
            this.CService_bt.Click += new System.EventHandler(this.CService_bt_Click);
            // 
            // return_bt
            // 
            this.return_bt.BackColor = System.Drawing.Color.White;
            this.return_bt.FlatAppearance.BorderSize = 0;
            this.return_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_bt.Location = new System.Drawing.Point(-3, 512);
            this.return_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.return_bt.Name = "return_bt";
            this.return_bt.Size = new System.Drawing.Size(799, 44);
            this.return_bt.TabIndex = 3;
            this.return_bt.Text = "返回主頁";
            this.return_bt.UseVisualStyleBackColor = false;
            this.return_bt.Click += new System.EventHandler(this.return_bt_Click);
            // 
            // past_gv
            // 
            this.past_gv.AllowUserToAddRows = false;
            this.past_gv.AllowUserToDeleteRows = false;
            this.past_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.past_gv.Location = new System.Drawing.Point(61, 120);
            this.past_gv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.past_gv.Name = "past_gv";
            this.past_gv.ReadOnly = true;
            this.past_gv.RowTemplate.Height = 27;
            this.past_gv.Size = new System.Drawing.Size(677, 372);
            this.past_gv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(304, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "歷史訂單";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPanda.Properties.Resources.圖片11;
            this.pictureBox1.Location = new System.Drawing.Point(-49, -51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 628);
            this.Controls.Add(this.CService_bt);
            this.Controls.Add(this.return_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.past_gv);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pass";
            this.Text = "歷史訂單";
            this.Load += new System.EventHandler(this.Pass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.past_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CService_bt;
        private System.Windows.Forms.Button return_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView past_gv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}