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
            this.btnBookRegist.Location = new System.Drawing.Point(13, 11);
            this.btnBookRegist.Name = "btnBookRegist";
            this.btnBookRegist.Size = new System.Drawing.Size(302, 64);
            this.btnBookRegist.TabIndex = 0;
            this.btnBookRegist.Text = "書籍登録";
            this.btnBookRegist.UseVisualStyleBackColor = true;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(13, 80);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(302, 64);
            this.btnBookSearch.TabIndex = 0;
            this.btnBookSearch.Text = "書籍検索";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            // 
            // btnUserRegist
            // 
            this.btnUserRegist.Location = new System.Drawing.Point(13, 149);
            this.btnUserRegist.Name = "btnUserRegist";
            this.btnUserRegist.Size = new System.Drawing.Size(302, 64);
            this.btnUserRegist.TabIndex = 0;
            this.btnUserRegist.Text = "会員登録";
            this.btnUserRegist.UseVisualStyleBackColor = true;
            // 
            // BtnRentReturn
            // 
            this.BtnRentReturn.Location = new System.Drawing.Point(13, 219);
            this.BtnRentReturn.Name = "BtnRentReturn";
            this.BtnRentReturn.Size = new System.Drawing.Size(302, 64);
            this.BtnRentReturn.TabIndex = 0;
            this.BtnRentReturn.Text = "貸し/借り";
            this.BtnRentReturn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 292);
            this.Controls.Add(this.BtnRentReturn);
            this.Controls.Add(this.btnUserRegist);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnBookRegist);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "メニュー";
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

