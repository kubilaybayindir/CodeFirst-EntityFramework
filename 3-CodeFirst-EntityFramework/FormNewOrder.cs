using _3_CodeFirst_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _3_CodeFirst_EntityFramework.Models.Order;

namespace _3_CodeFirst_EntityFramework
{
    public partial class FormNewOrder : Form
    {
        public FormNewOrder()
        {
            InitializeComponent();
        }
        List<Product> _orderProducts;
        private void BtGoCustomerManagerPage_Click(object sender, EventArgs e)
        {
            FormManageCustomers formManageCustomers = new FormManageCustomers();
            formManageCustomers.ShowDialog();

            int selectedIndex = CbxCustomers.SelectedIndex;
            LoadCustomers();

            if (CbxCustomers.Items.Count > selectedIndex) 
            {
                CbxCustomers.SelectedIndex = selectedIndex;
            }
        }
        private void BtGoCategoryManagerPage_Click(object sender, EventArgs e)
        {
            FormManageCategoriesProducts formManageCategoriesProducts = new FormManageCategoriesProducts();
            formManageCategoriesProducts.ShowDialog();

            int selectedIndex = CbxCategories.SelectedIndex;
            LoadCategories();

            if (CbxCategories.Items.Count > selectedIndex)
            {
                CbxCategories.SelectedIndex = selectedIndex;
            }
        }
        private void LoadCustomers()
        {
            CbxCustomers.DataSource = null;
            CbxCustomers.DataSource = ContextHelper.db.Customers.ToList();
            CbxCustomers.DisplayMember = "FullName";
            CbxCustomers.ValueMember = "Id";
        }
        private void LoadCategories()
        {
            CbxCategories.DataSource = null;
            CbxCategories.DataSource = ContextHelper.db.Categories.ToList();
            CbxCategories.DisplayMember = "Name";
            CbxCategories.ValueMember = "Id";
        }
        private void LoadProducts()
        {

            LbxProducts.DataSource = null;

            if (CbxCategories.SelectedIndex > -1)
            {
                Category category = CbxCategories.SelectedItem as Category;

                LbxProducts.DataSource = null;
                LbxProducts.DataSource = category.Products;
                LbxProducts.DisplayMember = "Name";
                LbxProducts.ValueMember = "Id";
            }
        }
        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCategories();
            
            _orderProducts = new List<Product>();
        }
        private void CbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadOrderItemsDgv()
        {
            DgvOrderDetails.DataSource = null;
            DgvOrderDetails.DataSource = _orderProducts;
            //Görünmesini istemediğimiz sütunları gizleme
            DgvOrderDetails.Columns["Id"].Visible = false;
            DgvOrderDetails.Columns["CategoryId"].Visible = false;
            DgvOrderDetails.Columns["Category"].Visible = false;

            //Sütun adı değiştirme
            DgvOrderDetails.Columns["Name"].HeaderText ="Ürün Adı";
            DgvOrderDetails.Columns["Description"].HeaderText = "Açıklama";
            DgvOrderDetails.Columns["UnitPrice"].HeaderText = "Birim Fiyat";
            DgvOrderDetails.Columns["Stock"].HeaderText = "Stok";
            DgvOrderDetails.Columns["IsSale"].HeaderText = "Satışta";
        }
        private void BtAddProductToOrder_Click(object sender, EventArgs e)
        {
            if (LbxProducts.SelectedIndex > -1)
            {
                Product product = LbxProducts.SelectedItem as Product;

                _orderProducts.Add(product);

                LoadOrderItemsDgv();

            }
        }
        private void BtRemoveProductFromOrder_Click(object sender, EventArgs e)
        {
            if (DgvOrderDetails.SelectedRows != null && DgvOrderDetails.SelectedRows.Count > 0 )
            {
                Product selectedProduct = DgvOrderDetails.SelectedRows[0].DataBoundItem as Product;

                _orderProducts.Remove(selectedProduct);
                LoadOrderItemsDgv();
            }
        }

        private void BtNewOrderr_Click(object sender, EventArgs e)
        {
            _orderProducts = new List<Product>();
        }

        private void BtSaveAndClose_Click(object sender, EventArgs e)
        {
            if (Validator.IsNullOrEmpty(TbxOrderName, "Order Name")) return;

            if (CbxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Choose A Customer","Attention Please",MessageBoxButtons.OK,MessageBoxIcon.None);
                return;
            }
            if (_orderProducts.Count == 0)
            {
                MessageBox.Show("Choose A Product For Order", "Attention Please", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            string orderName = TbxOrderName.Text;
            DateTime orderDate = DtpOrderDate.Value.Date;
            Customer customer = CbxCustomers.SelectedItem as Customer;

            Order order = new Order
            {
                Name=orderName,
                OrderDate=orderDate,
                State=OrderState.Reserved,
                Products = _orderProducts,
                CustomerId=customer.Id
            };

            ContextHelper.db.Orders.Add(order);

            if (ContextHelper.db.SaveChanges() > 0)
            {
                MessageBox.Show("Your order has been created successfully.","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
