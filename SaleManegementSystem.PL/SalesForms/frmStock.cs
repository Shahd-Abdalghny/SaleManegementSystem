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
    public partial class frmStock : Form
    {
        public frmStock()
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
            txtID.Text= txtName.Text=txtSearch.Text=string.Empty;
            nudTotalMoney.Value = 1;
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

            bool isDeleted = StockServices.DeleteStock(int.Parse(txtID.Text));
            if (isDeleted)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingStock();

        }
        private void LoadingStock()
        {
            List<Stock> stocks = StockServices.GetStocks();
            dgvStock.DataSource = stocks;
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDeleteAll.Enabled = false;
            LoadingStock();
        }

        private void Validation()
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الخزنة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudTotalMoney.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل المبلغ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الخزنة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Stock Stock = new Stock
            {
                Name = txtName.Text,
                TotalMoney=Convert.ToDecimal(nudTotalMoney.Value)

            };
            bool isAdded = StockServices.AddStock(Stock);
            if (isAdded)
            {
                MessageBox.Show("تمت الاضافه بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم تتم الاضافه ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingStock();

        }

        private void dgvStock_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayWhenEdit();
            txtID.Text = dgvStock.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            nudTotalMoney.Value= (decimal)dgvStock.CurrentRow.Cells[2].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            Validation();
            Stock Stock = new Stock
            {
                Id = int.Parse(txtID.Text),
                Name = txtName.Text,
                TotalMoney = Convert.ToDecimal(nudTotalMoney.Value)
            };

            bool isUpdated = StockServices.UpdateStock(Stock);
            if (isUpdated)
            {
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم التعديل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingStock();

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            if (MessageBox.Show("هل انت متأكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            bool isDeleteAll = StockServices.DeleteAllStock();


            if (isDeleteAll)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingStock();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Stock> stocks = StockServices.GetStocksByPattern(txtSearch.Text);
            dgvStock.DataSource = stocks;
        }

        private void DisplayWhenEdit()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnDeleteAll.Enabled = true;
        }
    }
}
