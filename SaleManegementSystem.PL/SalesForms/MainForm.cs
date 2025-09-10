using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManegementSystem.PL.SalesForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoryScreen_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmSaleOrder order = new frmSaleOrder();
            order.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmStock frmStock = new frmStock();
            frmStock.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSaleOrderReport report = new frmSaleOrderReport();
            report.ShowDialog();
        }
    }
}
