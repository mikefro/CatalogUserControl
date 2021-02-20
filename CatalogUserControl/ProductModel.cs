using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogUserControl
{
    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public byte[] LargePhoto { get; set; }
        public float ListPrice { get; set; }
        public List<Product> SizesAndColorsProduct { get; set; }

    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
    }
}
