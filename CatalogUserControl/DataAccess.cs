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
    internal class DataAccess
    {
        static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AdventureWorks2016; 
            Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; 
            ApplicationIntent = ReadWrite; MultiSubnetFailover = False";



        //Methods to get ProductModel by a integer
        public ProductModel GetProductModel(int productModelId, String language, int category, int subCategory)
        {
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

        //return a  integer list with all productmodelIds
        public List<int> getAllProducts(int category, int subCategory)
        {
            string sql = "SELECT Product.ProductModelID "
                            + "FROM Production.Product "
                            + "JOIN Production.ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID "
                            + "JOIN Production.ProductCategory on  ProductSubcategory.ProductCategoryID = ProductCategory.ProductCategoryID "
                            + "WHERE ProductModelID IS NOT NULL "
                            + category
                            + subCategory;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<int> products = conn.Query<int>(sql).ToList();
                return products;
            }
        }

        //Get a Product with given ProductModelId
        public Product getProduct(int productModelId, String language)
        {
            string sql = $"SELECT ProductID,production.ProductDescription.Description as Description,Product.Name as Name,ProductNumber" +
                      $",MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode as SizeUnitMeasure,WeightUnitMeasureCode as WeightUnitMeasure" +
                      $",Weight,DaysToManufacture,ProductLine,Class,Style,product.ProductSubcategoryID as ProductSubcategory,Product.ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,Product.ModifiedDate " +
                      $"FROM AdventureWorks2016.Production.Product inner join Production.ProductModel on Product.ProductModelID = ProductModel.ProductModelID " +
                      $"inner join Production.ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID " +
                      $"inner join Production.ProductModelProductDescriptionCulture ON ProductModel.ProductModelID = ProductModelProductDescriptionCulture.ProductModelID " +
                      $"inner join production.ProductDescription on ProductModelProductDescriptionCulture.ProductDescriptionID = ProductDescription.ProductDescriptionID " +
                      $"where ProductModelProductDescriptionCulture.CultureID = '{language}' and production.Product.ProductModelID = '{productModelId}'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                Product product = conn.Query<Product>(sql).FirstOrDefault();
                return product;
            }

        }

        //To get the productId by a size of that product
        public Product getProductBySize(int productModelId, String language, String size)
        {
            string sql = $"SELECT ProductID,production.ProductDescription.Description as Description,Product.Name as Name,ProductNumber" +
                      $",MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode as SizeUnitMeasure,WeightUnitMeasureCode as WeightUnitMeasure" +
                      $",Weight,DaysToManufacture,ProductLine,Class,Style,product.ProductSubcategoryID as ProductSubcategory,Product.ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,Product.ModifiedDate " +
                      $"FROM AdventureWorks2016.Production.Product inner join Production.ProductModel on Product.ProductModelID = ProductModel.ProductModelID " +
                      $"inner join Production.ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID " +
                      $"inner join Production.ProductModelProductDescriptionCulture ON ProductModel.ProductModelID = ProductModelProductDescriptionCulture.ProductModelID " +
                      $"inner join production.ProductDescription on ProductModelProductDescriptionCulture.ProductDescriptionID = ProductDescription.ProductDescriptionID " +
                      $"where ProductModelProductDescriptionCulture.CultureID = '{language}' and production.Product.ProductModelID = '{productModelId}' " +
                      $"and product.size {size}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                Product product = conn.Query<Product>(sql).FirstOrDefault();
                return product;
            }

        }

        //To get the productId by a color of that product
        public Product getProductByColor(int productModelId, String language, String color)
        {
            string sql = $"SELECT ProductID,production.ProductDescription.Description as Description,Product.Name as Name,ProductNumber" +
                      $",MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode as SizeUnitMeasure,WeightUnitMeasureCode as WeightUnitMeasure" +
                      $",Weight,DaysToManufacture,ProductLine,Class,Style,product.ProductSubcategoryID as ProductSubcategory,Product.ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,Product.ModifiedDate " +
                      $"FROM AdventureWorks2016.Production.Product inner join Production.ProductModel on Product.ProductModelID = ProductModel.ProductModelID " +
                      $"inner join Production.ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID " +
                      $"inner join Production.ProductModelProductDescriptionCulture ON ProductModel.ProductModelID = ProductModelProductDescriptionCulture.ProductModelID " +
                      $"inner join production.ProductDescription on ProductModelProductDescriptionCulture.ProductDescriptionID = ProductDescription.ProductDescriptionID " +
                      $"where ProductModelProductDescriptionCulture.CultureID = '{language}' and production.Product.ProductModelID = '{productModelId}' " +
                      $"and product.color {color}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                Product product = conn.Query<Product>(sql).FirstOrDefault();
                return product;
            }

        }
/*
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
        public List<Subcategory> GetSubCategories(int category)
        {


            string sql = $" Select ProductSubcategory.ProductSubcategoryID,ProductSubcategory.Name " +
             $"inner join Production.ProductCategory on ProductCategory.ProductCategoryID = ProductSubcategory.ProductCategoryID " +
             $"where '{category}' = Productcategory.ProductCategoryID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<Subcategory> subCategories = conn.Query<Subcategory>(sql).ToList();
                return subCategories;
            }
        }
*/
        //returns the PhotoId with a given ProductId (for Update Product Image)
        public int GetProductPhotoId(int productId)
        {
            {
                string sql = $"select ProductPhoto.ProductPhotoID,ProductProductPhoto.ProductID From Production.ProductPhoto " +
                             $"JOIN Production.ProductProductPhoto on ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID " +
                             $"where ProductID = '{productId}'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int id = conn.Query<int>(sql).FirstOrDefault();
                    return id;
                }
            }
        }

        //Insert an image of a product
        public int WriteImage(String fileName, Image image)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                byte[] largephoto = ms.ToArray();

                string sql = $"INSERT INTO production.ProductPhoto (ThumbNailPhoto, ThumbNailPhotoFileName, LargePhoto, LargePhotoFileName )" +
                    "VALUES (NULL,NULL,@lrgPhoto, @lrgPhotoFileName)";

                var parameters = new {lrgPhoto = largephoto, lrgPhotoFileName = fileName };

                int rowsAffected = conn.Execute(sql, parameters);
                if (rowsAffected != 1)
                {
                    throw new Exception("Error inserting image to DB");
                }
                else
                {
                    return 1;
                }
            }
        }

        //Update an image of a product
        public int UpdateImage(int id, String fileName, Image image)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                byte[] largephoto = ms.ToArray();


                string sql = $"UPDATE production.ProductPhoto SET LargePhoto = @lrgPhoto, LargePhotoFileName = @lrgPhotoFileName " +
                    $"WHERE ProductPhotoId = @productFotoID";

                var parameters = new { productFotoId = id , lrgPhoto = largephoto, lrgPhotoFileName = fileName };

                int rowsAffected = conn.Execute(sql, parameters);
                if (rowsAffected != 1)
                {
                    throw new Exception("Error inserting image to DB");
                }
                else
                {
                    return 1;
                }
            }
        }



    }
}
            
        
    

