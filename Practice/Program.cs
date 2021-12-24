using System;

namespace gooding
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }            
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo a = new BirthdayInfo();
            Console.WriteLine($"{a.Name}");
            Console.WriteLine($"{a.Birthday}");
            Console.WriteLine($"{a.Age}");

            BirthdayInfo b = new BirthdayInfo()
            {
                Name = "서현"
            };
        }
    }
}