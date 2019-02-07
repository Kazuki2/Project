using System;
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
        private DataTable table;

        public bookSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataRow[] dRows = table.AsEnumerable()
               .Where(row => row.Field<string>("タイトル") == txtTitle.Text).ToArray();

            var result = DataBase.GetBooksByTitle(txtTitle.Text);
            foreach (var book in result)
            {
                dataGridView1.Rows.Add(book.Title,book.Actor);
            }
        }
    }
}
