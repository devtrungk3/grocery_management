namespace GUI.vendor.User_Control
{
    partial class UC_ManageOrder
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
            dtpCreateOrder = new DateTimePicker();
            label7 = new Label();
            dgvOrderList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnRightPagination = new Button();
            btnLeftPagination = new Button();
            lbPagination = new Label();
            dgvOrderDetail = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono ExtraBold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 118, 225);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(272, 37);
            label1.TabIndex = 3;
            label1.Text = "Quản lý hóa đơn";
            // 
            // dtpCreateOrder
            // 
            dtpCreateOrder.CalendarFont = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpCreateOrder.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpCreateOrder.Location = new Point(15, 156);
            dtpCreateOrder.Name = "dtpCreateOrder";
            dtpCreateOrder.Size = new Size(316, 30);
            dtpCreateOrder.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 127);
            label7.Name = "label7";
            label7.Size = new Size(120, 26);
            label7.TabIndex = 14;
            label7.Text = "Ngày xuất";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvOrderList.Location = new Point(337, 127);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.Size = new Size(541, 214);
            dgvOrderList.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngày xuất";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Thành tiền";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 165;
            // 
            // btnRightPagination
            // 
            btnRightPagination.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRightPagination.Location = new Point(643, 347);
            btnRightPagination.Name = "btnRightPagination";
            btnRightPagination.Size = new Size(36, 34);
            btnRightPagination.TabIndex = 17;
            btnRightPagination.Text = "→";
            btnRightPagination.UseVisualStyleBackColor = true;
            // 
            // btnLeftPagination
            // 
            btnLeftPagination.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLeftPagination.Location = new Point(543, 347);
            btnLeftPagination.Name = "btnLeftPagination";
            btnLeftPagination.Size = new Size(36, 34);
            btnLeftPagination.TabIndex = 18;
            btnLeftPagination.Text = "←";
            btnLeftPagination.UseVisualStyleBackColor = true;
            // 
            // lbPagination
            // 
            lbPagination.AutoSize = true;
            lbPagination.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPagination.Location = new Point(599, 351);
            lbPagination.Name = "lbPagination";
            lbPagination.Size = new Size(24, 26);
            lbPagination.TabIndex = 19;
            lbPagination.Text = "0";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column5, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column4 });
            dgvOrderDetail.Location = new Point(3, 409);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(875, 225);
            dgvOrderDetail.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "Đơn vị";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 195;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(337, 98);
            label3.Name = "label3";
            label3.Size = new Size(216, 26);
            label3.TabIndex = 21;
            label3.Text = "Danh sách hóa đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 380);
            label4.Name = "label4";
            label4.Size = new Size(204, 26);
            label4.TabIndex = 22;
            label4.Text = "Chi tiết hóa đơn";
            // 
            // UC_ManageOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvOrderDetail);
            Controls.Add(lbPagination);
            Controls.Add(btnLeftPagination);
            Controls.Add(btnRightPagination);
            Controls.Add(dgvOrderList);
            Controls.Add(label7);
            Controls.Add(dtpCreateOrder);
            Controls.Add(label1);
            Name = "UC_ManageOrder";
            Size = new Size(881, 637);
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dtpCreateOrder;
        private Label label7;
        private DataGridView dgvOrderList;
        private Button btnRightPagination;
        private Button btnLeftPagination;
        private Label lbPagination;
        private DataGridView dgvOrderDetail;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label3;
        private Label label4;
    }
}
