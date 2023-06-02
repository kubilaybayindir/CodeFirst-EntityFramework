using _3_CodeFirst_EntityFramework.Models;
using Castle.Core.Resource;
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
    public partial class FormManageCategoriesProducts : Form
    {
        public FormManageCategoriesProducts()
        {
            InitializeComponent();
            splitContainer1.Cursor = Cursors.Default;
        }

        private void FormManageCategoriesProducts_Load(object sender, EventArgs e)
        {
            LoadCategories();

        }

        #region CATEGORY
        private void LoadCategories()
        {
            LbxCategories.DataSource = null;
            LbxCategories.DataSource = ContextHelper.db.Categories.ToList();
            LbxCategories.DisplayMember = "Name";
            LbxCategories.ValueMember = "Id";

            LblCategoryQantity.Text = LbxCategories.Items.Count.ToString();
        }
        private void BtRefreshCategory_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void BtAddCategory_Click(object sender, EventArgs e)
        {
            if (Validator.IsNullOrEmpty(TbxCategoryName, "Category Name")) return;
            ContextHelper.db.Categories.Add(new Category
            {
                Name = TbxCategoryName.Text,
            });

            if (ContextHelper.db.SaveChanges() > 0)
            {
                LoadCategories();
            }
        }
        private void BtSaveCategory_Click(object sender, EventArgs e)
        {
            if (LbxCategories.SelectedIndex > -1)
            {
                if (Validator.IsNullOrEmpty(TbxCategoryName, "Category Name")) return;
                Category category = LbxCategories.SelectedItem as Category;
                category.Name = TbxCategoryName.Text;

                if (ContextHelper.db.SaveChanges() > 0)
                {
                    int selectedIndex = LbxCategories.SelectedIndex;
                    LoadCategories();
                    LbxCategories.SelectedIndex = selectedIndex;
                }
            }
        }
        private void BtDeleteCategory_Click(object sender, EventArgs e)
        {
            if (LbxCategories.SelectedIndex > -1)
            {
                Category category = LbxCategories.SelectedItem as Category;
                DialogResult dialogResult;

                if (category.Products.Count > 0)
                {
                    dialogResult = MessageBox.Show($"There Is A Product In The {category.Name} Category.\r\nDeletion Will Cause These Products To Be Deleted.\r\nAre You Sure You Want To Delete {category.Name} Category ?", "Delete Category", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                }
                else
                {
                    dialogResult = MessageBox.Show($"Are You Sure About Deleting {category.Name} Category ? ", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }

                if (dialogResult == DialogResult.Yes)
                {
                    ContextHelper.db.Categories.Remove(category);

                    if (ContextHelper.db.SaveChanges() > 0)
                    {
                        LoadCategories();
                    }
                }
            }
        }
        private void LbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbxCategoryName.Clear();

            if (LbxCategories.SelectedIndex > -1)
            {
                Category category = LbxCategories.SelectedItem as Category;
                TbxCategoryName.Text = category.Name;
                TbxProductName.Clear();
                TbxProductDesc.Clear();
                NudProductUnitPrice.Value=0;
                NudProductStock.Value = 0;

            }
            LoadProducts();
        }
        #endregion

        #region PRODUCT
        private void LoadProducts()
        {

            LbxProducts.DataSource = null;

            if (LbxCategories.SelectedIndex > -1)
            {
                Category category = LbxCategories.SelectedItem as Category;

                LbxProducts.DataSource = null;
                LbxProducts.DataSource = category.Products;
                LbxProducts.DisplayMember = "Name";
                LbxProducts.ValueMember = "Id";

                LblProductQantity.Text = LbxProducts.Items.Count.ToString();
            }
        }
        private void BtRefreshProduct_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void BtAddProduct_Click(object sender, EventArgs e)
        {
            if (LbxCategories.SelectedIndex > -1)
            {
                Category category = LbxCategories.SelectedItem as Category;

                category.Products.Add(new Product
                {
                    Name = TbxProductName.Text,
                    Description = TbxProductDesc.Text,
                    UnitPrice = NudProductUnitPrice.Value,
                    Stock = (int)NudProductStock.Value,
                    IsSale = ChkProductIsSale.Checked
                });
                if (ContextHelper.db.SaveChanges() > 0)
                {
                    LoadProducts();
                }
            }
        }
        private void BtSaveProduct_Click(object sender, EventArgs e)
        {
            if (LbxProducts.SelectedIndex > -1)
            {
                Product product = LbxProducts.SelectedItem as Product;

                product.Name = TbxProductName.Text;
                product.Description = TbxProductDesc.Text;
                product.UnitPrice = NudProductUnitPrice.Value;
                product.Stock = (int)NudProductStock.Value;
                product.IsSale = ChkProductIsSale.Checked;
            }
            if (ContextHelper.db.SaveChanges() > 0)
            {
                int selectedIndex = LbxProducts.SelectedIndex;
                LoadProducts();
                LbxProducts.SelectedIndex = selectedIndex;
            }
        }
        private void BtDeleteProduct_Click(object sender, EventArgs e)
        {
            if (LbxProducts.SelectedIndex > -1)
            {
                Product product = LbxProducts.SelectedItem as Product;

                DialogResult dialogResult = MessageBox.Show($"Are You Sure About Deleting {product.Name} Product ? ", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    ContextHelper.db.Products.Remove(product);
                    if (ContextHelper.db.SaveChanges() > 0)
                    {
                        LoadProducts();
                    }
                }
            }
        }
        private void LbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbxProducts.SelectedIndex > -1)
            {
                Product product = LbxProducts.SelectedItem as Product;

                TbxProductName.Text = product.Name;
                TbxProductDesc.Text = product.Description;
                NudProductUnitPrice.Value = product.UnitPrice;
                NudProductStock.Value = product.Stock;
                ChkProductIsSale.Checked = product.IsSale;
            }
        }
        #endregion
    }
}
