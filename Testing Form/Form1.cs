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
        int categoryId = 0;
        int subcategoryId = 0;
        int scrollMaxPosition;
        string language;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCatComboBox();
            products = da.getAllProducts();
            LoadFourProducts();            
        }

        private void LoadFourProducts()
        {
            for (int i = 0; i < 4; i++)
            {
                ProductModel p = new ProductModel();
                p = LoadProduct(0, 0, language);
                catalogFlowLayout.Controls.Add(new CatalogProductsUC(p));
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
            while (catalogFlowLayout.VerticalScroll.Value > scrollMaxPosition)
            {
                scrollMaxPosition = catalogFlowLayout.VerticalScroll.Value;
            }

            positionscrollTextBox.Text = catalogFlowLayout.VerticalScroll.Value.ToString();

            //Three conditions for good use of the load products moving the scrollbar of the FlowLayoutPanel
            if ((!AllProductsShowed()) && 
                (catalogFlowLayout.VerticalScroll.Value % 280 == 0) &&
                (scrollMaxPosition - catalogFlowLayout.VerticalScroll.Value < 15))
            {
                LoadFourProducts();
            }

        }

        private void subcategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (subcategoryComboBox.SelectedValue != null)
            {
                Subcategory current = (Subcategory)subcategoryComboBox.SelectedValue;
                subcategoryId = current.ProductSubcategoryID;
            }
        }

        //Looking for an all products are showed or not
        private Boolean AllProductsShowed()
        {
            foreach(int i in products)
            {
                if (i != 0)
                    return false;
            }
            return true;
        }

        //Load a ProductModel to pass a single CatalogProductsUC ( the user control)
        public ProductModel LoadProduct(int categoryId, int subcategoryId, string language)
        {
            ProductModel productModel;

            language = englishRadioButton.Checked != true ? "fr" : "en";

            Random rnd = new Random();
            int indexProductList = rnd.Next(0, products.Count);

            int outNumber = products[indexProductList];

            productModel = da.GetProductModel(outNumber, language, categoryId, subcategoryId);

            while (productModel == null)
            {
             indexProductList = rnd.Next(0, products.Count);

             outNumber = products[indexProductList];
                productModel = da.GetProductModel(outNumber, language, categoryId, subcategoryId);
            }

            //Flag a loaded product succesfully
            products[indexProductList] = 0;

            productModel.Sizes = da.GetSizesProduct(outNumber);
            productModel.Colors = da.GetColorsProduct(outNumber);

            return productModel;
        }
        }

    
    }

