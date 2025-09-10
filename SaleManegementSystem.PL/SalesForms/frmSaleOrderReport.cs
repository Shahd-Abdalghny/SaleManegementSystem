using Microsoft.VisualBasic;
using SaleManegementSystem.BLL.Dtos;
using SaleManegementSystem.BLL.Services;
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
    public partial class frmSaleOrderReport : Form
    {
        public frmSaleOrderReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void frmProduct_Load(object sender, EventArgs e)
        {

           
        }









        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchWithDate_Click(object sender, EventArgs e)
        {
            List<SaleOrderReadProductDto> orders = SaleOrderServices.GetAllSaleOrderDateRange(Convert.ToDateTime(dtpStartDate.Value), Convert.ToDateTime(dtpEndDate.Value));
            dgvSaleOrderRebort.DataSource = orders;
            TotalOrders(orders);
        }

        private void TotalOrders(List<SaleOrderReadProductDto> orders)
        {
            foreach (var order in orders)
            {
                nudTotalOrder.Value += order.ProductTotalPrice;
            }
        }
        private void cbCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustomerName.Checked) {
                cbOrderId.Checked = false;
                nudOrderID.Enabled = false; }
            else
                nudOrderID.Enabled = true;}
        private void cbOrderId_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOrderId.Checked){
                cbCustomerName.Checked = false;
                txtCustomerName.Enabled = false;
            }
            else
                txtCustomerName.Enabled = true;
        }
        private void btnSearchWithName_Click(object sender, EventArgs e) {
            nudTotalOrder.Value = 0;
            if(cbCustomerName.Checked) {
                List<SaleOrderReadProductDto> saleOrderReadProductDtos = SaleOrderServices.GetAllSaleOrderWithCutomerName(txtCustomerName.Text);
                dgvSaleOrderRebort.DataSource = saleOrderReadProductDtos;
                TotalOrders(saleOrderReadProductDtos); 
            }
            if(cbOrderId.Checked) {
                List<SaleOrderReadProductDto> saleOrders = SaleOrderServices.GetAllSaleOrderWithOrderID(Convert.ToInt32(nudOrderID.Value));
                dgvSaleOrderRebort.DataSource= saleOrders;
            TotalOrders(saleOrders);
            }
        }
    }
}
