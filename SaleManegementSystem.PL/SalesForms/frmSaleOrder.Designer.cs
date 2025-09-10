namespace SaleManegementSystem.PL.SalesForms
{
    partial class frmSaleOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleOrder));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            nudTotalOrder = new NumericUpDown();
            label3 = new Label();
            txtID = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSaveOrder = new Button();
            dgvSaleOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label6 = new Label();
            dtpDateOrder = new DateTimePicker();
            cbCustomer = new ComboBox();
            cbProducts = new ComboBox();
            nudQuantity = new NumericUpDown();
            label5 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
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
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(515, 23);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 1;
            label1.Text = "شاشة الفاتورة";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(nudTotalOrder);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 566);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 57);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(207, 20);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 29;
            label2.Text = "اجمالي الفاتورة:";
            // 
            // nudTotalOrder
            // 
            nudTotalOrder.Location = new Point(33, 14);
            nudTotalOrder.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            nudTotalOrder.Name = "nudTotalOrder";
            nudTotalOrder.Size = new Size(150, 31);
            nudTotalOrder.TabIndex = 28;
            nudTotalOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 108);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 3;
            label3.Text = "رقم الفاتورة: ";
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(679, 241);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 37);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.CornflowerBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(830, 241);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button4_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = Color.CornflowerBlue;
            btnSaveOrder.Cursor = Cursors.Hand;
            btnSaveOrder.ForeColor = Color.White;
            btnSaveOrder.Location = new Point(943, 139);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(181, 37);
            btnSaveOrder.TabIndex = 12;
            btnSaveOrder.Text = "حفظ الفاتورة";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnDeleteAll_Click;
            // 
            // dgvSaleOrder
            // 
            dgvSaleOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleOrder.BackgroundColor = Color.AliceBlue;
            dgvSaleOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvSaleOrder.Location = new Point(12, 327);
            dgvSaleOrder.Name = "dgvSaleOrder";
            dgvSaleOrder.RowHeadersWidth = 51;
            dgvSaleOrder.Size = new Size(1159, 225);
            dgvSaleOrder.TabIndex = 15;
            dgvSaleOrder.CellContentClick += dgvSaleOrder_CellContentClick;
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
            Column5.DataPropertyName = "Total";
            Column5.HeaderText = "الاجمالي";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 108);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 16;
            label4.Text = "التاريخ: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(620, 108);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 23;
            label6.Text = "العميل: ";
            label6.Click += label6_Click;
            // 
            // dtpDateOrder
            // 
            dtpDateOrder.Format = DateTimePickerFormat.Short;
            dtpDateOrder.Location = new Point(323, 145);
            dtpDateOrder.Name = "dtpDateOrder";
            dtpDateOrder.Size = new Size(250, 31);
            dtpDateOrder.TabIndex = 24;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(620, 145);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(225, 33);
            cbCustomer.TabIndex = 25;
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(243, 245);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(225, 33);
            cbProducts.TabIndex = 26;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(491, 247);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(150, 31);
            nudQuantity.TabIndex = 27;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 219);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 28;
            label5.Text = "المنتجات:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 219);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 29;
            label7.Text = "الكميه";
            // 
            // frmSaleOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1183, 623);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(nudQuantity);
            Controls.Add(cbProducts);
            Controls.Add(cbCustomer);
            Controls.Add(dtpDateOrder);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dgvSaleOrder);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "frmSaleOrder";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشه الفاتورة";
            Load += frmProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSaveOrder;
        private DataGridView dgvSaleOrder;
        private Label label4;
        private Label label6;
        private Label label2;
        private NumericUpDown nudTotalOrder;
        private DateTimePicker dtpDateOrder;
        private ComboBox cbCustomer;
        private ComboBox cbProducts;
        private NumericUpDown nudQuantity;
        private Label label5;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}