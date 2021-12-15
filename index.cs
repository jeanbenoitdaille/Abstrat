    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
         public abstract class Shape
        {
            public abstract void Draw();
        }
     
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }
        
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a rectangle");
            }
        }
        
        public static class Exercise
        {
             public static void Main(){
                  var shapes = new List<Shape>
                {
                    new Rectangle(),
                    new Circle()
                };
     
     
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }
             }
        }
    }