using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogUserControl
{
    public partial class CatalogProductsUC : UserControl
    {
        Button sizeButton;
        Button colorButton;

        static DataAccess da = new DataAccess();

        ProductModel productModel;
        Product detailFormProduct;

        String language,category,subCategory;


        //Method to clean the labels and FlowLayouts
        private void CleanProduct()
        {
            productIdLabel.Text = "";
            nameProductModelLabel.Text = "";
            prizeProductLabel.Text = "";
            sizeFlowLayout.Controls.Clear();
            colorFlowLayout.Controls.Clear();
        }

        //Method to load the product into the main Form
        public void LoadProduct()
        {
            CleanProduct();
            language = englishRadioButton.Checked != true ? "fr" : "en";

            if (categoryComboBox.SelectedIndex != -1)
            {
                category = $"AND Production.ProductCategory.Name = '{categoryComboBox.SelectedItem.ToString()}' ";
            }

                     if (subcategoryComboBox.SelectedItem != null)
                     {
                         subCategory = $"AND Production.ProductSubcategory.Name = '{subcategoryComboBox.SelectedItem.ToString()}' ";
                     }
            

            List<int> products = da.getAllProducts(category, subCategory);
            Random rnd = new Random();
            int outNumber = products[rnd.Next(0, products.Count)];

            productModel = da.GetProductModel(outNumber, language,category,subCategory);

            while (productModel.ProductModelID == 0 || productModel == null)
            {
                outNumber = products[rnd.Next(0, products.Count)];
                productModel = da.GetProductModel(outNumber, language,category,subCategory);
            }

            productModel.Sizes = da.GetSizesProduct(outNumber);
            productModel.Colors = da.GetColorsProduct(outNumber);


            //Set the values of the ProductModel to the components of the UserControl.
            System.IO.MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            productPictureBox.Image = largePhoto;
            nameProductModelLabel.Text = productModel.Name;
            prizeProductLabel.Text = "List Price " + productModel.ListPrice.ToString();

            //Create a button for every size of the product 
            if (productModel.Sizes.Count > 1)
                foreach (ProductSizes product in productModel.Sizes)
                {
                    sizeButton = new Button();
                    sizeButton.Text = product.Size;
                    sizeButton.Name = product.productID.ToString();
                    this.sizeButton.Click += new System.EventHandler(sizeButtons_Click);
                    sizeFlowLayout.Controls.Add(sizeButton);
                }
            else
            {
                sizeButton = new Button();
                sizeButton.Text = "Talla unica";
                sizeButton.Name = productModel.Sizes[0].productID.ToString();
                this.sizeButton.Click += new System.EventHandler(sizeButtons_Click);
                sizeFlowLayout.Controls.Add(sizeButton);
            }

            //Create a button for every color of the product 
            if (productModel.Colors.Count > 0)
            {
  /*              foreach (ProductColors product in productModel.Colors)
                {
                    Color red = Color.FromName("Red");   
                 //   Color mycolor = ColorTranslator.FromHtml(product.Color);
                    var orderedColorList = productModel.Colors
                    .OrderBy(color => mycolor.GetHue());
                }
  */

                    foreach (ProductColors product in productModel.Colors)
                {
                    colorButton = new Button();
                    colorButton.Name = product.productID.ToString();
                    if (product.Color == "Multi")
                        colorButton.Text = "Multi";
                    else

                    if (product.Color == "Silver/Black")
                        colorButton.Text = "Silver / Black";
                    else
                    {
                        Color mycolor = ColorTranslator.FromHtml(product.Color);
                        colorButton.BackColor = mycolor;
                        this.colorButton.Click += new System.EventHandler(colorButtons_Click);
                        colorFlowLayout.Controls.Add(colorButton);
                    }
                }

            }
            else
            {
                sizeButton = new Button();
                sizeButton.Text = "Sin color";
                sizeButton.Name = productModel.Sizes[0].productID.ToString();
                this.colorButton.Click += new System.EventHandler(colorButtons_Click);
                sizeFlowLayout.Controls.Add(sizeButton);

            }
            }

        //Method for the click Event on any size Button
        private void sizeButtons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            String size;
            Product auxProduct;

            if (btn.Text != "Talla unica")
                size = $" = '{btn.Text}'";
            else
                size = "is null";

            auxProduct = da.getProductBySize(productModel.ProductModelID, language,size);

            productIdLabel.Text = "PRODUCT ID : " + auxProduct.productID.ToString();
        }

        //Method for the click Event on any color Button
        private void colorButtons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            String color;
            Product auxProduct;

            if (btn.Text != "Sin color")
                color = $" = '{btn.BackColor.Name}'";
            else
                color = "is null";

            auxProduct = da.getProductByColor(productModel.ProductModelID, language, color);
            productIdLabel.Text = "PRODUCT ID : " + auxProduct.productID.ToString();
        }

        //Load the catComboBox with all avaliables categories
        private void LoadCatComboBox()
        {
            List<string> categories = da.GetCategories();
            foreach (string cat in categories)
            {
                categoryComboBox.Items.Add(cat);
            }
        }
        private void categoryComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            subcategoryComboBox.Items.Clear();
            List<string> subCategories = da.GetSubCategories(categoryComboBox.SelectedItem.ToString()).ToList();

            foreach (string subCat in subCategories)
            {
                subcategoryComboBox.Items.Add(subCat);
            }
        }

        public CatalogProductsUC()
        {
            InitializeComponent();
        }

        private void CatalogProductsUC_Load(object sender, EventArgs e)
        {
            LoadProduct();
            configToolTips();
            LoadCatComboBox();
        }

        private void catalogScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            LoadProduct();
        }

        //Configure the ToolTips of the form, This form has three Tooltips
        // on pictureBox, on any sizeButton and on any colorButton
        public void configToolTips()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;


            // Set up the ToolTip text for Controls that you want use it
            toolTip1.SetToolTip(this.productPictureBox, "Click for more details");
            toolTip1.SetToolTip(this.sizeButton, "Click for more details");
            toolTip1.SetToolTip(this.colorButton, "Click for more details");


        }

        //Method/Event to go the detailForm
        private void productPictureBox_Click(object sender, EventArgs e)
        {
            detailFormProduct = da.getProduct(productModel.ProductModelID, language);
            DetailForm detailForm = new DetailForm(detailFormProduct,productModel);
            detailForm.ShowDialog();
        }
    }
}
