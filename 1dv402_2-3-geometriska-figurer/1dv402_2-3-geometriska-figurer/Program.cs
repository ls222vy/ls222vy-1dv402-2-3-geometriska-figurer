using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_2_3_geometriska_figurer
{
    public enum ShapeType { Rectangle, Ellipse }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;

            do
            {
                ViewMenu();

                switch (Console.ReadLine())
                {
                    case "0":
                        return;

                    case "1":
                        shape = CreateShape(ShapeType.Ellipse);
                        ViewShapeDetail(shape);
                        break;

                    case "2":
                        shape = CreateShape(ShapeType.Rectangle);
                        ViewShapeDetail(shape);
                        break;

                    default:
                        ViewErorrMessage("Fel! Ange ett nummer mellan 0 och 2");
                        break;
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tryck tangent för att fortsätta");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
        private static Shape CreateShape(ShapeType shapeType)// Läsa en figurs längd och bredd
        {
            double width;
            double length;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=============================");
            Console.WriteLine("=                           =");
            Console.WriteLine("= {0,15}           =", shapeType);
            Console.WriteLine("=                           =");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.ResetColor();

            width = ReadDoubleGreaterThanZero("Skriv in bredden  ");// ReadDoubleGreaterThanZero anropar string
            length = ReadDoubleGreaterThanZero("Skriv in längden  ");

            // För att kunna växla eller vilja vilken shape man vill visa, använd swicth satsen

            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(length, width);

                case ShapeType.Ellipse:
                    return new Ellipse(length, width);

                default:
                    throw new ApplicationException();
            }

        }
        //Metoden ReadDoubleGreaterThanZero validerar att värdet för läng/bredd
        //är större en noll.
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double input;

            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    return input;
                }
                ViewErrorMessage("Fel! Ange ett flyttal större än 0.");

            } while (true);

        }

        private static void ViewErrorMessage(string prompt)
        {
            throw new NotImplementedException();
        }
        private static void ViewMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==============================");
            Console.WriteLine("=                            =");
            Console.WriteLine("=    Geometriska figurer     =");
            Console.WriteLine("=                            =");
            Console.WriteLine("==============================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("0. Avsluta");
            Console.WriteLine("1. Elipse");
            Console.WriteLine("2. Rektangle");
            Console.WriteLine();
            Console.WriteLine("Ange menyval 0-2: ");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==============================");
            Console.WriteLine("=                            =");
            Console.WriteLine("=        Detaljer            =");
            Console.WriteLine("=                            =");
            Console.WriteLine("==============================");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine(shape);

        }
        //fel meddelande
        private static void ViewErorrMessage(string prompt)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(prompt);
            Console.ResetColor();

        }
    }


}


