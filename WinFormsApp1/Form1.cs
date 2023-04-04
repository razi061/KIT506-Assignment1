namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var productSearch = new ProductSearchView();
            productSearch.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var reorderView = new ReOrderView();
            reorderView.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var view = new ProductPerformanceReport();
            view.Show();
        }
    }
}