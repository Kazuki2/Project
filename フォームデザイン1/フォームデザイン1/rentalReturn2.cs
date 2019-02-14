using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace フォームデザイン1
{
    public partial class rentalReturn2 : Form
    {
       /* private Book book;
        private Member member;
        private DateTime rentalDate;
        private DateTime returnDate;*/

        public rentalReturn2()
        {
            InitializeComponent();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            DialogResult res;
            if (txtIsbn.Text == null || txtNumber.Text == null)
            {
                res = MessageBox.Show("空欄があります。入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // DataBase.Load();
            Book book =null;
            Member member =null;
            DateTime rentalDate = default(DateTime);
            DateTime retutnDate = default(DateTime);
            DataBase.Rental(book, member, rentalDate, retutnDate);
           // DataBase.Save();
        }

    private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labBunn_Click(object sender, EventArgs e)
        {

        }
    }
}
