namespace SaleManegementSystem.PL.SalesForms
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            txtID = new TextBox();
            btnNew = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvProduct = new DataGridView();
            txtName = new TextBox();
            label4 = new Label();
            nudQuantity = new NumericUpDown();
            nudBuyPrice = new NumericUpDown();
            nudSalePrice = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbCategory = new ComboBox();
            label7 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(515, 23);
            label1.Name = "label1";
            label1.Size = new Size(159, 31);
            label1.TabIndex = 1;
            label1.Text = "شاشه المنتجات";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 566);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 57);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 108);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 3;
            label3.Text = "رقم المنتج: ";
            label3.Click += label3_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(41, 147);
            txtID.Name = "txtID";
            txtID.Size = new Size(191, 31);
            txtID.TabIndex = 6;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.CornflowerBlue;
            btnNew.Cursor = Cursors.Hand;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(173, 221);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(115, 37);
            btnNew.TabIndex = 8;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(323, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 37);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(469, 221);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 37);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.CornflowerBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(618, 221);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button4_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.CornflowerBlue;
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(764, 221);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(115, 37);
            btnDeleteAll.TabIndex = 12;
            btnDeleteAll.Text = "حذف الجميع";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(655, 288);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 37);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(343, 291);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 31);
            txtSearch.TabIndex = 14;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.AliceBlue;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvProduct.Location = new Point(12, 335);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1159, 225);
            dgvProduct.TabIndex = 15;
            dgvProduct.CellMouseClick += dgvProduct_CellMouseClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(238, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 31);
            txtName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 108);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 16;
            label4.Text = "اسم المنتج:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(793, 147);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(150, 31);
            nudQuantity.TabIndex = 18;
            // 
            // nudBuyPrice
            // 
            nudBuyPrice.Location = new Point(612, 146);
            nudBuyPrice.Name = "nudBuyPrice";
            nudBuyPrice.Size = new Size(150, 31);
            nudBuyPrice.TabIndex = 19;
            // 
            // nudSalePrice
            // 
            nudSalePrice.Location = new Point(447, 146);
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(150, 31);
            nudSalePrice.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(793, 108);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 21;
            label2.Text = "الكمية :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 108);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 22;
            label5.Text = "سعر الشراء :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 108);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 23;
            label6.Text = "سعر البيع :";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(966, 146);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 33);
            cbCategory.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(966, 108);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 25;
            label7.Text = "المجموعة: ";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم المنتج";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم المنتج ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Quantity";
            Column3.HeaderText = "الكمية";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SALEPRICE";
            Column4.HeaderText = "سعر البيع";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BuyPrice";
            Column5.HeaderText = "سعر الشراء";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CategoryId";
            Column6.HeaderText = "المجموعة";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1183, 623);
            Controls.Add(label7);
            Controls.Add(cbCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(nudSalePrice);
            Controls.Add(nudBuyPrice);
            Controls.Add(nudQuantity);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(dgvProduct);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "frmProduct";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشه المجموعات";
            Load += frmProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox txtID;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvProduct;
        private TextBox txtName;
        private Label label4;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudBuyPrice;
        private NumericUpDown nudSalePrice;
        private Label label2;
        private Label label5;
        private Label label6;
        private ComboBox cbCategory;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}