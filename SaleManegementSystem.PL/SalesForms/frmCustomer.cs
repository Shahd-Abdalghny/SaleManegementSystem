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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
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
            txtID.Text = txtName.Text = txtSearch.Text=txtAddress.Text=txtNumberPhone.Text = string.Empty;
            dtpBirthDate.Value=DateTime.Now;

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

            bool isDeleted = CustomerServices.DeleteCustomer(int.Parse(txtID.Text));
            if (isDeleted)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCustomer();

        }
        private void LoadingCustomer()
        {
            List<Customer> customers = CustomerServices.GetCustomers();
            dgvCustomer.DataSource = customers;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnDeleteAll.Enabled = false;
            LoadingCustomer();
        }

        private void Validation()
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم العميل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtNumberPhone.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم الهاتف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("من فضلك ادخل العنوان", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtpBirthDate.Value==DateTime.Now)
            {
                MessageBox.Show("من فضلك ادخل تاريخ الميلاد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Validation();
            Customer Customer = new Customer
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                phoneNumber = txtNumberPhone.Text,
                BirthDate = dtpBirthDate.Value,
            };
            bool isAdded = CustomerServices.AddCustomer(Customer);
            if (isAdded)
            {
                MessageBox.Show("تمت الاضافه بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم تتم الاضافه ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCustomer();

        }

        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayWhenEdit();
            txtID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtNumberPhone.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            dtpBirthDate.Value = (DateTime)dgvCustomer.CurrentRow.Cells[4].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            Validation();
            Customer Customer = new Customer
            {
                Id = int.Parse(txtID.Text),
                Name = txtName.Text,
                Address = txtAddress.Text,
                phoneNumber = txtNumberPhone.Text,
                BirthDate = dtpBirthDate.Value,
            };

            bool isUpdated = CustomerServices.UpdateCustomer(Customer);
            if (isUpdated)
            {
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم التعديل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCustomer();

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisplayWhenEdit();
            if (MessageBox.Show("هل انت متأكد من الحذف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            bool isDeleteAll = CustomerServices.DeleteAllCustomer();


            if (isDeleteAll)
            {
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadingCustomer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerServices.GetCustomersByPattern(txtSearch.Text);
            dgvCustomer.DataSource = customers;
        }

        private void DisplayWhenEdit()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnDeleteAll.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
