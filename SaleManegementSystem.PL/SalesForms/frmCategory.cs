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
    public partial class frmCategory : Form
    {
        public frmCategory()
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

            bool isDeleted = CategoryServices.DeleteCategory(int.Parse(txtID.Text));
            if (isDeleted)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCategory();

        }
        private void LoadingCategory()
        {
            List<Category> categories = CategoryServices.GetCategorys();
            dgvCategory.DataSource = categories;
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDeleteAll.Enabled = false;
            LoadingCategory();
        }

        private void Validation()
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Category category = new Category
            {
                Name = txtName.Text,

            };
            bool isAdded = CategoryServices.AddCategory(category);
            if (isAdded)
            {
                MessageBox.Show("تمت الاضافه بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم تتم الاضافه ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCategory();

        }

        private void dgvCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayWhenEdit();
            txtID.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            Validation();
            Category category = new Category
            {
                Id = int.Parse(txtID.Text),
                Name = txtName.Text,
            };

            bool isUpdated = CategoryServices.UpdateCategory(category);
            if (isUpdated)
            {
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم التعديل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCategory();

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            if (MessageBox.Show("هل انت متأكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            bool isDeleteAll = CategoryServices.DeleteAllCategory();


            if (isDeleteAll)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCategory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Category> categories = CategoryServices.GetCategorysByPattern(txtSearch.Text);
            dgvCategory.DataSource = categories;
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
