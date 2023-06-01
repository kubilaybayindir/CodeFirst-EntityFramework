namespace _3_CodeFirst_EntityFramework
{
    partial class FormManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCustomers));
            this.label3 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.LbxCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.LblCustomerQantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.BtRefreshCustomer = new System.Windows.Forms.Button();
            this.BtAddCustomer = new System.Windows.Forms.Button();
            this.BtSaveCustomer = new System.Windows.Forms.Button();
            this.BtDeleteCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(221, 73);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(166, 23);
            this.TbxName.TabIndex = 26;
            // 
            // LbxCustomers
            // 
            this.LbxCustomers.FormattingEnabled = true;
            this.LbxCustomers.ItemHeight = 15;
            this.LbxCustomers.Location = new System.Drawing.Point(10, 54);
            this.LbxCustomers.Name = "LbxCustomers";
            this.LbxCustomers.Size = new System.Drawing.Size(206, 289);
            this.LbxCustomers.TabIndex = 25;
            this.LbxCustomers.SelectedIndexChanged += new System.EventHandler(this.LbxCustomers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Surname";
            // 
            // TbxSurname
            // 
            this.TbxSurname.Location = new System.Drawing.Point(221, 150);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(166, 23);
            this.TbxSurname.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "E-mail";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(221, 221);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(166, 23);
            this.TbxEmail.TabIndex = 30;
            // 
            // LblCustomerQantity
            // 
            this.LblCustomerQantity.AutoSize = true;
            this.LblCustomerQantity.Location = new System.Drawing.Point(118, 361);
            this.LblCustomerQantity.Name = "LblCustomerQantity";
            this.LblCustomerQantity.Size = new System.Drawing.Size(13, 15);
            this.LblCustomerQantity.TabIndex = 33;
            this.LblCustomerQantity.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Customer Qantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Phone";
            // 
            // MtbxPhone
            // 
            this.MtbxPhone.Location = new System.Drawing.Point(221, 296);
            this.MtbxPhone.Mask = "(999) 000-0000";
            this.MtbxPhone.Name = "MtbxPhone";
            this.MtbxPhone.Size = new System.Drawing.Size(166, 23);
            this.MtbxPhone.TabIndex = 35;
            // 
            // BtRefreshCustomer
            // 
            this.BtRefreshCustomer.Image = ((System.Drawing.Image)(resources.GetObject("BtRefreshCustomer.Image")));
            this.BtRefreshCustomer.Location = new System.Drawing.Point(10, 10);
            this.BtRefreshCustomer.Name = "BtRefreshCustomer";
            this.BtRefreshCustomer.Size = new System.Drawing.Size(28, 22);
            this.BtRefreshCustomer.TabIndex = 36;
            this.BtRefreshCustomer.UseVisualStyleBackColor = true;
            this.BtRefreshCustomer.Click += new System.EventHandler(this.BtRefreshCustomer_Click);
            // 
            // BtAddCustomer
            // 
            this.BtAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("BtAddCustomer.Image")));
            this.BtAddCustomer.Location = new System.Drawing.Point(41, 10);
            this.BtAddCustomer.Name = "BtAddCustomer";
            this.BtAddCustomer.Size = new System.Drawing.Size(28, 22);
            this.BtAddCustomer.TabIndex = 37;
            this.BtAddCustomer.UseVisualStyleBackColor = true;
            this.BtAddCustomer.Click += new System.EventHandler(this.BtAddCustomer_Click);
            // 
            // BtSaveCustomer
            // 
            this.BtSaveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("BtSaveCustomer.Image")));
            this.BtSaveCustomer.Location = new System.Drawing.Point(72, 10);
            this.BtSaveCustomer.Name = "BtSaveCustomer";
            this.BtSaveCustomer.Size = new System.Drawing.Size(28, 22);
            this.BtSaveCustomer.TabIndex = 38;
            this.BtSaveCustomer.UseVisualStyleBackColor = true;
            this.BtSaveCustomer.Click += new System.EventHandler(this.BtSaveCustomer_Click);
            // 
            // BtDeleteCustomer
            // 
            this.BtDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("BtDeleteCustomer.Image")));
            this.BtDeleteCustomer.Location = new System.Drawing.Point(103, 10);
            this.BtDeleteCustomer.Name = "BtDeleteCustomer";
            this.BtDeleteCustomer.Size = new System.Drawing.Size(28, 22);
            this.BtDeleteCustomer.TabIndex = 39;
            this.BtDeleteCustomer.UseVisualStyleBackColor = true;
            this.BtDeleteCustomer.Click += new System.EventHandler(this.BtDeleteCustomer_Click);
            // 
            // FormManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 383);
            this.Controls.Add(this.BtDeleteCustomer);
            this.Controls.Add(this.BtSaveCustomer);
            this.Controls.Add(this.BtAddCustomer);
            this.Controls.Add(this.BtRefreshCustomer);
            this.Controls.Add(this.MtbxPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblCustomerQantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.LbxCustomers);
            this.Name = "FormManageCustomers";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.FormManageCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox TbxName;
        private ListBox LbxCustomers;
        private Label label1;
        private TextBox TbxSurname;
        private Label label2;
        private TextBox TbxEmail;
        private Label LblCustomerQantity;
        private Label label5;
        private Label label4;
        private MaskedTextBox MtbxPhone;
        private Button BtRefreshCustomer;
        private Button BtAddCustomer;
        private Button BtSaveCustomer;
        private Button BtDeleteCustomer;
    }
}