namespace SaleManegementSystem.PL.SalesForms
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            btnNew = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtAddress = new TextBox();
            label4 = new Label();
            txtNumberPhone = new TextBox();
            label5 = new Label();
            dtpBirthDate = new DateTimePicker();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(491, 21);
            label1.Name = "label1";
            label1.Size = new Size(140, 31);
            label1.TabIndex = 1;
            label1.Text = "شاشه العملاء";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 57);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 108);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 2;
            label2.Text = "اسم العميل :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 108);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 3;
            label3.Text = "رقم العميل: ";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(29, 147);
            txtID.Name = "txtID";
            txtID.Size = new Size(143, 31);
            txtID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(198, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 31);
            txtName.TabIndex = 7;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.CornflowerBlue;
            btnNew.Cursor = Cursors.Hand;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(174, 209);
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
            btnAdd.Location = new Point(324, 209);
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
            btnUpdate.Location = new Point(470, 209);
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
            btnDelete.Location = new Point(619, 209);
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
            btnDeleteAll.Location = new Point(765, 209);
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
            btnSearch.Location = new Point(655, 276);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 37);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(343, 279);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 31);
            txtSearch.TabIndex = 14;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.AliceBlue;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvCustomer.Location = new Point(12, 335);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(1076, 164);
            dgvCustomer.TabIndex = 15;
            dgvCustomer.CellMouseClick += dgvCustomer_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "وقم العميل";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم العميل";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Address";
            Column3.HeaderText = "العنوان";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PhoneNumber";
            Column4.HeaderText = "رقم الهاتف";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BirthDate";
            Column5.HeaderText = "تاريخ الميلاد";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(372, 148);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(152, 31);
            txtAddress.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 108);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 16;
            label4.Text = "العنوان :";
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Location = new Point(563, 148);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(207, 31);
            txtNumberPhone.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(563, 109);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 18;
            label5.Text = "رقم الهاتف :";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(803, 148);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 31);
            dtpBirthDate.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(803, 109);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 22;
            label6.Text = "تاريخ الميلاد:";
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1100, 562);
            Controls.Add(label6);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtNumberPhone);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(dgvCustomer);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "frmCustomer";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشه العملاء";
            Load += frmCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtName;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvCustomer;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtNumberPhone;
        private Label label5;
        private DateTimePicker dtpBirthDate;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}