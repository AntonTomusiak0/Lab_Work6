
namespace ConsoleApp8.Task4
{
    public class Rightriangle : Figure
    {
        public double Size_A { get; set; }
        public double Size_B { get; set; }
        public Rightriangle(double a, double b) : base()
        {
            Size_A = a;
            Size_B = b;
        }
        public override void Area()
        {
            Console.WriteLine((Size_A * Size_B)/2);
        }
        void DisplayInfo()
        {
            Console.WriteLine($"Size_A: {Size_A}\nSize_B: {Size_B}");
        }
    }
}