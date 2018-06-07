using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplamviecnham
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnnap_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.Show();
            this.Hide();
        }

        private void btnthanhtoan_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thanh công");
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm thanh công");
        }
    }
}
