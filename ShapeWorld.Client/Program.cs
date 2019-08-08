using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
   internal class Program
    {
       private static void Main(string[] args)
        {
           PlayWithShapes();
        }
        private static void PlayWithShapes()
        {
          Shape someShape = new Rectangle();
          //Square someSquare = new Square();
          Rectangle someRectangle = new Rectangle() as Square;
         // Cube someCube = new Square() as Cube;
          Triangle someTriangle = new Triangle();

          someTriangle.Length = 10;
          someTriangle.Width = 100; 
         // someCube.Depth = 20;
          
         // Console.WriteLine(someCube.Depth);
          Console.WriteLine(someShape.Volume());
          Console.WriteLine(someTriangle.Volume());
          Console.WriteLine(someTriangle.Length);
          Console.WriteLine(someTriangle.NumberOfEdges);
          Console.WriteLine(someTriangle.Surface());
          //Console.WriteLine(someCube.Length);
         // Console.WriteLine(someCube.Width);
          //Console.WriteLine(someCube.Depth);
        }
    }
}

