﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products
{
  public class Product
    {
       public Product()
       {
           
       }

       public Product(string name, int id, string description, double weight, Size size, bool instock = false)
  {
      ProductName = name;
      ProductID = id;
      ProductDescription = description;
      ProductWeight = weight;
      InStock = instock;
      ProductSize = size;
  }

       public string ProductName { get; set; }
       public int ProductID { get; set; }
       public int ProductPrice { get; set; }
       public string ProductDescription{ get; set; }
       public double ProductWeight { get; set; }
       public bool InStock { get; set; }

       
       public Size ProductSize{ get; set; }

      
    }
}
