using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridview検証
{
    public partial class Form1 : Form
    {
        private DataTable table;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable("Table");

            TestList testlist = new TestList();
            dataGridView1.DataSource = testlist.Data;

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "教科";
            dataGridView1.Columns[1].HeaderText = "点数";
            dataGridView1.Columns[2].HeaderText = "氏名";
            dataGridView1.Columns[3].HeaderText = "クラス名";

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow[] dRows = testlist.AsEnumerable()
                .Where(row => row.Field<string>("教科") == textBox1.Text).ToArray();

            DataTable sub = new DataTable("sub");

            // カラム名の追加
            sub.Columns.Add("教科");
            sub.Columns.Add("点数", Type.GetType("System.Int32"));
            sub.Columns.Add("氏名");
            sub.Columns.Add("クラス名");

            foreach (var row in dRows)
            {
                sub.Rows.Add(row[0], row[1], row[2], row[3]);
            }

            dataGridView2.DataSource = sub;
        }

       

}
    
}
