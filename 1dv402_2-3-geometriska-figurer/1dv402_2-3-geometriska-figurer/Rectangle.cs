using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_2_3_geometriska_figurer
{
   public  class Rectangle: Shape
    {
        //Egenskaper
          public override double Area // Räkna ut Area
          {
              get { return (Length * Width); }
          }
          public override double Perimeter 
          {
              get { return (2 *Length) + (2* Width); }
          }

          public Rectangle (double length, double width)
                :base(length, width)
          {

          }
   }
}
