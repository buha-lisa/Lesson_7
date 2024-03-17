namespace sc7.Task4
{
    internal class Trapeze : FigureBase
    {
        public double UpperBase { get; set; }
        public double LowerBase { get; set; }
        public double Height { get; set; }
        public Trapeze(double upperBase, double lowerBase, double height)
        {
            UpperBase = upperBase;
            LowerBase = lowerBase;
            Height = height;
        }
        public override double Square()
        {
            return (UpperBase + LowerBase) / 2 * Height;
        }
    }
}
