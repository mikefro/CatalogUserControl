using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogUserControl
{
    public class DataAccess
    {

        //Methods to get ProductModel by a integer
        public ProductModel GetProductModel(int productModelId)
        {
            string sql = $"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice "
                                + $"FROM Production.ProductModel "
                                + $"JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID "
                                + $"JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID "
                                + $"JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID "
                                + $"WHERE Product.ProductModelID = {productModelId}";
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                ProductModel productModel = connection.Query<ProductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }


        public List<Product> GetProducts(int productModelId)
        {
            List<Product> products;
            string sql = $"SELECT ProductId, Size,Color FROM Production.Product" +
                            $"WHERE Product.ProductModelID = {productModelId}";

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            { 
                products = connection.Query<Product>(sql).ToList();
             }
                return products;
            }
        

        public List<Product> getAllProducts()
        {
            string sql = "SELECT Product.ProductModelID "
                            + "FROM Production.Product "  
                            + "WHERE ProductModelID IS NOT NULL";

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                List<Product> products = connection.Query<Product>(sql).ToList();
                return products;
            }
        }


    }
}
            
        
    

