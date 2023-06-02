namespace _3_CodeFirst_EntityFramework
{
    partial class FormNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewOrder));
            this.LbxProducts = new System.Windows.Forms.ListBox();
            this.DgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.BtSaveAndClose = new System.Windows.Forms.Button();
            this.BtNewOrderr = new System.Windows.Forms.Button();
            this.BtGoCategoryManagerPage = new System.Windows.Forms.Button();
            this.CbxCategories = new System.Windows.Forms.ComboBox();
            this.TbxOrderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtRemoveProductFromOrder = new System.Windows.Forms.Button();
            this.BtAddProductToOrder = new System.Windows.Forms.Button();
            this.DtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxCustomers = new System.Windows.Forms.ComboBox();
            this.BtGoCustomerManagerPage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblOrderUnitQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // LbxProducts
            // 
            this.LbxProducts.FormattingEnabled = true;
            this.LbxProducts.ItemHeight = 15;
            this.LbxProducts.Location = new System.Drawing.Point(12, 120);
            this.LbxProducts.Name = "LbxProducts";
            this.LbxProducts.Size = new System.Drawing.Size(247, 274);
            this.LbxProducts.TabIndex = 4;
            // 
            // DgvOrderDetails
            // 
            this.DgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderDetails.Location = new System.Drawing.Point(268, 120);
            this.DgvOrderDetails.Name = "DgvOrderDetails";
            this.DgvOrderDetails.RowTemplate.Height = 25;
            this.DgvOrderDetails.Size = new System.Drawing.Size(520, 274);
            this.DgvOrderDetails.TabIndex = 3;
            // 
            // BtSaveAndClose
            // 
            this.BtSaveAndClose.Image = ((System.Drawing.Image)(resources.GetObject("BtSaveAndClose.Image")));
            this.BtSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSaveAndClose.Location = new System.Drawing.Point(113, 1);
            this.BtSaveAndClose.Name = "BtSaveAndClose";
            this.BtSaveAndClose.Size = new System.Drawing.Size(112, 29);
            this.BtSaveAndClose.TabIndex = 11;
            this.BtSaveAndClose.Text = " Save And Close";
            this.BtSaveAndClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSaveAndClose.UseVisualStyleBackColor = true;
            this.BtSaveAndClose.Click += new System.EventHandler(this.BtSaveAndClose_Click);
            // 
            // BtNewOrderr
            // 
            this.BtNewOrderr.Image = ((System.Drawing.Image)(resources.GetObject("BtNewOrderr.Image")));
            this.BtNewOrderr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtNewOrderr.Location = new System.Drawing.Point(12, 1);
            this.BtNewOrderr.Name = "BtNewOrderr";
            this.BtNewOrderr.Size = new System.Drawing.Size(89, 29);
            this.BtNewOrderr.TabIndex = 10;
            this.BtNewOrderr.Text = "New Order";
            this.BtNewOrderr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtNewOrderr.UseVisualStyleBackColor = true;
            this.BtNewOrderr.Click += new System.EventHandler(this.BtNewOrderr_Click);
            // 
            // BtGoCategoryManagerPage
            // 
            this.BtGoCategoryManagerPage.Image = ((System.Drawing.Image)(resources.GetObject("BtGoCategoryManagerPage.Image")));
            this.BtGoCategoryManagerPage.Location = new System.Drawing.Point(231, 90);
            this.BtGoCategoryManagerPage.Name = "BtGoCategoryManagerPage";
            this.BtGoCategoryManagerPage.Size = new System.Drawing.Size(28, 24);
            this.BtGoCategoryManagerPage.TabIndex = 12;
            this.BtGoCategoryManagerPage.UseVisualStyleBackColor = true;
            this.BtGoCategoryManagerPage.Click += new System.EventHandler(this.BtGoCategoryManagerPage_Click);
            // 
            // CbxCategories
            // 
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.Location = new System.Drawing.Point(100, 91);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(121, 23);
            this.CbxCategories.TabIndex = 13;
            this.CbxCategories.SelectedIndexChanged += new System.EventHandler(this.CbxCategories_SelectedIndexChanged);
            // 
            // TbxOrderName
            // 
            this.TbxOrderName.Location = new System.Drawing.Point(96, 56);
            this.TbxOrderName.Name = "TbxOrderName";
            this.TbxOrderName.Size = new System.Drawing.Size(163, 23);
            this.TbxOrderName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Order Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date :";
            // 
            // BtRemoveProductFromOrder
            // 
            this.BtRemoveProductFromOrder.Image = ((System.Drawing.Image)(resources.GetObject("BtRemoveProductFromOrder.Image")));
            this.BtRemoveProductFromOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRemoveProductFromOrder.Location = new System.Drawing.Point(388, 85);
            this.BtRemoveProductFromOrder.Name = "BtRemoveProductFromOrder";
            this.BtRemoveProductFromOrder.Size = new System.Drawing.Size(115, 29);
            this.BtRemoveProductFromOrder.TabIndex = 24;
            this.BtRemoveProductFromOrder.Text = "Remove Product";
            this.BtRemoveProductFromOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtRemoveProductFromOrder.UseVisualStyleBackColor = true;
            this.BtRemoveProductFromOrder.Click += new System.EventHandler(this.BtRemoveProductFromOrder_Click);
            // 
            // BtAddProductToOrder
            // 
            this.BtAddProductToOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtAddProductToOrder.Image = ((System.Drawing.Image)(resources.GetObject("BtAddProductToOrder.Image")));
            this.BtAddProductToOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAddProductToOrder.Location = new System.Drawing.Point(268, 85);
            this.BtAddProductToOrder.Name = "BtAddProductToOrder";
            this.BtAddProductToOrder.Size = new System.Drawing.Size(96, 29);
            this.BtAddProductToOrder.TabIndex = 23;
            this.BtAddProductToOrder.Text = "Add Product";
            this.BtAddProductToOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddProductToOrder.UseVisualStyleBackColor = true;
            this.BtAddProductToOrder.Click += new System.EventHandler(this.BtAddProductToOrder_Click);
            // 
            // DtpOrderDate
            // 
            this.DtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpOrderDate.Location = new System.Drawing.Point(336, 56);
            this.DtpOrderDate.Name = "DtpOrderDate";
            this.DtpOrderDate.Size = new System.Drawing.Size(140, 23);
            this.DtpOrderDate.TabIndex = 25;
            this.DtpOrderDate.Value = new System.DateTime(2023, 5, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Customers :";
            // 
            // CbxCustomers
            // 
            this.CbxCustomers.FormattingEnabled = true;
            this.CbxCustomers.Location = new System.Drawing.Point(587, 56);
            this.CbxCustomers.Name = "CbxCustomers";
            this.CbxCustomers.Size = new System.Drawing.Size(141, 23);
            this.CbxCustomers.TabIndex = 26;
            // 
            // BtGoCustomerManagerPage
            // 
            this.BtGoCustomerManagerPage.Image = ((System.Drawing.Image)(resources.GetObject("BtGoCustomerManagerPage.Image")));
            this.BtGoCustomerManagerPage.Location = new System.Drawing.Point(746, 56);
            this.BtGoCustomerManagerPage.Name = "BtGoCustomerManagerPage";
            this.BtGoCustomerManagerPage.Size = new System.Drawing.Size(28, 26);
            this.BtGoCustomerManagerPage.TabIndex = 28;
            this.BtGoCustomerManagerPage.UseVisualStyleBackColor = true;
            this.BtGoCustomerManagerPage.Click += new System.EventHandler(this.BtGoCustomerManagerPage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Order Unit Qantity:";
            // 
            // LblOrderUnitQuantity
            // 
            this.LblOrderUnitQuantity.AutoSize = true;
            this.LblOrderUnitQuantity.Location = new System.Drawing.Point(118, 399);
            this.LblOrderUnitQuantity.Name = "LblOrderUnitQuantity";
            this.LblOrderUnitQuantity.Size = new System.Drawing.Size(13, 15);
            this.LblOrderUnitQuantity.TabIndex = 30;
            this.LblOrderUnitQuantity.Text = "0";
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.LblOrderUnitQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtGoCustomerManagerPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxCustomers);
            this.Controls.Add(this.DtpOrderDate);
            this.Controls.Add(this.BtRemoveProductFromOrder);
            this.Controls.Add(this.BtAddProductToOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxOrderName);
            this.Controls.Add(this.CbxCategories);
            this.Controls.Add(this.BtGoCategoryManagerPage);
            this.Controls.Add(this.BtSaveAndClose);
            this.Controls.Add(this.BtNewOrderr);
            this.Controls.Add(this.LbxProducts);
            this.Controls.Add(this.DgvOrderDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewOrder";
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.FormNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LbxProducts;
        private DataGridView DgvOrderDetails;
        private Button BtSaveAndClose;
        private Button BtNewOrderr;
        private Button BtGoCategoryManagerPage;
        private ComboBox CbxCategories;
        private TextBox TbxOrderName;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button BtRemoveProductFromOrder;
        private Button BtAddProductToOrder;
        private DateTimePicker DtpOrderDate;
        private Label label4;
        private ComboBox CbxCustomers;
        private Button BtGoCustomerManagerPage;
        private Label label5;
        private Label LblOrderUnitQuantity;
    }
}