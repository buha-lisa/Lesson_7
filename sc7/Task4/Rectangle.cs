namespace sc7.Task4
{
    internal class Rectangle : FigureBase
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public Rectangle(double length, double width)
        {
            SideA = length;
            SideB = width;
        }
        public override double Square()
        {
            return SideA * SideB;
        }
    }
}
