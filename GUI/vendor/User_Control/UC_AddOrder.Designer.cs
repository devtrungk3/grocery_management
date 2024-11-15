namespace GUI.vendor.User_Control
{
    partial class UC_AddOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDeleteProduct = new Button();
            label6 = new Label();
            cbProductDefaultUnit = new ComboBox();
            txtProductQuantity = new NumericUpDown();
            btnAddProduct = new Button();
            label5 = new Label();
            txtProductTotalPrice = new TextBox();
            label4 = new Label();
            txtProductUnitPrice = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            dgvProductList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtProductID = new TextBox();
            label7 = new Label();
            btnShowProduct = new Button();
            groupBox2 = new GroupBox();
            btnAddOrder = new Button();
            txtTotalAmount = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtProductQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono ExtraBold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 118, 225);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 0;
            label1.Text = "Đặt hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteProduct);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbProductDefaultUnit);
            groupBox1.Controls.Add(txtProductQuantity);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtProductTotalPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtProductUnitPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(292, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 316);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(0, 118, 225);
            btnDeleteProduct.Cursor = Cursors.Hand;
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(446, 239);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(99, 55);
            btnDeleteProduct.TabIndex = 12;
            btnDeleteProduct.Text = "Xóa";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 231);
            label6.Name = "label6";
            label6.Size = new Size(84, 26);
            label6.TabIndex = 11;
            label6.Text = "Đơn vị";
            // 
            // cbProductDefaultUnit
            // 
            cbProductDefaultUnit.FormattingEnabled = true;
            cbProductDefaultUnit.Location = new Point(36, 260);
            cbProductDefaultUnit.Name = "cbProductDefaultUnit";
            cbProductDefaultUnit.Size = new Size(241, 34);
            cbProductDefaultUnit.TabIndex = 10;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(36, 162);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(241, 34);
            txtProductQuantity.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(0, 118, 225);
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(312, 239);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(104, 55);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 133);
            label5.Name = "label5";
            label5.Size = new Size(108, 26);
            label5.TabIndex = 6;
            label5.Text = "Số lượng";
            // 
            // txtProductTotalPrice
            // 
            txtProductTotalPrice.Cursor = Cursors.IBeam;
            txtProductTotalPrice.Location = new Point(312, 162);
            txtProductTotalPrice.Name = "txtProductTotalPrice";
            txtProductTotalPrice.ReadOnly = true;
            txtProductTotalPrice.Size = new Size(233, 34);
            txtProductTotalPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 133);
            label4.Name = "label4";
            label4.Size = new Size(60, 26);
            label4.TabIndex = 4;
            label4.Text = "Tổng";
            // 
            // txtProductUnitPrice
            // 
            txtProductUnitPrice.Cursor = Cursors.IBeam;
            txtProductUnitPrice.Location = new Point(312, 70);
            txtProductUnitPrice.Name = "txtProductUnitPrice";
            txtProductUnitPrice.ReadOnly = true;
            txtProductUnitPrice.Size = new Size(233, 34);
            txtProductUnitPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 41);
            label3.Name = "label3";
            label3.Size = new Size(96, 26);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá";
            // 
            // txtProductName
            // 
            txtProductName.Cursor = Cursors.IBeam;
            txtProductName.Location = new Point(36, 70);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(241, 34);
            txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 41);
            label2.Name = "label2";
            label2.Size = new Size(156, 26);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column3, Column4 });
            dgvProductList.Location = new Point(3, 409);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.Size = new Size(875, 225);
            dgvProductList.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "Đơn vị";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 195;
            // 
            // Column2
            // 
            Column2.HeaderText = "Đơn giá";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // txtProductID
            // 
            txtProductID.Cursor = Cursors.IBeam;
            txtProductID.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(18, 157);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(226, 34);
            txtProductID.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 128);
            label7.Name = "label7";
            label7.Size = new Size(144, 26);
            label7.TabIndex = 13;
            label7.Text = "Mã sản phẩm";
            // 
            // btnShowProduct
            // 
            btnShowProduct.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnShowProduct.Location = new Point(250, 157);
            btnShowProduct.Name = "btnShowProduct";
            btnShowProduct.Size = new Size(36, 34);
            btnShowProduct.TabIndex = 15;
            btnShowProduct.Text = "→";
            btnShowProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddOrder);
            groupBox2.Controls.Add(txtTotalAmount);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(18, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 206);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.FromArgb(0, 118, 225);
            btnAddOrder.Cursor = Cursors.Hand;
            btnAddOrder.FlatAppearance.BorderSize = 0;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(78, 129);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(104, 55);
            btnAddOrder.TabIndex = 13;
            btnAddOrder.Text = "Xuất";
            btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Cursor = Cursors.IBeam;
            txtTotalAmount.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(26, 71);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(222, 34);
            txtTotalAmount.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 42);
            label8.Name = "label8";
            label8.Size = new Size(156, 26);
            label8.TabIndex = 17;
            label8.Text = "Tổng hóa đơn";
            // 
            // UC_AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox2);
            Controls.Add(btnShowProduct);
            Controls.Add(txtProductID);
            Controls.Add(dgvProductList);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UC_AddOrder";
            Size = new Size(881, 637);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtProductQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtProductName;
        private Label label2;
        private Label label5;
        private TextBox txtProductTotalPrice;
        private Label label4;
        private TextBox txtProductUnitPrice;
        private Label label3;
        private Button btnAddProduct;
        private DataGridView dgvProductList;
        private NumericUpDown txtProductQuantity;
        private Button btnDeleteProduct;
        private Label label6;
        private ComboBox cbProductDefaultUnit;
        private TextBox txtProductID;
        private Label label7;
        private Button btnShowProduct;
        private GroupBox groupBox2;
        private TextBox txtTotalAmount;
        private Label label8;
        private Button btnAddOrder;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
