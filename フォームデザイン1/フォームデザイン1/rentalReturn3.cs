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
    public partial class rentalReturn3 : Form
    {
       /* private Book book;
        private Member member;*/

        public rentalReturn3()
        {
            InitializeComponent();
        }

       internal static void Show(object _)
        {
            throw new NotImplementedException();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            if(txtIsbn==null||txtNumber==null)
            {
                res=MessageBox.Show("空欄があります。入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataBase.Load();
            Book book = null;
            Member member = null;
            DataBase.Return(book,member);
            DataBase.Save();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
