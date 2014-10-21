
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_2_3_geometriska_figurer
{
  public abstract class Shape// ingen möjlighet att deklarera eller intiansiera objekt typen Shape
    {
      // Deklarera fält
      private double _length;
      private double _width;
      
      // Egenskaper         
      public abstract double Area { get; }
      public abstract double Perimeter { get; }
     
      public  double Length // Egenskap Length Kapslar in fältet _length för att kunna nå den 
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
             
       protected Shape (double length, double width) // Konstraktorn som har parameter
       {
                Length = length;
                Width = width; 
        }
       public override string ToString()
       {
           return string.Format("Längd    : {0}\nBredd    : {1}\nOmkrets  : {2:f1}\nArea     : {3:f1}\n=========================", Length, Width, Perimeter, Area);
           
       }
     }
      
    }

  

