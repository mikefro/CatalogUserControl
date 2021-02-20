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
        DataAccess da = new DataAccess();
 
        private ProductModel randomProduct()
        {
            ProductModel productModel = null;
            var products = da.getAllProducts(); 
            List<int> listProducts  = new List<int>();

            foreach (Product product in products)
            {
                listProducts.Add(product.ProductId);
            }

            while (productModel == null)
            {
                Random rnd = new Random();
                int outNumber = rnd.Next(0, listProducts.Count);
                productModel = da.GetProductModel(outNumber);
            }

            return productModel;
        }

        private void loadProduct(ProductModel p)
        {
            //Set the values of the ProductModel to the components of the UserControl.
            System.IO.MemoryStream ms = new MemoryStream(p.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            productPictureBox.Image = largePhoto;
            productModelIdLabel.Text = p.ProductModelID.ToString();
            nameProductModelLabel.Text = p.Name;
            prizeProductLabel.Text = p.ListPrice.ToString();
        }
 

        public CatalogProductsUC()
        {
            InitializeComponent();
        }

        private void CatalogProductsUC_Load(object sender, EventArgs e)
        {
            loadProduct(randomProduct());
        }

        private void catalogScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            loadProduct(randomProduct());
        }
    }
}
