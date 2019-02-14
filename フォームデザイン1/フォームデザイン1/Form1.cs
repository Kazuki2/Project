using System;
using System.Windows.Forms;

namespace フォームデザイン1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase.Load();
        }

        private void btnBookRegist_Click(object sender, EventArgs e)
        {
            var form = new bookRegist();
            form.Show();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            var form = new bookSearch();
            form.Show();
        }

        private void btnUserRegist_Click(object sender, EventArgs e)
        {
            var form = new userRegist();
            form.Show();
        }

        private void BtnRentReturn_Click(object sender, EventArgs e)
        {
            var form = new rentalReturn();
            form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.Save();
        }
    }
}
