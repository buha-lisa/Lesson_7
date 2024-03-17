namespace sc7.Task3
{
    internal class Kangaroo : AnimalBase
    {
        public int Jump { get; set; }
        public Kangaroo() : base() { }
        public override void Info()
        {
            Console.WriteLine($"\nAnimal: {Name}");
            Console.WriteLine($"Series: {Series}");
            Console.WriteLine($"Genus: {Genus}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Jump: {Jump}");
        }
    }
}
