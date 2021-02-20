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

        //Methods to get data from database with stored procedures.
        public static ProductModel GetProductModel(int productModelId)
        {
            string sql = $"SELECT ProductModel.ProductModelID, ProductModel.Name,ProductPHoto.ThumbNailPhoto,ProductPhoto.ThumbnailPhotoFileName,"  +
                            "ProductPHoto.LargePhoto, ProductPhoto.LargePhotoFileName" +
                            "JOIN Production.Product on ProductionModel.ProductModelID = Product.ProductmodelID" +
                            "JOIN Production.ProductProductPhoto on Product.ProductID = ProductPhoto.ProductID" + 
                            "JOIN Production.ProductPhoto on ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID" +
                            "WHERE product.productmodelId = {productModelId}";
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                ProductModel productModel = connection.Query<ProductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }

  
    }
}
            
        
    

