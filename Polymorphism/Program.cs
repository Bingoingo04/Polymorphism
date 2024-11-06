using System.Globalization;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of Geometry objects, each referencing different shapes.
            // Polymorphism allows us to treat different shape objects as Geometry.
            List<Geometry> shapes = new List<Geometry> { new Circle(), new Square(), new Triangle() };

            foreach (var shape in shapes)
            {
                // Polymorphism in action:
                // The correct Area() method is called for each object type (Circle, Square, Triangle).
                // This happens because each object has its own overridden Area() method.
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area():F2}");
            }
        }
    }
}
