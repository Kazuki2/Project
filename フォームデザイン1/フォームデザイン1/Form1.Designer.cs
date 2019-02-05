namespace フォームデザイン1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBookRegist = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnUserRegist = new System.Windows.Forms.Button();
            this.BtnRentReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookRegist
            // 
            this.btnBookRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBookRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRegist.Location = new System.Drawing.Point(12, 12);
            this.btnBookRegist.Name = "btnBookRegist";
            this.btnBookRegist.Size = new System.Drawing.Size(366, 108);
            this.btnBookRegist.TabIndex = 0;
            this.btnBookRegist.Text = "書籍登録";
            this.btnBookRegist.UseVisualStyleBackColor = false;
            this.btnBookRegist.Click += new System.EventHandler(this.btnBookRegist_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSearch.Location = new System.Drawing.Point(12, 126);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(366, 108);
            this.btnBookSearch.TabIndex = 0;
            this.btnBookSearch.Text = "書籍検索";
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnUserRegist
            // 
            this.btnUserRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUserRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegist.Location = new System.Drawing.Point(12, 240);
            this.btnUserRegist.Name = "btnUserRegist";
            this.btnUserRegist.Size = new System.Drawing.Size(366, 108);
            this.btnUserRegist.TabIndex = 0;
            this.btnUserRegist.Text = "会員登録";
            this.btnUserRegist.UseVisualStyleBackColor = false;
            this.btnUserRegist.Click += new System.EventHandler(this.btnUserRegist_Click);
            // 
            // BtnRentReturn
            // 
            this.BtnRentReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRentReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRentReturn.ForeColor = System.Drawing.Color.White;
            this.BtnRentReturn.Location = new System.Drawing.Point(12, 354);
            this.BtnRentReturn.Name = "BtnRentReturn";
            this.BtnRentReturn.Size = new System.Drawing.Size(366, 108);
            this.BtnRentReturn.TabIndex = 0;
            this.BtnRentReturn.Text = "貸し/借り";
            this.BtnRentReturn.UseVisualStyleBackColor = false;
            this.BtnRentReturn.Click += new System.EventHandler(this.BtnRentReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(390, 476);
            this.Controls.Add(this.BtnRentReturn);
            this.Controls.Add(this.btnUserRegist);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnBookRegist);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "メニュー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookRegist;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnUserRegist;
        private System.Windows.Forms.Button BtnRentReturn;
    }
}

