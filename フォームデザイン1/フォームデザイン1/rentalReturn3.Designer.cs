namespace フォームデザイン1
{
    partial class rentalReturn3
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
            this.labReturn = new System.Windows.Forms.Label();
            this.labIsbn = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.labBun = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labReturn
            // 
            this.labReturn.AutoSize = true;
            this.labReturn.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labReturn.Location = new System.Drawing.Point(432, 24);
            this.labReturn.Name = "labReturn";
            this.labReturn.Size = new System.Drawing.Size(234, 97);
            this.labReturn.TabIndex = 5;
            this.labReturn.Text = "返却";
            // 
            // labIsbn
            // 
            this.labIsbn.AutoSize = true;
            this.labIsbn.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labIsbn.Location = new System.Drawing.Point(224, 264);
            this.labIsbn.Name = "labIsbn";
            this.labIsbn.Size = new System.Drawing.Size(249, 52);
            this.labIsbn.TabIndex = 6;
            this.labIsbn.Text = "ISBNコード";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labNumber.Location = new System.Drawing.Point(232, 424);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(231, 52);
            this.labNumber.TabIndex = 7;
            this.labNumber.Text = "会員番号";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIsbn.Location = new System.Drawing.Point(600, 264);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(270, 51);
            this.txtIsbn.TabIndex = 8;
            this.txtIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNumber.Location = new System.Drawing.Point(592, 424);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(270, 51);
            this.txtNumber.TabIndex = 9;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labBun
            // 
            this.labBun.AutoSize = true;
            this.labBun.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labBun.Location = new System.Drawing.Point(264, 168);
            this.labBun.Name = "labBun";
            this.labBun.Size = new System.Drawing.Size(592, 36);
            this.labBun.TabIndex = 10;
            this.labBun.Text = "ISBNコードと会員番号を入力してください";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(408, 544);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 112);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "返却";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(40, 544);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 104);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rentalReturn3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1160, 684);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.labBun);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labIsbn);
            this.Controls.Add(this.labReturn);
            this.Name = "rentalReturn3";
            this.Text = "rentalReturn3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labReturn;
        private System.Windows.Forms.Label labIsbn;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label labBun;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBack;
    }
}