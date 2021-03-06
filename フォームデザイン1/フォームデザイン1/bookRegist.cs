﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace フォームデザイン1
{
    public partial class bookRegist : Form
    {
        public bookRegist()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var book = new Book();
            book.Title = txtTitle.Text;
            book.Actor = txtActor.Text;
            book.Company = txtCom.Text;
            book.IssueDate = dateIssue.Value;
            book.Isbn = txtIsbn.Text;
            DataBase.AddBook(book);
            MessageBox.Show(DataBase.BooksToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
