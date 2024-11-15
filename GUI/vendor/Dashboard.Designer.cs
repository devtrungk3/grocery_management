namespace GUI.vendor
{
    partial class Dashboard
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
            panel1 = new Panel();
            btnOrderManagement = new Button();
            btnAddOrder = new Button();
            panel2 = new Panel();
            uC_ManageOrder = new User_Control.UC_ManageOrder();
            uC_AddOrder = new User_Control.UC_AddOrder();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 118, 225);
            panel1.Controls.Add(btnOrderManagement);
            panel1.Controls.Add(btnAddOrder);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 637);
            panel1.TabIndex = 0;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.BackColor = Color.FromArgb(0, 118, 225);
            btnOrderManagement.Cursor = Cursors.Hand;
            btnOrderManagement.FlatAppearance.BorderSize = 0;
            btnOrderManagement.FlatStyle = FlatStyle.Flat;
            btnOrderManagement.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrderManagement.ForeColor = Color.White;
            btnOrderManagement.Location = new Point(3, 154);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(261, 55);
            btnOrderManagement.TabIndex = 1;
            btnOrderManagement.Text = "Quản lí đơn hàng";
            btnOrderManagement.UseVisualStyleBackColor = false;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.FromArgb(0, 118, 225);
            btnAddOrder.Cursor = Cursors.Hand;
            btnAddOrder.FlatAppearance.BorderSize = 0;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(3, 73);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(261, 55);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "Đặt hàng";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(uC_ManageOrder);
            panel2.Controls.Add(uC_AddOrder);
            panel2.Location = new Point(282, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(881, 637);
            panel2.TabIndex = 1;
            // 
            // uC_ManageOrder
            // 
            uC_ManageOrder.Location = new Point(0, 0);
            uC_ManageOrder.Name = "uC_ManageOrder";
            uC_ManageOrder.Size = new Size(1101, 796);
            uC_ManageOrder.TabIndex = 2;
            // 
            // uC_AddOrder
            // 
            uC_AddOrder.BackColor = Color.White;
            uC_AddOrder.Location = new Point(0, 0);
            uC_AddOrder.Name = "uC_AddOrder";
            uC_AddOrder.Size = new Size(881, 637);
            uC_AddOrder.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1175, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnOrderManagement;
        private Button btnAddOrder;
        private User_Control.UC_AddOrder uC_AddOrder;
        private User_Control.UC_ManageOrder uC_ManageOrder;
    }
}