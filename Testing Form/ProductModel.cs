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
        public List<ProductSizes> Sizes { get; set; }
        public List<ProductColors> Colors { get; set; }

    }

    public class ProductSizes : Product
    {
        public string Size { get; set; }
    }

    public class ProductColors : Product
    {
        public string Color { get; set; }
    }
}
