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

       public string ProductName { get; set; }
       public int ProductID { get; set; }
       public int ProductPrice { get; set; }
       public string ProductDescription{ get; set; }
       public double Weight { get; set; }
       public bool InStock { get; set; }

       
       public Size ProductSize{ get; set; }

      
    }
}
