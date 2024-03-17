namespace sc7.Task1
{
    internal class HumanBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Wight { get; set; }
        public double Height { get; set; }

        public HumanBase(){}
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Human\nName: {Name}\nAge: {Age}");
            Console.WriteLine($"Gender: {Gender}\nWight: {Wight}\nHeight: {Height}");
        }
    }
}
