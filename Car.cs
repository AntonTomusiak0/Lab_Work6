
namespace ConsoleApp8
{
    public class Car : Vechicle
    {
        public int HorsePower { get; set; }
        public Car(string brand, int speed): base(brand, speed) {
            Console.WriteLine("Car");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"HorsePower: {HorsePower}");
        }
    }
}
