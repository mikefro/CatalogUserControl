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

        public ProductModel productModel;

        static DataAccess da = new DataAccess();

        Product detailFormProduct;

        ToolTip toolTip1 = new ToolTip();

        public CatalogProductsUC(ProductModel newProduct)
        {
            productModel = newProduct;
            InitializeComponent();
        }

        private void CatalogProductsUC_Load(object sender, EventArgs e)
        {
            LoadProduct();
            configToolTips();
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

            auxProduct = da.getProductBySize(productModel.ProductModelID, size);

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

            auxProduct = da.getProductByColor(productModel.ProductModelID, color);
            productIdLabel.Text = "PRODUCT ID : " + auxProduct.productID.ToString();
        }


        //Configure the ToolTips of the form, This form has three Tooltips
        // on pictureBox, on any sizeButton and on any colorButton
        public void configToolTips()
        {
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            // Set up the ToolTip text for Controls that you want use it
            toolTip1.SetToolTip(this.productPictureBox, da.getProductDescription(productModel.ProductModelID,"en"));
        }

        //Method/Event to go the detailForm
        private void productPictureBox_Click(object sender, EventArgs e)
        {
            detailFormProduct = da.getProduct(productModel.ProductModelID,"en");
            DetailForm detailForm = new DetailForm(detailFormProduct, productModel);
            detailForm.ShowDialog();
        }


        //Method to load the product into the main Form
        public void LoadProduct()
        {
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
                    sizeButton.Size = new Size(40, 40);
                    sizeButton.Text = product.Size;
   //                 sizeButton.GotFocus += SizeButton_GotFocus;
   //                 sizeButton.LostFocus += SizeButton_LostFocus;
                    sizeButton.Name = product.productID.ToString();
                    this.sizeButton.Cursor = Cursors.Hand;
                    this.sizeButton.Click += new System.EventHandler(sizeButtons_Click);
                    this.sizeButton.Cursor = Cursors.Hand;
                    toolTip1.SetToolTip(this.sizeButton, "Click for more details");
                    sizeFlowLayout.Controls.Add(sizeButton);
                }
            else
            {
                sizeButton = new Button();
                sizeButton.Text = "Talla unica";
                sizeButton.Name = productModel.Sizes[0].productID.ToString();
                this.sizeButton.Click += new System.EventHandler(sizeButtons_Click);
                this.sizeButton.Cursor = Cursors.Hand;
                toolTip1.SetToolTip(this.sizeButton, "Click for more details");

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
                        this.colorButton.Cursor = Cursors.Hand;
                        toolTip1.SetToolTip(this.colorButton, "Click for more details");

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
                this.colorButton.Cursor = Cursors.Hand;
                toolTip1.SetToolTip(this.colorButton, "Click for more details");

                sizeFlowLayout.Controls.Add(sizeButton);

            }
        }

        //PENDING GET the diferents buttons(sizes and colors)  remain FOCUSED
        /*
                private void SizeButton_LostFocus(object sender, EventArgs e)
                {
                    Button btn = sender as Button;

                    btn.NotifyDefault(false);
                    btn.Appareance.BorderSize = 1;

                }

                private void SizeButton_GotFocus(object sender, EventArgs e)
                {
                    Button btn = sender as Button;

                    btn.NotifyDefault(true);
                    btn.Appareance.BorderSize = 10;


                }
        */
    }
}