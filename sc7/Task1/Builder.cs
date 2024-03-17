namespace sc7.Task1
{
    internal class Builder : HumanBase
    {
        public string WorkOn { get; set; }
        public int ProjectAmount { get; set; }

        public Builder() : base()
        {
            WorkOn = "Ground";
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"\nBuilder\nName: {Name}\nAge: {Age}");
            Console.WriteLine($"Gender: {Gender}\nWight: {Wight}\nHeight: {Height}");
            Console.WriteLine($"WorkOn: {WorkOn}\nProjectAmount: {ProjectAmount}");
        }
    }
}
