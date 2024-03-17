namespace sc7.Task3
{
    internal class Crocodile : AnimalBase
    {
        public int Length { get; set; }
        public Crocodile() : base() { }
        public override void Info()
        {
            Console.WriteLine($"\nAnimal: {Name}");
            Console.WriteLine($"Series: {Series}");
            Console.WriteLine($"Genus: {Genus}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Length: {Length}");
        }
    }
}
