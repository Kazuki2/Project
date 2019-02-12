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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRental = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(367, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 97);
            this.label2.TabIndex = 5;
            this.label2.Text = "返却";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(151, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "ISBNコード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(158, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "会員番号";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIsbn.Location = new System.Drawing.Point(533, 302);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(243, 51);
            this.txtIsbn.TabIndex = 8;
            this.txtIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtUserID.Location = new System.Drawing.Point(533, 471);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(243, 51);
            this.txtUserID.TabIndex = 9;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(223, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(592, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "ISBNコードと会員番号を入力してください";
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRental.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRental.ForeColor = System.Drawing.Color.Black;
            this.btnRental.Location = new System.Drawing.Point(338, 604);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(230, 124);
            this.btnRental.TabIndex = 11;
            this.btnRental.Text = "返却";
            this.btnRental.UseVisualStyleBackColor = false;
            //this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(16, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 89);
            this.button1.TabIndex = 12;
            this.button1.Text = "戻る";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rentalReturn3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(954, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "rentalReturn3";
            this.Text = "rentalReturn3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button button1;
    }
}