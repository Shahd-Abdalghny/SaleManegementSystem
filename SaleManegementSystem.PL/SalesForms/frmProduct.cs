using SaleManegementSystem.BLL.Services;
using SaleManegementSystem.DAL.Models;
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
    public partial class frmProduct : Form
    {
        public frmProduct()
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
            txtID.Text = txtName.Text = txtSearch.Text = string.Empty;
            nudSalePrice.Value= nudQuantity.Value=nudBuyPrice.Value = 0;
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDeleteAll.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            if (MessageBox.Show("هل انت متأكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            Validation();

            bool isDeleted = ProductServices.DeleteProduct(int.Parse(txtID.Text));
            if (isDeleted)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingProduct();

        }
        private void LoadingProduct()
        {
            List<Product> products = ProductServices.GetProducts();
            dgvProduct.DataSource = products;
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDeleteAll.Enabled = false;
            LoadingProduct();

            List<Category> categories = CategoryServices.GetCategorys();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        private void Validation()
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المنتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudBuyPrice.Value<=0)
            {
                MessageBox.Show("من فضلك ادخل سعر البيع المنتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر الشراء المنتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المنتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر البيع المنتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر الشراء المنتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Product Product = new Product
            {
                Name = txtName.Text,
                BuyPrice = (decimal)nudBuyPrice.Value,
                SalePrice = (decimal)nudSalePrice.Value,
                Quantity = (decimal)nudQuantity.Value,
                CategoryId=(int)cbCategory.SelectedValue,
                
            };
            
           
            bool isAdded = ProductServices.AddProduct(Product);
            if (isAdded)
            {
                MessageBox.Show("تمت الاضافه بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم تتم الاضافه ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingProduct();

        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayWhenEdit();
            txtID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            nudQuantity.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[4].Value);
            nudSalePrice.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[3].Value);
            nudBuyPrice.Value=Convert.ToDecimal(dgvProduct.CurrentRow.Cells[2].Value);
            cbCategory.SelectedValue = dgvProduct.CurrentRow.Cells[5].Value;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            Validation();
            Product Product = new Product
            {
                Id = int.Parse(txtID.Text),
                Name = txtName.Text,
                BuyPrice = (decimal)nudBuyPrice.Value,
                SalePrice = (decimal)nudSalePrice.Value,
                Quantity = (decimal)nudQuantity.Value,
                CategoryId = (int)cbCategory.SelectedValue,
            };

            bool isUpdated = ProductServices.UpdateProduct(Product);
            if (isUpdated)
            {
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم التعديل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingProduct();

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            if (MessageBox.Show("هل انت متأكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            bool isDeleteAll = ProductServices.DeleteAllProduct();


            if (isDeleteAll)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingProduct();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> products = ProductServices.GetProductsByPattern(txtSearch.Text);
            dgvProduct.DataSource = products;
        }

        private void DisplayWhenEdit()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnDeleteAll.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
