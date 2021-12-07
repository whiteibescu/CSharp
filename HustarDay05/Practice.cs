using System;

namespace This
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }
        
        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return Position;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");

            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tiger = new Employee();
            tiger.SetName("Tigger");
            tiger.SetPosition("Cleaner");
            Console.WriteLine($"{tiger.GetName()} {tiger.GetPosition()}");
        }
    }
}