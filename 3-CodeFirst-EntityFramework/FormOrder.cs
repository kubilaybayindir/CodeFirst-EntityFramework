using _3_CodeFirst_EntityFramework.Models;
using static _3_CodeFirst_EntityFramework.Models.Order;

namespace _3_CodeFirst_EntityFramework
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            CbxCustomers.DataSource = null;
            CbxCustomers.DataSource = ContextHelper.db.Customers.ToList();
            CbxCustomers.DisplayMember = "FullName";
            CbxCustomers.ValueMember = "Id";
        }
        private void LoadAllOrders()
        {
            LbxOrders.DataSource = null;
            LbxOrders.DataSource = ContextHelper.db.Orders.ToList();
            LbxOrders.DisplayMember = "OrderInfo";
            LbxOrders.ValueMember = "Id";
        }
        private void LoadOrderByCustomerAndState()
        {
            LbxOrders.DataSource = null;

            if (CbxCustomers.SelectedIndex > -1)
            {
                Customer? customer = CbxCustomers.SelectedItem as Customer;
                OrderState stateFilter = CbxOrderState.SelectedIndex == -1 
                    ? OrderState.All 
                    : (OrderState)((KeyValuePair<int, string>)CbxOrderState.SelectedItem).Key;

                List<Order> orders;

                if (stateFilter == OrderState.All)
                {
                    orders = customer.Orders;
                }
                else
                {
                    orders=customer.Orders.Where(x => x.State == stateFilter).ToList();
                }

                LbxOrders.DataSource = null;
                LbxOrders.DataSource = orders;
                LbxOrders.DisplayMember = "OrderInfo";
                LbxOrders.ValueMember = "Id";
            }
        }
        private void LoadOrderStates()
        {
            List<KeyValuePair<int, string>> orderStates = new List<KeyValuePair<int, string>>();
            orderStates.Add(new KeyValuePair<int, string>((int)OrderState.All, "All"));
            orderStates.Add(new KeyValuePair<int, string>((int)OrderState.Reserved, "Reserved"));
            orderStates.Add(new KeyValuePair<int, string>((int)OrderState.Shipped, "Shipped"));
            orderStates.Add(new KeyValuePair<int, string>((int)OrderState.Delivered, "Delivered"));

            CbxOrderState.DataSource = null;
            CbxOrderState.DataSource = orderStates;
            CbxOrderState.DisplayMember = "Value";
            CbxOrderState.ValueMember = "Key";
        }
        private void CbxOrderState_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderByCustomerAndState();
        }
        #region  Page Button
        private void BtCategoriesProductsManager_Click(object sender, EventArgs e)
        {
            FormManageCategoriesProducts formManageCategoriesProducts = new FormManageCategoriesProducts();
            formManageCategoriesProducts.ShowDialog();
        }
        private void BtManageCustomers_Click(object sender, EventArgs e)
        {
            FormManageCustomers formManageCustomers = new FormManageCustomers();
            formManageCustomers.ShowDialog();

            LoadCustomers();

        }
        private void BtNewOrder_Click(object sender, EventArgs e)
        {
            FormNewOrder formNewOrder = new FormNewOrder();
            if (formNewOrder.ShowDialog() == DialogResult.OK)
            {
                LoadOrderByCustomerAndState();
            }
        }
        #endregion

        private void CbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderByCustomerAndState();  
            //LbxOrders.DataSource = null;
            //if (CbxCustomers.SelectedIndex >-1)
            //{
            //    Customer customer = CbxCustomers.SelectedItem as Customer;

            //    LbxOrders.DataSource = null;
            //    LbxOrders.DataSource = customer.Orders;
            //    LbxOrders.DisplayMember = "OrderInfo";
            //    LbxOrders.ValueMember = "Id";
            //}
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadOrderStates();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
        }
        private void UpdateOrderState(OrderState state)
        {
            if (LbxOrders.SelectedIndex > -1)
            {
                Order order = LbxOrders.SelectedItem as Order;

                order.State = state;

                if (ContextHelper.db.SaveChanges() > 0)
                {
                    LoadOrderByCustomerAndState();
                }
            }
        }
        private void OrderReserved_Click(object sender, EventArgs e)
        {
            UpdateOrderState(OrderState.Reserved);
        }
        private void OrderShipped_Click(object sender, EventArgs e)
        {
            UpdateOrderState(OrderState.Shipped);
        }
        private void OrderDelivered_Click(object sender, EventArgs e)
        {
            UpdateOrderState(OrderState.Delivered);
        }
    }
}