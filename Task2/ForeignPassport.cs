
namespace ConsoleApp8.Task2
{
    public class ForeignPassport : Passport
    {
        public string Dateissue { get; set; }
        public string Validity { get; set; }
        public int Number { get; set; }
        public ForeignPassport(string di, string val, int num, string pip, int age, string bd) : base(pip, age, bd)
        {
            Dateissue = di;
            Validity = val;
            Number = num;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Date of issue: {Dateissue}\nValidity: {Validity}\nNumber: {Number}\nPIP: {PIP}\nAge: {Age}\nBirth Day: {BirthDay}");
        }
    }
}
