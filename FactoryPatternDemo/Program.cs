using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        /// <summary> 
        /// In Factory Pattern an interface is made and all the classes who are of that type implements it.
        /// All the creational part of these classes are handled in the factory class. 
        /// The main class then creates an instance of the factory class and creates objects of those classes using the factory class.
        /// This way the user does not knows how the objects are created, but still they get the object through the factory class.
        /// </summary> 
        /// 
        /// <remarks> 
        /// Instead of using Console.Readline() OR, Console.Read() OR, Console.ReadKey() at the end of code to keep the console window open,
        /// you can run your program using Ctrl + F5 in Visual Studio.
        /// Then Visual Studio will keep the console window open, until you press a key.
        /// </remarks>
        static void Main(string[] args)
        {
            //Create an intance of the factory
            ShapeFactory shapeFactory = new ShapeFactory();

            //Create objects from the factory instance where all the creational part is handled
            Shape shapeCircle = shapeFactory.getShape("Circle");
            Shape shapeRectangle = shapeFactory.getShape("Rectangle");

            //Call the Print function of each Shape to print and to test
            shapeCircle.Print();
            shapeRectangle.Print();
        }        
    }
}
