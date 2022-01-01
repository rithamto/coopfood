using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoopFood
{
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked Me!!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
