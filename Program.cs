using ConsoleApp8.Task1;
using ConsoleApp8.Task2;
using ConsoleApp8.Task3;
using ConsoleApp8.Task4;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car("BMW", 278);
            //myCar.DisplayInfo();
            Builder bder1 = new Builder(20000,3,"Name1",47,"18.12.1983");
            Sailor sail1 = new Sailor(20000, "Board1", "Name2", 51, "12.01.1965");
            Pilot pil1 = new Pilot("Plane1", 20000, "Name3", 23, "29.07.1987");
            ForeignPassport fpas1 = new ForeignPassport("18.12.1999", "18.12.2004",746587,"Name",21, "29.07.1981");
            Tiger tg1 = new Tiger("Tiger...", "Name1", 7);
            Crocodile cr1 = new Crocodile("Crocodile...", "Name2", 5);
            Kangaroo cg1 = new Kangaroo("Kangaroo...", "Name3", 6);
            Rectangle rt1 = new Rectangle(5, 6.4);
            Circle cl1 = new Circle(6);
            Rightriangle grt1 = new Rightriangle(2.5, 7);
            Trapeze tp1 = new Trapeze(4.5, 7, 4);
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-4 or 5 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        bder1.DisplayInfo();
                        sail1.DisplayInfo();
                        pil1.DisplayInfo();
                        break;
                    case 2:
                        fpas1.DisplayInfo();
                        break;
                    case 3:
                        tg1.DisplayInfo();
                        cr1.DisplayInfo();
                        cg1.DisplayInfo();
                        break;
                    case 4:
                        rt1.Area();
                        cl1.Area();
                        grt1.Area();
                        tp1.Area();
                        break;
                    case 5:
                        whil = 1;
                        break;
                }
            }
        }
    }
}
