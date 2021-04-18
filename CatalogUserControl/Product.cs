using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogUserControl
{
    public class Product
    {
        public int productID;

        public int GetProductID()
        {
            return productID;
        }

        private void SetProductID(int value)
        {
            productID = value;
        }

        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public byte MakeFlag { get; set; }
        public byte FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public float StandardCost { get; set; }
        public float ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasure { get; set; }
        public string WeightUnitMeasure { get; set; }
        public float Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int ProductSubcategory { get; set; }
        public int ProductModelId { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
    }
}
