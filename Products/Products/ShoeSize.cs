using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
  public class ShoeSize : Size
    {
        public int ShoeSz { get; set; }

      int[] SizeOfShoe = new int[] { 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43 };

      public ShoeSize(int[] size)
      {
          ShoeSz = size[0];
      }


      public override int GetAsInt()
      {
          return 42;
      }
    }
}
