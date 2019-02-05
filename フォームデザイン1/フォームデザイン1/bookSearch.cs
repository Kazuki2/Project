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

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookSearch_Load(object sender, EventArgs e)
        {
            table = new DataTable("Table");

            // カラム名の追加
            table.Columns.Add("タイトル");
            table.Columns.Add("著者");

            // Rows.Addメソッドを使ってデータを追加
            table.Rows.Add("坊ちゃん", "夏目漱石");
            table.Rows.Add("吾輩は猫である", "夏目漱石");
            table.Rows.Add("こころ", "夏目漱石");
            table.Rows.Add("河童", "芥川龍之介");
            table.Rows.Add("舞姫", "森鴎外");
            table.Rows.Add("人間失格", "太宰治");
            table.Rows.Add("蜘蛛の糸", "太宰治");
            table.Rows.Add("羅生門", "芥川龍之介");
            table.Rows.Add("鼻", "芥川龍之介");

            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataRow[] dRows = table.AsEnumerable()
                .Where(row => row.Field<string>("タイトル") == txtTitle.Text).ToArray();

            DataRow[] cRows = table.AsEnumerable()
                .Where(row => row.Field<string>("著者") == txtActor.Text).ToArray();


            DataTable sub = new DataTable("sub");

            // カラム名の追加
            sub.Columns.Add("タイトル");
            sub.Columns.Add("著者");

            foreach (var row in dRows)
            {
                sub.Rows.Add(row[0], row[1]);
            }

            foreach (var row in cRows)
            {
                sub.Rows.Add(row[0], row[1]);
            }


            dataGridView1.DataSource = sub;
        }
    

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
