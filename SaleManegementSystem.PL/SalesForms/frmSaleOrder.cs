using Microsoft.VisualBasic;
using SaleManegementSystem.BLL.Dtos;
using SaleManegementSystem.BLL.Services;
using SaleManegementSystem.DAL.Models;
using SalesManagementSystem.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = SaleManegementSystem.DAL.Models.Type;

namespace SaleManegementSystem.PL.SalesForms
{
    public partial class frmSaleOrder : Form
    {
        public frmSaleOrder()
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

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvSaleOrder.CurrentRow.Cells[0] != null)
                {
                    int index = dgvSaleOrder.CurrentRow.Index;
                    decimal lineTotal = Convert.ToDecimal(dgvSaleOrder.CurrentRow.Cells[index].Value);

                    dgvSaleOrder.Rows.RemoveAt(index);

                    nudTotalOrder.Value -= lineTotal;

                }
            }




        }

        private void frmProduct_Load(object sender, EventArgs e)
        {



            List<ProductReadBasicDto> products = ProductServices.GetAllPorductBasic();
            cbProducts.DataSource = products;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "Id";

            List<CustomerReadBasicDto> customers = CustomerServices.GetAllCustomerBasic();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "Id";

            txtID.Text = (SaleOrderServices.GetLastOrderID() + 1).ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            Product product = ProductServices.GetById(Convert.ToInt32(cbProducts.SelectedValue));
            if (product != null)
            {
                decimal Quantity = nudQuantity.Value;
                if (Quantity > product.Quantity)
                {
                    MessageBox.Show("الكميه المراده اكبر من الكميه المتوفره", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                decimal lineTotal = Quantity * Convert.ToDecimal(product.SalePrice);

                dgvSaleOrder.Rows.Add(
                    product.Id,
                    product.Name,
                    Quantity,
                    product.SalePrice,
                    lineTotal
                 );
                nudTotalOrder.Value += lineTotal;

            }


        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            //update product 
            List<Product> products = new List<Product>();

            for (int i = 0; i < dgvSaleOrder.Rows.Count - 1; i++)
            {
                products.Add(new Product
                {
                    Id = Convert.ToInt32(dgvSaleOrder.Rows[i].Cells[0].Value),
                    Quantity = Convert.ToDecimal(dgvSaleOrder.Rows[i].Cells[2].Value),
                });
            }

            //Update stock
            Stock stock = new Stock
            {
                Id = 5,
                TotalMoney = nudTotalOrder.Value,
            };
            //insert saleOrder

            saleOrder saleOrder = new saleOrder
            {
                id = Convert.ToInt32(txtID.Text),
                CustomerId = Convert.ToInt32(cbCustomer.SelectedValue),
                DateOrder = dtpDateOrder.Value,
                TotalOrder = Convert.ToDouble(nudTotalOrder.Value)
            };
            //insert saleOrderProduct
            List<saleOrderProduct> saleOrderProducts = new List<saleOrderProduct>();
            for (int i = 0; i < dgvSaleOrder.Rows.Count - 1; i++)
            {
                saleOrderProducts.Add(new saleOrderProduct
                {
                    productId = Convert.ToInt32(dgvSaleOrder.Rows[i].Cells[0].Value),
                    productQuantity = Convert.ToDouble(dgvSaleOrder.Rows[i].Cells[2].Value),
                    productPrice = Convert.ToDouble(dgvSaleOrder.Rows[i].Cells[3].Value),
                    ProductTotalPrice = Convert.ToDouble(dgvSaleOrder.Rows[i].Cells[4].Value),
                    OrderId = Convert.ToInt32(txtID.Text)
                });
            }

            //Insert StockDetails
            stockDetails stockDetails = new stockDetails
            {
                stockId = 5,
                OrderId = Convert.ToInt32(txtID.Text),
                Date = dtpDateOrder.Value,
                Total = Convert.ToDouble(nudQuantity.Value),
                type = Type.Sale,
            };

            bool saveOrder = SaleOrderServices.InsertSaleOrderTransaction(products, stock, saleOrder, saleOrderProducts, stockDetails);
            if (saveOrder)
            {
                MessageBox.Show("تم حفظ الفاتورة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حفظ الفاتورة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvSaleOrder.Rows.Clear();
            nudTotalOrder.Value = 0;
            nudQuantity.Value = 1;
            txtID.Text = (SaleOrderServices.GetLastOrderID() + 1).ToString();

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

        private void dgvSaleOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
