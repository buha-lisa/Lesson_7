namespace sc7.Task3
{
    internal class AnimalBase
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Genus { get; set; }
        public string Series { get; set; }
        public AnimalBase() { }

        public virtual void Info()
        {
            Console.WriteLine($"\nAnimal: {Name}");
            Console.WriteLine($"Series: {Series}");
            Console.WriteLine($"Genus: {Genus}");
            Console.WriteLine($"Species: {Species}");
        }
    }
}
