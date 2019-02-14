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
    public partial class userRegist : Form
    {
        public userRegist()
        {
            InitializeComponent();
        }

        private void userRegist_Load(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateBarth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var member = new Member();
            member.Address = txtAddress.Text;
            member.Email = txtEmail.Text;
            member.BarthDay = dateBarth.Value;
            member.Name = txtName.Text;
            member.Tel = txtTel.Text;
            MessageBox.Show("会員番号："+DataBase.AddMember(member).ToString());
            //DataBase.AddMember(member);
        }
    }
}
