namespace SaleManegementSystem.PL.SalesForms
{
    partial class frmSaleOrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleOrderReport));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            nudTotalOrder = new NumericUpDown();
            label3 = new Label();
            txtCustomerName = new TextBox();
            btnSearchWithName = new Button();
            btnSearchWithDate = new Button();
            dgvSaleOrderRebort = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label6 = new Label();
            dtpStartDate = new DateTimePicker();
            nudOrderID = new NumericUpDown();
            label5 = new Label();
            label7 = new Label();
            dtpEndDate = new DateTimePicker();
            cbCustomerName = new CheckBox();
            cbOrderId = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrderRebort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOrderID).BeginInit();
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
            label3.Location = new Point(297, 244);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            label3.Click += label3_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(510, 253);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(191, 31);
            txtCustomerName.TabIndex = 6;
            // 
            // btnSearchWithName
            // 
            btnSearchWithName.BackColor = Color.CornflowerBlue;
            btnSearchWithName.Cursor = Cursors.Hand;
            btnSearchWithName.ForeColor = Color.White;
            btnSearchWithName.Location = new Point(141, 247);
            btnSearchWithName.Name = "btnSearchWithName";
            btnSearchWithName.Size = new Size(115, 37);
            btnSearchWithName.TabIndex = 9;
            btnSearchWithName.Text = "بحث";
            btnSearchWithName.UseVisualStyleBackColor = false;
            btnSearchWithName.Click += btnSearchWithName_Click;
            // 
            // btnSearchWithDate
            // 
            btnSearchWithDate.BackColor = Color.CornflowerBlue;
            btnSearchWithDate.Cursor = Cursors.Hand;
            btnSearchWithDate.ForeColor = Color.White;
            btnSearchWithDate.Location = new Point(141, 139);
            btnSearchWithDate.Name = "btnSearchWithDate";
            btnSearchWithDate.Size = new Size(115, 37);
            btnSearchWithDate.TabIndex = 11;
            btnSearchWithDate.Text = "بحث";
            btnSearchWithDate.UseVisualStyleBackColor = false;
            btnSearchWithDate.Click += btnSearchWithDate_Click;
            // 
            // dgvSaleOrderRebort
            // 
            dgvSaleOrderRebort.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleOrderRebort.BackgroundColor = Color.AliceBlue;
            dgvSaleOrderRebort.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleOrderRebort.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column2, Column3, Column4, Column5 });
            dgvSaleOrderRebort.Location = new Point(12, 335);
            dgvSaleOrderRebort.Name = "dgvSaleOrderRebort";
            dgvSaleOrderRebort.RowHeadersWidth = 51;
            dgvSaleOrderRebort.Size = new Size(1159, 225);
            dgvSaleOrderRebort.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SaleOrderID";
            Column1.HeaderText = "رقم الفاتوره";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CustomerName";
            Column6.HeaderText = "اسم العميل";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "اسم المنتج ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ProductQuantity";
            Column3.HeaderText = "الكمية";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ProductPrice";
            Column4.HeaderText = "سعر البيع";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ProductTotalPrice";
            Column5.HeaderText = "الاجمالي";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 108);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 16;
            label4.Text = "من تاريخ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(620, 108);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 23;
            label6.Text = "الي تاريخ :";
            label6.Click += label6_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(323, 145);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 31);
            dtpStartDate.TabIndex = 24;
            // 
            // nudOrderID
            // 
            nudOrderID.Location = new Point(776, 253);
            nudOrderID.Name = "nudOrderID";
            nudOrderID.Size = new Size(150, 31);
            nudOrderID.TabIndex = 27;
            nudOrderID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 219);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 28;
            label5.Text = "اسم العميل:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(776, 219);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 29;
            label7.Text = "رقم الفاتوره:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(620, 145);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 31);
            dtpEndDate.TabIndex = 30;
            // 
            // cbCustomerName
            // 
            cbCustomerName.AutoSize = true;
            cbCustomerName.Location = new Point(297, 228);
            cbCustomerName.Name = "cbCustomerName";
            cbCustomerName.Size = new Size(182, 29);
            cbCustomerName.TabIndex = 32;
            cbCustomerName.Text = "البحث باسم العميل ";
            cbCustomerName.UseVisualStyleBackColor = true;
            cbCustomerName.CheckedChanged += cbCustomerName_CheckedChanged;
            // 
            // cbOrderId
            // 
            cbOrderId.AutoSize = true;
            cbOrderId.Location = new Point(297, 263);
            cbOrderId.Name = "cbOrderId";
            cbOrderId.Size = new Size(176, 29);
            cbOrderId.TabIndex = 33;
            cbOrderId.Text = "البحث برقم الفاتوره";
            cbOrderId.UseVisualStyleBackColor = true;
            cbOrderId.CheckedChanged += cbOrderId_CheckedChanged;
            // 
            // frmSaleOrderReport
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1183, 623);
            Controls.Add(cbOrderId);
            Controls.Add(cbCustomerName);
            Controls.Add(dtpEndDate);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(nudOrderID);
            Controls.Add(dtpStartDate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dgvSaleOrderRebort);
            Controls.Add(btnSearchWithDate);
            Controls.Add(btnSearchWithName);
            Controls.Add(txtCustomerName);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "frmSaleOrderReport";
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
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrderRebort).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOrderID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox txtCustomerName;
        private Button btnSearchWithName;
        private Button btnSearchWithDate;
        private DataGridView dgvSaleOrderRebort;
        private Label label4;
        private Label label6;
        private Label label2;
        private NumericUpDown nudTotalOrder;
        private DateTimePicker dtpStartDate;
        private NumericUpDown nudOrderID;
        private Label label5;
        private Label label7;
        private DateTimePicker dtpEndDate;
        private CheckBox cbCustomerName;
        private CheckBox cbOrderId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}