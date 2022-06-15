using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MomentoDesignPattern
{

    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();
        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Save()
        {
            var milliseconds = 1000;

            _mementos.Add(this._originator.Save());

            Console.WriteLine("Caretaker: Saving originator's state");
            Thread.Sleep(milliseconds);
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine();
            Console.WriteLine("Caretaker: Undo originator's state");

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine();
            Console.WriteLine("Caretaker: History:");

            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}