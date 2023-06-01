namespace _3_CodeFirst_EntityFramework
{
    partial class FormManageCategoriesProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCategoriesProducts));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbxCategories = new System.Windows.Forms.ListBox();
            this.LbxProducts = new System.Windows.Forms.ListBox();
            this.TbxProductName = new System.Windows.Forms.TextBox();
            this.TbxCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NudProductUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.NudProductStock = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChkProductIsSale = new System.Windows.Forms.CheckBox();
            this.BtDeleteCategory = new System.Windows.Forms.Button();
            this.BtSaveCategory = new System.Windows.Forms.Button();
            this.BtAddCategory = new System.Windows.Forms.Button();
            this.BtRefreshCategory = new System.Windows.Forms.Button();
            this.BtDeleteProduct = new System.Windows.Forms.Button();
            this.BtSaveProduct = new System.Windows.Forms.Button();
            this.BtAddProduct = new System.Windows.Forms.Button();
            this.BtRefreshProduct = new System.Windows.Forms.Button();
            this.LblCategoryQantity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblProductQantity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TbxProductDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudProductUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Products";
            // 
            // LbxCategories
            // 
            this.LbxCategories.FormattingEnabled = true;
            this.LbxCategories.ItemHeight = 15;
            this.LbxCategories.Location = new System.Drawing.Point(12, 76);
            this.LbxCategories.Name = "LbxCategories";
            this.LbxCategories.Size = new System.Drawing.Size(268, 289);
            this.LbxCategories.TabIndex = 14;
            this.LbxCategories.SelectedIndexChanged += new System.EventHandler(this.LbxCategories_SelectedIndexChanged);
            // 
            // LbxProducts
            // 
            this.LbxProducts.FormattingEnabled = true;
            this.LbxProducts.ItemHeight = 15;
            this.LbxProducts.Location = new System.Drawing.Point(297, 76);
            this.LbxProducts.Name = "LbxProducts";
            this.LbxProducts.Size = new System.Drawing.Size(247, 334);
            this.LbxProducts.TabIndex = 17;
            this.LbxProducts.SelectedIndexChanged += new System.EventHandler(this.LbxProducts_SelectedIndexChanged);
            // 
            // TbxProductName
            // 
            this.TbxProductName.Location = new System.Drawing.Point(566, 90);
            this.TbxProductName.Name = "TbxProductName";
            this.TbxProductName.Size = new System.Drawing.Size(222, 23);
            this.TbxProductName.TabIndex = 18;
            // 
            // TbxCategoryName
            // 
            this.TbxCategoryName.Location = new System.Drawing.Point(106, 386);
            this.TbxCategoryName.Name = "TbxCategoryName";
            this.TbxCategoryName.Size = new System.Drawing.Size(174, 23);
            this.TbxCategoryName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category:";
            // 
            // NudProductUnitPrice
            // 
            this.NudProductUnitPrice.DecimalPlaces = 2;
            this.NudProductUnitPrice.Location = new System.Drawing.Point(566, 283);
            this.NudProductUnitPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudProductUnitPrice.Name = "NudProductUnitPrice";
            this.NudProductUnitPrice.Size = new System.Drawing.Size(222, 23);
            this.NudProductUnitPrice.TabIndex = 22;
            // 
            // NudProductStock
            // 
            this.NudProductStock.Location = new System.Drawing.Point(566, 339);
            this.NudProductStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudProductStock.Name = "NudProductStock";
            this.NudProductStock.Size = new System.Drawing.Size(222, 23);
            this.NudProductStock.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Stock Quantity";
            // 
            // ChkProductIsSale
            // 
            this.ChkProductIsSale.AutoSize = true;
            this.ChkProductIsSale.Location = new System.Drawing.Point(567, 388);
            this.ChkProductIsSale.Name = "ChkProductIsSale";
            this.ChkProductIsSale.Size = new System.Drawing.Size(58, 19);
            this.ChkProductIsSale.TabIndex = 28;
            this.ChkProductIsSale.Text = "Is Sale";
            this.ChkProductIsSale.UseVisualStyleBackColor = true;
            // 
            // BtDeleteCategory
            // 
            this.BtDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtDeleteCategory.Image")));
            this.BtDeleteCategory.Location = new System.Drawing.Point(106, 12);
            this.BtDeleteCategory.Name = "BtDeleteCategory";
            this.BtDeleteCategory.Size = new System.Drawing.Size(28, 22);
            this.BtDeleteCategory.TabIndex = 43;
            this.BtDeleteCategory.UseVisualStyleBackColor = true;
            this.BtDeleteCategory.Click += new System.EventHandler(this.BtDeleteCategory_Click);
            // 
            // BtSaveCategory
            // 
            this.BtSaveCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtSaveCategory.Image")));
            this.BtSaveCategory.Location = new System.Drawing.Point(75, 12);
            this.BtSaveCategory.Name = "BtSaveCategory";
            this.BtSaveCategory.Size = new System.Drawing.Size(28, 22);
            this.BtSaveCategory.TabIndex = 42;
            this.BtSaveCategory.UseVisualStyleBackColor = true;
            this.BtSaveCategory.Click += new System.EventHandler(this.BtSaveCategory_Click);
            // 
            // BtAddCategory
            // 
            this.BtAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtAddCategory.Image")));
            this.BtAddCategory.Location = new System.Drawing.Point(44, 12);
            this.BtAddCategory.Name = "BtAddCategory";
            this.BtAddCategory.Size = new System.Drawing.Size(28, 22);
            this.BtAddCategory.TabIndex = 41;
            this.BtAddCategory.UseVisualStyleBackColor = true;
            this.BtAddCategory.Click += new System.EventHandler(this.BtAddCategory_Click);
            // 
            // BtRefreshCategory
            // 
            this.BtRefreshCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtRefreshCategory.Image")));
            this.BtRefreshCategory.Location = new System.Drawing.Point(13, 12);
            this.BtRefreshCategory.Name = "BtRefreshCategory";
            this.BtRefreshCategory.Size = new System.Drawing.Size(28, 22);
            this.BtRefreshCategory.TabIndex = 40;
            this.BtRefreshCategory.UseVisualStyleBackColor = true;
            this.BtRefreshCategory.Click += new System.EventHandler(this.BtRefreshCategory_Click);
            // 
            // BtDeleteProduct
            // 
            this.BtDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtDeleteProduct.Image")));
            this.BtDeleteProduct.Location = new System.Drawing.Point(385, 12);
            this.BtDeleteProduct.Name = "BtDeleteProduct";
            this.BtDeleteProduct.Size = new System.Drawing.Size(28, 22);
            this.BtDeleteProduct.TabIndex = 47;
            this.BtDeleteProduct.UseVisualStyleBackColor = true;
            this.BtDeleteProduct.Click += new System.EventHandler(this.BtDeleteProduct_Click);
            // 
            // BtSaveProduct
            // 
            this.BtSaveProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtSaveProduct.Image")));
            this.BtSaveProduct.Location = new System.Drawing.Point(354, 12);
            this.BtSaveProduct.Name = "BtSaveProduct";
            this.BtSaveProduct.Size = new System.Drawing.Size(28, 22);
            this.BtSaveProduct.TabIndex = 46;
            this.BtSaveProduct.UseVisualStyleBackColor = true;
            this.BtSaveProduct.Click += new System.EventHandler(this.BtSaveProduct_Click);
            // 
            // BtAddProduct
            // 
            this.BtAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtAddProduct.Image")));
            this.BtAddProduct.Location = new System.Drawing.Point(323, 12);
            this.BtAddProduct.Name = "BtAddProduct";
            this.BtAddProduct.Size = new System.Drawing.Size(28, 22);
            this.BtAddProduct.TabIndex = 45;
            this.BtAddProduct.UseVisualStyleBackColor = true;
            this.BtAddProduct.Click += new System.EventHandler(this.BtAddProduct_Click);
            // 
            // BtRefreshProduct
            // 
            this.BtRefreshProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtRefreshProduct.Image")));
            this.BtRefreshProduct.Location = new System.Drawing.Point(292, 12);
            this.BtRefreshProduct.Name = "BtRefreshProduct";
            this.BtRefreshProduct.Size = new System.Drawing.Size(28, 22);
            this.BtRefreshProduct.TabIndex = 44;
            this.BtRefreshProduct.UseVisualStyleBackColor = true;
            this.BtRefreshProduct.Click += new System.EventHandler(this.BtRefreshProduct_Click);
            // 
            // LblCategoryQantity
            // 
            this.LblCategoryQantity.AutoSize = true;
            this.LblCategoryQantity.Location = new System.Drawing.Point(118, 416);
            this.LblCategoryQantity.Name = "LblCategoryQantity";
            this.LblCategoryQantity.Size = new System.Drawing.Size(13, 15);
            this.LblCategoryQantity.TabIndex = 49;
            this.LblCategoryQantity.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Category Qantity:";
            // 
            // LblProductQantity
            // 
            this.LblProductQantity.AutoSize = true;
            this.LblProductQantity.Location = new System.Drawing.Point(403, 416);
            this.LblProductQantity.Name = "LblProductQantity";
            this.LblProductQantity.Size = new System.Drawing.Size(13, 15);
            this.LblProductQantity.TabIndex = 51;
            this.LblProductQantity.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "Product Qantity:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TbxProductDesc);
            this.splitContainer1.Size = new System.Drawing.Size(800, 440);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 52;
            // 
            // TbxProductDesc
            // 
            this.TbxProductDesc.Location = new System.Drawing.Point(276, 149);
            this.TbxProductDesc.Multiline = true;
            this.TbxProductDesc.Name = "TbxProductDesc";
            this.TbxProductDesc.Size = new System.Drawing.Size(222, 100);
            this.TbxProductDesc.TabIndex = 53;
            // 
            // FormManageCategoriesProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.LblProductQantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblCategoryQantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtDeleteProduct);
            this.Controls.Add(this.BtSaveProduct);
            this.Controls.Add(this.BtAddProduct);
            this.Controls.Add(this.BtRefreshProduct);
            this.Controls.Add(this.BtDeleteCategory);
            this.Controls.Add(this.BtSaveCategory);
            this.Controls.Add(this.BtAddCategory);
            this.Controls.Add(this.BtRefreshCategory);
            this.Controls.Add(this.ChkProductIsSale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudProductStock);
            this.Controls.Add(this.NudProductUnitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxCategoryName);
            this.Controls.Add(this.TbxProductName);
            this.Controls.Add(this.LbxProducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbxCategories);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageCategoriesProducts";
            this.Text = "Manage Categories Products";
            this.Load += new System.EventHandler(this.FormManageCategoriesProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudProductUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProductStock)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label1;
        private ListBox LbxCategories;
        private ListBox LbxProducts;
        private TextBox TbxProductName;
        private TextBox TbxCategoryName;
        private Label label2;
        private NumericUpDown NudProductUnitPrice;
        private NumericUpDown NudProductStock;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private CheckBox ChkProductIsSale;
        private Button BtDeleteCategory;
        private Button BtSaveCategory;
        private Button BtAddCategory;
        private Button BtRefreshCategory;
        private Button BtDeleteProduct;
        private Button BtSaveProduct;
        private Button BtAddProduct;
        private Button BtRefreshProduct;
        private Label LblCategoryQantity;
        private Label label9;
        private Label LblProductQantity;
        private Label label11;
        private SplitContainer splitContainer1;
        private TextBox TbxProductDesc;
    }
}