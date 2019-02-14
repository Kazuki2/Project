namespace フォームデザイン1
{
    partial class rentalReturn2
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
            this.labRental = new System.Windows.Forms.Label();
            this.labBunn = new System.Windows.Forms.Label();
            this.labIsbn = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.labRentaldate = new System.Windows.Forms.Label();
            this.labReturndate = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateRental = new System.Windows.Forms.DateTimePicker();
            this.dateRettime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labRental
            // 
            this.labRental.AutoSize = true;
            this.labRental.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labRental.Location = new System.Drawing.Point(440, 16);
            this.labRental.Name = "labRental";
            this.labRental.Size = new System.Drawing.Size(234, 97);
            this.labRental.TabIndex = 0;
            this.labRental.Text = "貸出";
            // 
            // labBunn
            // 
            this.labBunn.AutoSize = true;
            this.labBunn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labBunn.Location = new System.Drawing.Point(40, 136);
            this.labBunn.Name = "labBunn";
            this.labBunn.Size = new System.Drawing.Size(981, 36);
            this.labBunn.TabIndex = 1;
            this.labBunn.Text = "ISBNコード、会員番号を入力し、貸出日と返却日を選択してください";
            this.labBunn.Click += new System.EventHandler(this.labBunn_Click);
            // 
            // labIsbn
            // 
            this.labIsbn.AutoSize = true;
            this.labIsbn.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labIsbn.Location = new System.Drawing.Point(208, 206);
            this.labIsbn.Name = "labIsbn";
            this.labIsbn.Size = new System.Drawing.Size(249, 52);
            this.labIsbn.TabIndex = 2;
            this.labIsbn.Text = "ISBNコード";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labNumber.Location = new System.Drawing.Point(208, 288);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(231, 52);
            this.labNumber.TabIndex = 3;
            this.labNumber.Text = "会員番号";
            // 
            // labRentaldate
            // 
            this.labRentaldate.AutoSize = true;
            this.labRentaldate.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labRentaldate.Location = new System.Drawing.Point(208, 370);
            this.labRentaldate.Name = "labRentaldate";
            this.labRentaldate.Size = new System.Drawing.Size(179, 52);
            this.labRentaldate.TabIndex = 4;
            this.labRentaldate.Text = "貸出日";
            // 
            // labReturndate
            // 
            this.labReturndate.AutoSize = true;
            this.labReturndate.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labReturndate.Location = new System.Drawing.Point(208, 454);
            this.labReturndate.Name = "labReturndate";
            this.labReturndate.Size = new System.Drawing.Size(283, 52);
            this.labReturndate.TabIndex = 5;
            this.labReturndate.Text = "返却予定日";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIsbn.Location = new System.Drawing.Point(640, 216);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(256, 51);
            this.txtIsbn.TabIndex = 6;
            this.txtIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNumber.Location = new System.Drawing.Point(640, 298);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(256, 51);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRental.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRental.Location = new System.Drawing.Point(424, 560);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(256, 112);
            this.btnRental.TabIndex = 10;
            this.btnRental.Text = "貸出";
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(56, 576);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 80);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateRental
            // 
            this.dateRental.Location = new System.Drawing.Point(640, 392);
            this.dateRental.Name = "dateRental";
            this.dateRental.Size = new System.Drawing.Size(200, 25);
            this.dateRental.TabIndex = 12;
            // 
            // dateRettime
            // 
            this.dateRettime.Location = new System.Drawing.Point(640, 472);
            this.dateRettime.Name = "dateRettime";
            this.dateRettime.Size = new System.Drawing.Size(200, 25);
            this.dateRettime.TabIndex = 13;
            // 
            // rentalReturn2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1160, 684);
            this.Controls.Add(this.dateRettime);
            this.Controls.Add(this.dateRental);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.labReturndate);
            this.Controls.Add(this.labRentaldate);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labIsbn);
            this.Controls.Add(this.labBunn);
            this.Controls.Add(this.labRental);
            this.Name = "rentalReturn2";
            this.Text = "rentalReturn2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRental;
        private System.Windows.Forms.Label labBunn;
        private System.Windows.Forms.Label labIsbn;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labRentaldate;
        private System.Windows.Forms.Label labReturndate;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateRental;
        private System.Windows.Forms.DateTimePicker dateRettime;
    }
}