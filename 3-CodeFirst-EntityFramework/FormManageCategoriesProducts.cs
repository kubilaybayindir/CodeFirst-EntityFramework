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
                Name=TbxCategoryName.Text,
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
                    LbxCategories.SelectedIndex= selectedIndex;
                }
            }
        }

        private void BtDeleteCategory_Click(object sender, EventArgs e)
        {
            if (LbxCategories.SelectedIndex > -1)
            {
                Category category = LbxCategories.SelectedItem as Category;

                DialogResult dialogResult = MessageBox.Show($"Are You Sure About Deleting {category.Name} Category ? ", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

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
            }
            LoadProducts();
        }
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
    }
}
