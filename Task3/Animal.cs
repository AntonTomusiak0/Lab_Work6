
namespace ConsoleApp8.Task3
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }
    }
}
