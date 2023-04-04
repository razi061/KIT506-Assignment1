using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ReOrderView : Form
    {
        public ReOrderView()
        {
            InitializeComponent();

            var index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = "TV";
            dataGridView1.Rows[index].Cells[1].Value = "LG 75-inch UQ90 4K UHD LED LCD AiThinQ Smart TV";
            dataGridView1.Rows[index].Cells[2].Value = "$1495";
            dataGridView1.Rows[index].Cells[3].Value = "25";
            dataGridView1.Rows[index].Cells[4].Value = "5";
            dataGridView1.Rows[index].Cells[5].Value = "Re-order";

            index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = "TV";
            dataGridView1.Rows[index].Cells[1].Value = "LG 65-inch CS 4K OLED Ai ThinQ Smart TV";
            dataGridView1.Rows[index].Cells[2].Value = "$2495";
            dataGridView1.Rows[index].Cells[3].Value = "12";
            dataGridView1.Rows[index].Cells[4].Value = "5";
            dataGridView1.Rows[index].Cells[5].Value = "Re-order";

            index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = "TV";
            dataGridView1.Rows[index].Cells[1].Value = "Samsung 75-inch BU8000 Crystal UHD 4K LED LCD Smart TV";
            dataGridView1.Rows[index].Cells[2].Value = "$2695";
            dataGridView1.Rows[index].Cells[3].Value = "14";
            dataGridView1.Rows[index].Cells[4].Value = "6";
            dataGridView1.Rows[index].Cells[5].Value = "Re-order";

            index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = "TV";
            dataGridView1.Rows[index].Cells[1].Value = "TCL 98-inch C735 4K QLED Smart TV";
            dataGridView1.Rows[index].Cells[2].Value = "$5595";
            dataGridView1.Rows[index].Cells[3].Value = "4";
            dataGridView1.Rows[index].Cells[4].Value = "8";
            dataGridView1.Rows[index].Cells[5].Value = "Re-order";

            index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = "TV";
            dataGridView1.Rows[index].Cells[1].Value = "LG 83-inch C2 Cinema Series 4K OLED evo Ai ThinQ Smart TV";
            dataGridView1.Rows[index].Cells[2].Value = "$7995";
            dataGridView1.Rows[index].Cells[3].Value = "2";
            dataGridView1.Rows[index].Cells[4].Value = "8";
            dataGridView1.Rows[index].Cells[5].Value = "Re-order";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var view = new ReorderConfirmView();
            view.ShowDialog();
        }
    }
}
