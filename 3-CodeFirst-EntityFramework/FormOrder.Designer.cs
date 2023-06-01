namespace _3_CodeFirst_EntityFramework
{
    partial class FormOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.BtManageCustomers = new System.Windows.Forms.Button();
            this.DgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.LbxOrders = new System.Windows.Forms.ListBox();
            this.CbxCustomers = new System.Windows.Forms.ComboBox();
            this.CbxOrderState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtNewOrder = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtCategoriesProductsManager = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // BtManageCustomers
            // 
            this.BtManageCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BtManageCustomers.Image")));
            this.BtManageCustomers.Location = new System.Drawing.Point(227, 60);
            this.BtManageCustomers.Name = "BtManageCustomers";
            this.BtManageCustomers.Size = new System.Drawing.Size(32, 23);
            this.BtManageCustomers.TabIndex = 0;
            this.BtManageCustomers.UseVisualStyleBackColor = true;
            this.BtManageCustomers.Click += new System.EventHandler(this.BtManageCustomers_Click);
            // 
            // DgvOrderDetails
            // 
            this.DgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderDetails.Location = new System.Drawing.Point(265, 60);
            this.DgvOrderDetails.Name = "DgvOrderDetails";
            this.DgvOrderDetails.RowTemplate.Height = 25;
            this.DgvOrderDetails.Size = new System.Drawing.Size(523, 330);
            this.DgvOrderDetails.TabIndex = 1;
            // 
            // LbxOrders
            // 
            this.LbxOrders.FormattingEnabled = true;
            this.LbxOrders.ItemHeight = 15;
            this.LbxOrders.Location = new System.Drawing.Point(12, 131);
            this.LbxOrders.Name = "LbxOrders";
            this.LbxOrders.Size = new System.Drawing.Size(247, 259);
            this.LbxOrders.TabIndex = 2;
            // 
            // CbxCustomers
            // 
            this.CbxCustomers.FormattingEnabled = true;
            this.CbxCustomers.Location = new System.Drawing.Point(14, 60);
            this.CbxCustomers.Name = "CbxCustomers";
            this.CbxCustomers.Size = new System.Drawing.Size(201, 23);
            this.CbxCustomers.TabIndex = 3;
            this.CbxCustomers.SelectedIndexChanged += new System.EventHandler(this.CbxCustomers_SelectedIndexChanged);
            // 
            // CbxOrderState
            // 
            this.CbxOrderState.FormattingEnabled = true;
            this.CbxOrderState.Location = new System.Drawing.Point(138, 102);
            this.CbxOrderState.Name = "CbxOrderState";
            this.CbxOrderState.Size = new System.Drawing.Size(121, 23);
            this.CbxOrderState.TabIndex = 4;
            this.CbxOrderState.SelectedIndexChanged += new System.EventHandler(this.CbxOrderState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "State:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customers:";
            // 
            // BtNewOrder
            // 
            this.BtNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("BtNewOrder.Image")));
            this.BtNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtNewOrder.Location = new System.Drawing.Point(12, 3);
            this.BtNewOrder.Name = "BtNewOrder";
            this.BtNewOrder.Size = new System.Drawing.Size(92, 29);
            this.BtNewOrder.TabIndex = 8;
            this.BtNewOrder.Text = " New Order";
            this.BtNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtNewOrder.UseVisualStyleBackColor = true;
            this.BtNewOrder.Click += new System.EventHandler(this.BtNewOrder_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(119, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "All Orders";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtCategoriesProductsManager
            // 
            this.BtCategoriesProductsManager.Image = ((System.Drawing.Image)(resources.GetObject("BtCategoriesProductsManager.Image")));
            this.BtCategoriesProductsManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCategoriesProductsManager.Location = new System.Drawing.Point(217, 3);
            this.BtCategoriesProductsManager.Name = "BtCategoriesProductsManager";
            this.BtCategoriesProductsManager.Size = new System.Drawing.Size(162, 29);
            this.BtCategoriesProductsManager.TabIndex = 10;
            this.BtCategoriesProductsManager.Text = "Categories And Products";
            this.BtCategoriesProductsManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtCategoriesProductsManager.UseVisualStyleBackColor = true;
            this.BtCategoriesProductsManager.Click += new System.EventHandler(this.BtCategoriesProductsManager_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Orders:";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtCategoriesProductsManager);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtNewOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxOrderState);
            this.Controls.Add(this.CbxCustomers);
            this.Controls.Add(this.LbxOrders);
            this.Controls.Add(this.DgvOrderDetails);
            this.Controls.Add(this.BtManageCustomers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrder";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtManageCustomers;
        private DataGridView DgvOrderDetails;
        private ListBox LbxOrders;
        private ComboBox CbxCustomers;
        private ComboBox CbxOrderState;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtNewOrder;
        private Button button3;
        private Button BtCategoriesProductsManager;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}