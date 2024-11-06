namespace Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 8;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
