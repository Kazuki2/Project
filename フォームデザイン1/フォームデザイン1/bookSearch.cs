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
    public partial class bookSearch : Form
    {
        public bookSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = DataBase.GetBooksByTitle(txtTitle.Text);
            foreach (var book in result)
            {
                dataGridView1.Rows.Add(book.Title,book.Actor);
            }
        }
    }
}
