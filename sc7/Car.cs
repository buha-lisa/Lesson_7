namespace sc7
{
    internal class Car : VehicleBase
    {
        public int HorsePower { get; set; }
        public Car(string brand, int speed) : base(brand, speed)
        {
            Console.WriteLine("Car");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"HorsePower: {HorsePower}");
        }
    }
}
