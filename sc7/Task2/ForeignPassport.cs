namespace sc7.Task2
{
    internal class ForeignPassport : PassportBase
    {
        public string Vise {  get; set; }
        public string PassportNumber { get; set; }

        public ForeignPassport() : base() { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\nPassport of {Country}");
            Console.WriteLine($"Passport belongs {OwnerName}");
            Console.WriteLine($"Passport valid until: {DateValid}");
            Console.WriteLine($"DateOfIssue: {DateOfIssue}");
            Console.WriteLine($"PassportNumber: {PassportNumber}");
            Console.WriteLine($"Vise: {Vise}");
        }
    }
}
