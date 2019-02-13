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

        private void bookSearch_Load(object sender, EventArgs e)
        {
            table = new DataTable("Table");

            table.Rows.Add("坊ちゃん", "夏目漱石");
            table.Rows.Add("こころ", "夏目漱石");
            table.Rows.Add("吾輩は猫である", "夏目漱石");
            table.Rows.Add("舞姫", "森鴎外");
            table.Rows.Add("羅生門", "芥川龍之介");
            table.Rows.Add("河童", "芥川龍之介");
            table.Rows.Add("人間失格", "太宰治");
            table.Rows.Add("雪国", "川端康成");
           

            dataGridView1.DataSource = table;
        }
    }
}
