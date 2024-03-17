namespace sc7.Task2
{
    internal class PassportBase
    {
        public string Country { get; set; }
        public string OwnerName { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateValid { get; set; }
        public PassportBase(){}
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\nPassport of {Country}");
            Console.WriteLine($"Passport belongs {OwnerName}");
            Console.WriteLine($"Passport valid until: {DateValid}");
            Console.WriteLine($"DateOfIssue: {DateOfIssue}");
        }
    }
}
