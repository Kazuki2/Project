﻿namespace フォームデザイン1
{
    partial class bookRegist
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
            if (disposing && (components != null)) {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.dateIssue = new System.Windows.Forms.DateTimePicker();
            this.btnRegist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(285, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBNコード";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(300, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "タイトル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(298, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "著者名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(264, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "発行年月日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(275, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "発行会社";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(480, 46);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(287, 31);
            this.txtIsbn.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(480, 100);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(287, 31);
            this.txtTitle.TabIndex = 1;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(480, 157);
            this.txtActor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(287, 31);
            this.txtActor.TabIndex = 1;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(491, 308);
            this.txtCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(287, 31);
            this.txtCom.TabIndex = 1;
            // 
            // dateIssue
            // 
            this.dateIssue.Location = new System.Drawing.Point(491, 229);
            this.dateIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateIssue.Name = "dateIssue";
            this.dateIssue.Size = new System.Drawing.Size(287, 31);
            this.dateIssue.TabIndex = 2;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(277, 473);
            this.btnRegist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(490, 40);
            this.btnRegist.TabIndex = 3;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            // 
            // bookRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 666);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.dateIssue);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bookRegist";
            this.Text = "bookRegist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.DateTimePicker dateIssue;
        private System.Windows.Forms.Button btnRegist;
    }
}