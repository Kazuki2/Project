namespace フォームデザイン1
{
    partial class rentalReturn
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
            this.rentRet = new System.Windows.Forms.Label();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labBun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rentRet
            // 
            this.rentRet.AutoSize = true;
            this.rentRet.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rentRet.Location = new System.Drawing.Point(384, 24);
            this.rentRet.Name = "rentRet";
            this.rentRet.Size = new System.Drawing.Size(411, 97);
            this.rentRet.TabIndex = 6;
            this.rentRet.Text = "貸し/借り";
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRental.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRental.ForeColor = System.Drawing.Color.Black;
            this.btnRental.Location = new System.Drawing.Point(88, 240);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(382, 187);
            this.btnRental.TabIndex = 12;
            this.btnRental.Text = "貸出";
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(696, 240);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(382, 187);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "返却";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(472, 520);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(227, 122);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // labBun
            // 
            this.labBun.AutoSize = true;
            this.labBun.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labBun.Location = new System.Drawing.Point(352, 160);
            this.labBun.Name = "labBun";
            this.labBun.Size = new System.Drawing.Size(474, 36);
            this.labBun.TabIndex = 23;
            this.labBun.Text = "下記のボタンより選択してください";
            // 
            // rentalReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1160, 684);
            this.Controls.Add(this.labBun);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.rentRet);
            this.Name = "rentalReturn";
            this.Text = "rentalReturn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rentRet;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labBun;
    }
}