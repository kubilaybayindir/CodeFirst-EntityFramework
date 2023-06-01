using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_CodeFirst_EntityFramework
{
    public partial class FormNewOrder : Form
    {
        public FormNewOrder()
        {
            InitializeComponent();
        }

        private void BtGoCustomerManagerPage_Click(object sender, EventArgs e)
        {
            FormManageCustomers formManageCustomers = new FormManageCustomers();
            formManageCustomers.ShowDialog();
        }

        private void BtGoCategoryManagerPage_Click(object sender, EventArgs e)
        {
            FormManageCategoriesProducts formManageCategoriesProducts = new FormManageCategoriesProducts();
            formManageCategoriesProducts.ShowDialog();
        }
    }
}
