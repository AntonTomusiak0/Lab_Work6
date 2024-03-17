
namespace ConsoleApp8.Task3
{
    public class Tiger : Animal
    {
        public string Info { get; set; }
        public Tiger(string info, string name, int age) : base(name, age)
        {
            Info = info;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Info: {Info}\nName: {Name}\nAge: {Age}");
        }
    }
}
