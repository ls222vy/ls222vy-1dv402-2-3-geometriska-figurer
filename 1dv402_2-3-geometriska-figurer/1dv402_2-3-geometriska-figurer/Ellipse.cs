using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_2_3_geometriska_figurer
{
   public abstract class Ellipse: Shape
    {
        //Egenskaper
       public override double Area // räknar ut area
       {
           get { return Math.PI * (Length / 2) * ( Width / 2); }
       }
       public override double Perimeter // Räknar ut Omkrets
       {
           get { return Math.PI * Math.Sqrt(2 *(Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2)); }
       }
       
       public Ellipse (double length, double width)
         :base (length, width) 
       { 
         
       }

       
    }
}
