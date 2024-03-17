
namespace ConsoleApp8.Task4
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double a) : base()
        {
            Radius = a;
        }
        public override void Area()
        {
            Console.WriteLine(Radius*3.14);
        }
        void DisplayInfo()
        {
            Console.WriteLine($"Radius: {Radius}");
        }
    }
}
