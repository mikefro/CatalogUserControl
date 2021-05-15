using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogUserControl
{
    public partial class Form1 : Form
    {

        DataAccessTestingForm da = new DataAccessTestingForm();
        List<int> products;
        int categoryId, subcategoryId;

        ProductModel productModel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCatComboBox();
            products = da.getAllProducts();
            for (int i = 1; i < 4; i++)
            {
                
            }
        }



        //Load the catComboBox with all avaliables categories
        private void LoadCatComboBox()
        {
            List<Category> categories = da.GetCategories();

            BindingList<Category> objects = new BindingList<Category>();

            

            foreach (Category cat in categories)
            {
                objects.Add(new Category() { Name = cat.Name, ProductCategoryId = cat.ProductCategoryId });
            }
            categoryComboBox.ValueMember = null;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.DataSource = objects;
            categoryComboBox.SelectedIndex = -1;

        }


        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Category current = new Category();
            List<Subcategory> subCategories = new List<Subcategory>();
            BindingList<Subcategory> objects = new BindingList<Subcategory>();

            subcategoryComboBox.DataSource = null;
            subcategoryComboBox.Items.Clear();

            if (categoryComboBox.SelectedValue != null)
            {
                current = (Category)categoryComboBox.SelectedValue;
                categoryId = current.ProductCategoryId;
                subCategories = da.GetSubcategories(current.ProductCategoryId);
            }

            foreach (Subcategory subcat in subCategories)
            {
                objects.Add(new Subcategory() { Name = subcat.Name , ProductSubcategoryID = subcat.ProductSubcategoryID });
            }
            subcategoryComboBox.ValueMember = null;
            subcategoryComboBox.DisplayMember = "Name";
            subcategoryComboBox.DataSource = objects;
        }

        private void catalogFlowLayout_Scroll(object sender, ScrollEventArgs e)
        {
            positionscrollTextBox.Text = catalogFlowLayout.VerticalScroll.Value.ToString();
        }

        private void subcategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (subcategoryComboBox.SelectedValue != null)
            {
                Subcategory current = (Subcategory)subcategoryComboBox.SelectedValue;
                subcategoryId = current.ProductSubcategoryID;
            }
        }

        private void catalogProductsUC1_Load(object sender, EventArgs e)
        {
            
        }

        public ProductModel LoadProduct(int categoryId, int subcategoryId, string language)
        {
            //            language = englishRadioButton.Checked != true ? "fr" : "en";
            ProductModel productModel;

            Random rnd = new Random();
            int outNumber = products[rnd.Next(0, products.Count)];

            productModel = da.GetProductModel(outNumber, language, categoryId, subcategoryId);

            while (productModel.ProductModelID == 0 || productModel == null)
            {
                outNumber = products[rnd.Next(0, products.Count)];
                productModel = da.GetProductModel(outNumber, language, categoryId, subcategoryId);
            }

            productModel.Sizes = da.GetSizesProduct(outNumber);
            productModel.Colors = da.GetColorsProduct(outNumber);

            

            catalogFlowLayout.Controls.Add(new CatalogProductUC u);

            return productModel;
        }
        }
    }

