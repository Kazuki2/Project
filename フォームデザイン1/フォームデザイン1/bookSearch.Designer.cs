namespace フォームデザイン1
{
    partial class bookSearch
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイトル";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(96, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTitle,
            this.clmActor});
            this.dataGridView1.Location = new System.Drawing.Point(16, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(279, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // clmTitle
            // 
            this.clmTitle.HeaderText = "タイトル";
            this.clmTitle.Name = "clmTitle";
            // 
            // clmActor
            // 
            this.clmActor.HeaderText = "著者名";
            this.clmActor.Name = "clmActor";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(279, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 242);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "bookSearch";
            this.Text = "bookSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActor;
    }
}