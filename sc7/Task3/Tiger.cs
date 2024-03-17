namespace sc7.Task3
{
    internal class Tiger : AnimalBase
    {
        public int Speed { get; set; }
        public Tiger() : base() { }
        public override void Info()
        {
            Console.WriteLine($"\nAnimal: {Name}");
            Console.WriteLine($"Series: {Series}");
            Console.WriteLine($"Genus: {Genus}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Speed: {Speed}");
        }
    }
}
