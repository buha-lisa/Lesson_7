namespace sc7.Task1
{
    internal class Pilot : HumanBase
    {
        public string WorkOn { get; set; }
        public string Airline { get; set; }
        public Pilot() : base()
        {
            WorkOn = "Air";
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"\nPilot\nName: {Name}\nAge: {Age}");
            Console.WriteLine($"Gender: {Gender}\nWight: {Wight}\nHeight: {Height}");
            Console.WriteLine($"WorkOn: {WorkOn}\nAirline: {Airline}");
        }
    }
}
