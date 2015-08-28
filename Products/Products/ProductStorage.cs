using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products
{
    public class ProductStorage
    {
        private List<Product> productDb = new List<Product>();
       


        public ProductStorage()
        {

        }

        public void AddNewProduct(Product p)
        {
            productDb.Add(p);
        }



        public int ProductCount()
        {
            return productDb.Count;
        }

        public List<Product> ProductsSortedByName()
        {

            var subset = from product in productDb
                         orderby product.ProductName
                         select product;

            return subset.ToList<Product>();
        }


        public void RemoveProductID(int productid)
        {
            foreach (var product in productDb)
            {
                if (product.ProductID == productid)
                {
                    productDb.Remove(product);
                    break;
                }
            }
        }
    }
}


