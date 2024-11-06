namespace Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 4;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
