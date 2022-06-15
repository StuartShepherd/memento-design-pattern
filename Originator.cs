using System;

namespace MomentoDesignPattern
{
    public class Originator
    {
        private string State { get; set; }

        public Originator(string state)
        {
            State = state;

            Console.WriteLine($"Originator: Initial state is {State}");
        }

        public void ChangeState(string state)
        {
            State = state;

            Console.WriteLine();
            Console.WriteLine($"Originator: State has changed to: {State}");
        }

        public IMemento Save()
        {
            return new ConcreteMemento(State);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            State = memento.GetState();

            Console.WriteLine($"Originator: State has changed to: {State}");
        }
    }
}