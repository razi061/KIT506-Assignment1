using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ProductSearchView : Form
    {
        public ProductSearchView()
        {
            InitializeComponent();

            pictureBox1.ImageLocation = @"lg-tv.jpg";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProductView();
            addProduct.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var purchaseForm = new PruchaseView();
            purchaseForm.Show();
        }
    }
}
