namespace sc7.Task4
{
    internal class Circle : FigureBase
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Square()
        {
            return Radius*Radius*3.14;
        }
    }
}
