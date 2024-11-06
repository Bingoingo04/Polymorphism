namespace Polymorphism
{
    internal class Triangle : Geometry
    {
        public double Height { get; set; }
        public double Base { get; set; }

        public Triangle()
        {
            Height = 5;
            Base = 7;
        }

        public override double Area()
        {
            return (Base * Height) / 2;
        }
    }
}
