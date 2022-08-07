using System;


namespace Memento.Structural
{
    /// <summary>
    /// Memento Design Pattern
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";

            o.SetMemento(c.Memento);

            Console.ReadKey();

        }
    }

    /// <summary>
    /// The 'Originator' class
    /// </summary>

    public class Originator
    {
        string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("Satate = " + state);
            }
        }

        public Memento CreateMemento()
        {
            return (new Memento(state));
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string State
        {
            get { return state; }
        }
    }

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>


    public class Caretaker
    {
        Memento memento;

        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
