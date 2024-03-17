namespace sc7.Task4
{
    internal class Triangle : FigureBase
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }
        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }
        public override double Square()
        {
            return (BaseLength * Height) /2;
        }
    }
}
