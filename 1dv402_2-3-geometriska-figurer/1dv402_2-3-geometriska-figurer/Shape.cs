using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_2_3_geometriska_figurer
{
  public abstract class Shape// ingen möjlighet att deklarera eller intiansiera objekt typen shape
    {
      // Deklarera fält
      private double _length;
      private double _width;
      
      // Egenskaper         
      public double Area { get; }
      public double Perimeter { get; }
      public double Length 
      {
          get { return _length; }
          set
          {
              if (value < 0)
              {
                  throw new ArgumentException();
              }
              _length = value;
          }
      }
      public double Width 
      {
           get { return _width;}
           set 
           {
                if (value < 0) 
                {
                    throw new ArgumentException();
                }
                _width = value;          
           }
        }
             
       protected Shape (double length, double width)
       {
                Length = length;
                Width = width; 
        }
       public override string ToString()
       {
           return string.Format("längd   : {0}\nBredd   :{1}\nOmkrets   :{2}Area   :", Length, Width, Perimeter, Area);
           
       }
     }
      
    }

  

