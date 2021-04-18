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
    public partial class DetailForm : Form
    {
        Product product;
        ProductModel productModel;

        static DataAccess da = new DataAccess();
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public DetailForm(Product product,ProductModel productModel)
        {
            InitializeComponent();
            this.product = product;
            this.productModel = productModel;
        }

        //Load every TextBox on the DetailForm with the product or productModel needed information
        private void LoadTextBoxes()
        {
            productModelIdTextBox.Text = productModel.ProductModelID.ToString();
            productNameTextBox.Text = productModel.Name;
            productDescriptionTextBox.Text = product.Description;
            productProductLineTextBox.Text = product.ProductLine;
            productClassTextBox.Text = product.Class;
            productStandarTextBox.Text = product.StandardCost.ToString();
            productListPriceTextBox.Text = product.ListPrice.ToString();
            safetyStockLevelTextBox.Text = product.SafetyStockLevel.ToString();
            productReordePointTextBox.Text = product.ReorderPoint.ToString();
            productDaysToManufactureTextBox.Text = product.DaysToManufacture.ToString();
            productMakeFlagCheckBox.Checked = product.MakeFlag != 0 ? true : false;
            productFinishedFlagCheckBox.Checked = product.FinishedGoodsFlag != 0 ? true : false;
        }

        //Load the size and color ListViews 
        private void LoadListViews()
        {
            foreach (ProductColors product in productModel.Colors)
            {
                colorListView.Items.Add(product.Color);
            }

            foreach (ProductSizes product in productModel.Sizes)
            {
                sizeListView.Items.Add(product.Size);
            }

        }


        private void DetailForm_Load(object sender, EventArgs e)
        {
            LoadTextBoxes();
            LoadListViews();
        }

        //Select a picture from the HardDisk
        private void selectPictureButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                addPictureTextBox.Text = openFileDialog.FileName;
                productPictureBox.Image = Image.FromFile(addPictureTextBox.Text);
            }

        }

        //Method on the Event Click for Insert a new Product Image
        private void addPictureButton_Click_1(object sender, EventArgs e)
        {
            string largePhotoFileName = addPictureTextBox.Text.Split('\\').Last();

            try
            {
                int rowsAffected = da.WriteImage(largePhotoFileName, productPictureBox.Image);
                MessageBox.Show("Image inserted correctly", "Success", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK);
            }
        }

        //Method on the Event Click for Update a product Image
        private void changePictureButton_Click(object sender, EventArgs e)
        {
            string largePhotoFileName = addPictureTextBox.Text.Split('\\').Last();

            try
            {
                int productPhotoId = da.GetProductPhotoId(product.productID);
                int rowsAffected = da.UpdateImage(productPhotoId,largePhotoFileName, productPictureBox.Image);
                MessageBox.Show("Image updated correctly", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK);
            }
        }
    }
}
