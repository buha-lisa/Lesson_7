using One = sc7.Task1;
using Two = sc7.Task2;
using Three = sc7.Task3;
using Four = sc7.Task4;
using sc7.Task4;
namespace sc7
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-4): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        One.Builder builder = new One.Builder()
                        {
                            Name = "Arat",
                            Age = 31,
                            Gender = "male",
                            Wight = 81.2,
                            Height = 1.74,
                            ProjectAmount = 4
                        };
                        builder.ShowInfo();
                        One.Sailor sailor = new One.Sailor()
                        {
                            Name = "Nik",
                            Age = 21,
                            Gender = "male",
                            Wight = 71.2,
                            Height = 1.64,
                            Rank = "Сabin boy"
                        };
                        sailor.ShowInfo();
                        One.Pilot pilot = new One.Pilot()
                        {
                            Name = "Ben",
                            Age = 31,
                            Gender = "male",
                            Wight = 89.2,
                            Height = 1.81,
                            Airline = "American Airlines"
                        };
                        pilot.ShowInfo();
                        break;
                    case 2:
                        Two.PassportBase passport = new Two.PassportBase()
                        {
                            Country = "Ukraine",
                            DateOfIssue = DateTime.Today,
                            DateValid = new DateTime(2028, 3, 17)
                        };
                        passport.DisplayInfo();
                        Two.ForeignPassport foreign = new Two.ForeignPassport()
                        {
                            Country = "UK",
                            DateOfIssue = DateTime.Today,
                            DateValid = new DateTime(2028, 3, 17),
                            PassportNumber = "12244667",
                            Vise = "Vise1"
                        };
                        foreign.DisplayInfo();
                        break;
                    case 3:
                        Three.Tiger tiger = new Three.Tiger()
                        {
                            Name = "Tiger",
                            Species = "Tigris",
                            Genus = "Panthera", 
                            Series = "Carnivora", 
                            Speed = 300
                        };
                        tiger.Info();
                        Three.Crocodile crocodile = new Three.Crocodile()
                        {
                            Name = "Crocodile",
                            Species = "Crocodylus niloticus",
                            Genus = "Crocodylus",
                            Series = "Crocodilia",
                            Length = 5
                        };
                        crocodile.Info();
                        Three.Kangaroo kangaroo = new Three.Kangaroo()
                        {
                            Name = "Kangaroo",
                            Species = "Wallabies",
                            Genus = "Macropodiformes",
                            Series = "Marsupialia",
                            Jump = 300
                        };
                        kangaroo.Info();
                        break;
                    case 4:
                        Four.FigureBase[] figures = new Four.FigureBase[4];
                        figures[0] = new Rectangle(4, 5);
                        figures[1] = new Circle(3);
                        figures[2] = new Triangle(3, 4);
                        figures[3] = new Trapeze(2, 5, 3);
                        foreach (FigureBase shape in figures)
                        {
                            Console.WriteLine($"Area: {shape.Square()}");
                        }
                        break;
                }
                if (task == 0) break;
            }
        }
    }
}
