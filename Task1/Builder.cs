namespace ConsoleApp8.Task1
{
    public class Builder : Human
    {
        public int Salary { get; set; }
        public int Exper { get; set; }
        public Builder(int sal, int ex, string pip, int age, string bd) : base(pip, age,bd)
        {
            Salary = sal;
            Exper = ex;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Salary: {Salary}\nExper: {Exper}");
        }
    }
}
