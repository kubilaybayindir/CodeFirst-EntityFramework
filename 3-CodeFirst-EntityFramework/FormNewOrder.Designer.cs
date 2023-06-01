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
            this.LbxOrders = new System.Windows.Forms.ListBox();
            this.DgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.BtSaveAndClose = new System.Windows.Forms.Button();
            this.BtNewOrderr = new System.Windows.Forms.Button();
            this.BtGoCategoryManagerPage = new System.Windows.Forms.Button();
            this.CbxOrderState = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtGoCustomerManagerPage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // LbxOrders
            // 
            this.LbxOrders.FormattingEnabled = true;
            this.LbxOrders.ItemHeight = 15;
            this.LbxOrders.Location = new System.Drawing.Point(12, 120);
            this.LbxOrders.Name = "LbxOrders";
            this.LbxOrders.Size = new System.Drawing.Size(247, 274);
            this.LbxOrders.TabIndex = 4;
            // 
            // DgvOrderDetails
            // 
            this.DgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderDetails.Location = new System.Drawing.Point(294, 120);
            this.DgvOrderDetails.Name = "DgvOrderDetails";
            this.DgvOrderDetails.RowTemplate.Height = 25;
            this.DgvOrderDetails.Size = new System.Drawing.Size(494, 274);
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
            // CbxOrderState
            // 
            this.CbxOrderState.FormattingEnabled = true;
            this.CbxOrderState.Location = new System.Drawing.Point(100, 91);
            this.CbxOrderState.Name = "CbxOrderState";
            this.CbxOrderState.Size = new System.Drawing.Size(121, 23);
            this.CbxOrderState.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 19;
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
            this.label3.Location = new System.Drawing.Point(303, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date :";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(414, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Remove Product";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(294, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add Product";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 23);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 30, 0, 0, 0, 0);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(587, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 23);
            this.comboBox1.TabIndex = 26;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "0";
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtGoCustomerManagerPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CbxOrderState);
            this.Controls.Add(this.BtGoCategoryManagerPage);
            this.Controls.Add(this.BtSaveAndClose);
            this.Controls.Add(this.BtNewOrderr);
            this.Controls.Add(this.LbxOrders);
            this.Controls.Add(this.DgvOrderDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewOrder";
            this.Text = "New Order";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LbxOrders;
        private DataGridView DgvOrderDetails;
        private Button BtSaveAndClose;
        private Button BtNewOrderr;
        private Button BtGoCategoryManagerPage;
        private ComboBox CbxOrderState;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox1;
        private Button BtGoCustomerManagerPage;
        private Label label5;
        private Label label6;
    }
}