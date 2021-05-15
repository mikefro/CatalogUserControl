using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogUserControl
{
    public class DataAccessTestingForm
    {
        static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; 
            Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; 
            ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        //return a  integer list with all productmodelIds
        public List<int> getAllProducts()
        {
            string sql = "SELECT Product.ProductModelID "
                            + "FROM Production.Product "
                            + "JOIN Production.ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID "
                            + "JOIN Production.ProductCategory on  ProductSubcategory.ProductCategoryID = ProductCategory.ProductCategoryID "
                            + "WHERE ProductModelID IS NOT NULL ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<int> products = conn.Query<int>(sql).ToList();
                return products;
            }
        }

        //return all the categories of the products
        public List<Category> GetCategories()
        {
            string sql = $"Select ProductCategory.ProductCategoryID,ProductCategory.Name from AdventureWorks2016.Production.ProductCategory;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<Category> categories = conn.Query<Category>(sql).ToList();
                return categories;
            }
        }

        //returns the subcategories with a given category passed by parameter
        public List<Subcategory> GetSubcategories(int category)
        {
            string sql = $" Select ProductSubcategory.ProductSubcategoryID,ProductSubcategory.Name " +
             $"FROM AdventureWorks2016.Production.ProductSubCategory " +
             $"inner join AdventureWorks2016.Production.ProductCategory on ProductCategory.ProductCategoryID = ProductSubcategory.ProductCategoryID " +
             $"where '{category}' = Productcategory.ProductCategoryID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<Subcategory> subCategories = conn.Query<Subcategory>(sql).ToList();
                return subCategories;
            }
        }

        //Return a list of sizes of a product
        public List<ProductSizes> GetSizesProduct(int productModelId)
        {
            List<ProductSizes> products;
            string sql = $"SELECT distinct size FROM Production.Product " +
                            $"WHERE Product.ProductModelID = {productModelId}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                products = conn.Query<ProductSizes>(sql).ToList();
            }
            return products;
        }

        //Return a list of a colors of a product
        public List<ProductColors> GetColorsProduct(int productModelId)
        {
            List<ProductColors> products;
            string sql = $"SELECT distinct color FROM Production.Product " +
                            $"WHERE Product.ProductModelID = {productModelId}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                products = conn.Query<ProductColors>(sql).ToList();
            }
            return products;
        }

        //Methods to get ProductModel by a integer
        public ProductModel GetProductModel(int productModelId, String language, int category, int subCategory)
        {
            string  categorySql, subCategorySql = "";

            if (category > 0 )
            {
                categorySql = $"AND Production.ProductCategory.ProductSubcategoryID = {category} ";
            }

            if (subCategory > 0)
            {
                subCategorySql = $"AND Production.ProductSubcategory.Name = {subCategory} ";
            }

            string sql = $"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice "
                                + $"FROM Production.ProductModel "
                                + $"JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID "
                                + $"JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID "
                                + $"JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID "
                                + $"JOIN Production.ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID "
                                + $"JOIN Production.ProductCategory on  ProductSubcategory.ProductCategoryID = ProductCategory.ProductCategoryID "
                                + $"JOIN Production.ProductModelProductDescriptionCulture ON ProductModel.ProductModelID = ProductModelProductDescriptionCulture.ProductModelID "
                                + $"JOIN production.ProductDescription on ProductModelProductDescriptionCulture.ProductDescriptionID = ProductDescription.ProductDescriptionID "
                                + $"WHERE Product.ProductModelID = {productModelId} "
                                + $"AND ProductModelProductDescriptionCulture.CultureID = '{language}' "
                                + category + subCategory;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                ProductModel productModel = conn.Query<ProductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }


    }
}
            
        
    

