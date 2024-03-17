
namespace ConsoleApp8.Task2
{
    public class Passport
    {
        public string PIP { get; set; }
        public int Age { get; set; }
        public string BirthDay { get; set; }
        public Passport(string pip, int age, string bd)
        {
            PIP = pip;
            Age = age;
            BirthDay = bd;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"PIP: {PIP}\nAge: {Age}\nBirth Day: {BirthDay}");
        }
    }
}
