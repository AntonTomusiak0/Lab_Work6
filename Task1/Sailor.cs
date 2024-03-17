
namespace ConsoleApp8.Task1
{
    public class Sailor : Human
    {
        public int Exper { get; set; }
        public string BoardName { get; set; }
        public Sailor(int ex, string bn, string pip, int age, string bd) : base(pip, age, bd)
        {
            Exper = ex;
            BoardName = bn;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Exper: {Exper}\nBoardName: {BoardName}");
        }
    }
}
