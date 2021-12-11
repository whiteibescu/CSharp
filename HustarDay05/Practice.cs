using System;

namespace app
{
    class Mammal
    {
        private string name;
        private string bark;
        public Mammal(string name)
        {
            this.name = name;            
        }
        public void Bark()
        {
            Console.WriteLine("Barking!");
        }
        
        public void WhoAmI()
        {
            Console.WriteLine(name);
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal dog = new Mammal("dog");
            dog.Bark();
            dog.WhoAmI();
        }
    }
}