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
    public partial class rentalReturn : Form
    {
        public rentalReturn()
        {
            InitializeComponent();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            rentalReturn2 rentalReturn2 = new rentalReturn2();
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rentalReturn3 rentalReturn3 = new rentalReturn3();
            ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
