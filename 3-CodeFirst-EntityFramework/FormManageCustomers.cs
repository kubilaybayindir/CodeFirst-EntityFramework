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

namespace _3_CodeFirst_EntityFramework
{
    public partial class FormManageCustomers : Form
    {
        public FormManageCustomers()
        {
            InitializeComponent();
        }

        private void FormManageCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            LbxCustomers.DataSource = null;
            LbxCustomers.DataSource = ContextHelper.db.Customers.ToList();
            LbxCustomers.DisplayMember = "FullName";
            LbxCustomers.ValueMember = "Id";


            LblCustomerQantity.Text = LbxCustomers.Items.Count.ToString();
        }

        private void BtRefreshCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void BtAddCustomer_Click(object sender, EventArgs e)
        {
            if (Validator.IsNullOrEmpty(TbxName, "Customer Name")) return;
            if (Validator.IsNullOrEmpty(TbxSurname, "Customer Surname")) return;

            ContextHelper.db.Customers.Add(new Customer
            {
                FirstName = TbxName.Text,
                LastName = TbxSurname.Text,
                Email = TbxEmail.Text,
                Phone = MtbxPhone.Text
            });
            if (ContextHelper.db.SaveChanges() > 0)
            {
                LoadCustomers();
            }
        }
        private void BtSaveCustomer_Click(object sender, EventArgs e)
        {
            if (LbxCustomers.SelectedIndex > -1)
            {
                Customer customer = LbxCustomers.SelectedItem as Customer;

                customer.FirstName = TbxName.Text;
                customer.LastName = TbxSurname.Text;
                customer.Email = TbxEmail.Text;
                customer.Phone = MtbxPhone.Text;
                if (ContextHelper.db.SaveChanges() > 0)
                {
                    int selectedIndex = LbxCustomers.SelectedIndex;
                    LoadCustomers();
                    LbxCustomers.SelectedIndex = selectedIndex;
                }
            }
        }
        private void BtDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (LbxCustomers.SelectedIndex > -1)
            {
                Customer customer = LbxCustomers.SelectedItem as Customer;

                DialogResult dialogResult = MessageBox.Show($"Are You Sure About Deleting {customer.FullName} Customer ? ", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    ContextHelper.db.Customers.Remove(customer);

                    if (ContextHelper.db.SaveChanges() > 0)
                    {
                        LoadCustomers();
                    }
                }
            }
        }
        private void LbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbxName.Clear(); TbxSurname.Clear(); TbxEmail.Clear(); MtbxPhone.Clear();

            if (LbxCustomers.SelectedIndex > -1)
            {
                Customer customer = LbxCustomers.SelectedItem as Customer;

                TbxName.Text = customer.FirstName;
                TbxSurname.Text = customer.LastName;
                TbxEmail.Text = customer.Email;
                MtbxPhone.Text = customer.Phone;
            }
        }
    }
}
