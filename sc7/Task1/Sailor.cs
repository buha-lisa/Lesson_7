namespace sc7.Task1
{
    internal class Sailor : HumanBase
    {
        public string WorkOn { get; set; }
        public string Rank { get; set; }
        public Sailor() : base()
        {
            WorkOn = "Water";
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"\nSailor\nName: {Name}\nAge: {Age}");
            Console.WriteLine($"Gender: {Gender}\nWight: {Wight}\nHeight: {Height}");
            Console.WriteLine($"WorkOn: {WorkOn}\nRank: {Rank}");
        }
    }
}
