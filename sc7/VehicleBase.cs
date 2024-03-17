namespace sc7
{
    internal class VehicleBase
    {
        public string Brand {  get; set; }
        public int Speed { get; set; }

        public VehicleBase(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
            Console.WriteLine("\tVehicle");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nSpeed: {Speed}");
        }
    }
}
