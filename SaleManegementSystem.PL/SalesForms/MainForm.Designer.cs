namespace SaleManegementSystem.PL.SalesForms
{
    partial class MainForm
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
            btnCategoryScreen = new Button();
            btnProductScreen = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnCategoryScreen
            // 
            btnCategoryScreen.BackColor = Color.Snow;
            btnCategoryScreen.Location = new Point(166, 185);
            btnCategoryScreen.Margin = new Padding(4);
            btnCategoryScreen.Name = "btnCategoryScreen";
            btnCategoryScreen.Size = new Size(200, 67);
            btnCategoryScreen.TabIndex = 0;
            btnCategoryScreen.Text = "المجموعات";
            btnCategoryScreen.UseVisualStyleBackColor = false;
            btnCategoryScreen.Click += btnCategoryScreen_Click;
            // 
            // btnProductScreen
            // 
            btnProductScreen.BackColor = Color.Snow;
            btnProductScreen.Location = new Point(454, 185);
            btnProductScreen.Margin = new Padding(4);
            btnProductScreen.Name = "btnProductScreen";
            btnProductScreen.Size = new Size(198, 67);
            btnProductScreen.TabIndex = 1;
            btnProductScreen.Text = "المنتجات";
            btnProductScreen.UseVisualStyleBackColor = false;
            btnProductScreen.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Location = new Point(730, 185);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(198, 67);
            button1.TabIndex = 2;
            button1.Text = "العملاء";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Location = new Point(168, 341);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(198, 67);
            button2.TabIndex = 3;
            button2.Text = "الفاتورة";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Snow;
            button3.Location = new Point(454, 341);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(198, 67);
            button3.TabIndex = 4;
            button3.Text = "الخزنة";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.Location = new Point(730, 341);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(198, 67);
            button4.TabIndex = 5;
            button4.Text = "تقارير المبيعات";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1100, 562);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnProductScreen);
            Controls.Add(btnCategoryScreen);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الشاشه الرئسية";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategoryScreen;
        private Button btnProductScreen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}