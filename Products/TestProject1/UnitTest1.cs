using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOfBoxSizePrintPass()
        {
            Size s = new BoxSize(1,1,1);
            string text = s.GetAsText();
            Assert.AreEqual("1x1x1 mm", text);
        }


        [TestMethod]
        public void TestOfShoeSizePrintPass()
        {
 
            Size s = new ShoeSize(new int[42]);
           int size = s.GetAsInt();
           Assert.AreEqual(42,size);
        }


        [TestMethod]
        public void AddProductToStoragePass()
        {
            Product p = new Product("Testprodukt", 1, "Testdescription", 1.0, new BoxSize(1, 1, 1), true);
            ProductStorage ps = new ProductStorage();
            ps.AddNewProduct(p);
            Assert.AreEqual(ps.ProductCount(), 1);
        }


        [TestMethod]
        public void RemoveProductFromStoragePass()
        {

            Product p = new Product("Testprodukt", 1, "Testdescription", 1.0, new BoxSize(1, 1, 1), true);
            ProductStorage ps = new ProductStorage();
            ps.AddNewProduct(p);
            ps.RemoveProductID(1);
            Assert.AreEqual(ps.ProductCount(), 0);
        }

          [TestMethod]
        public void SortProductsByNamePass()
        {            
            ProductStorage ps = new ProductStorage();
            Product p1 = new Product("Testprodukt", 1, "Testdescription", 1.0, new BoxSize(1, 1, 1), true);
            Product p2 = new Product("ABC produkt", 1, "Testdescription", 1.0, new BoxSize(1, 1, 1), true);
            ps.AddNewProduct(p1);
            ps.AddNewProduct(p2);

           List<Product> sortedlist = ps.ProductsSortedByName();
           Assert.AreEqual(sortedlist[0].ProductName, "ABC produkt");
        }

        //  [TestMethod]
        //public void SortProductsByPricePass
        //  {

        //  }


    }
}
