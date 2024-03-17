
namespace ConsoleApp8.Task4
{
    internal class Trapeze : Figure
    {
        public double Size_A { get; set; }
        public double Size_B { get; set; }
        public double Size_H { get; set; }
        public Trapeze(double a, double b,double h) : base()
        {
            Size_A = a;
            Size_B = b;
            Size_H = h;
        }
        public override void Area()
        {
            Console.WriteLine(((Size_A * Size_B)/2)* Size_H);
        }
        void DisplayInfo()
        {
            Console.WriteLine($"Size_A: {Size_A}\nSize_B: {Size_B}\nSize_H: {Size_H}");
        }
    }
}
