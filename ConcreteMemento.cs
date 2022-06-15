using System;

namespace MomentoDesignPattern
{
    public class ConcreteMemento : IMemento
    {
        private string State { get; set; }
        private DateTime Date { get; set; }

        public ConcreteMemento(string state)
        {
            State = state;
            Date = DateTime.Now;
        }

        public string GetState() =>
            State;

        public string GetName() =>
            $"{Date} - {State}";

        public DateTime GetDate() =>
            Date;
    }
}