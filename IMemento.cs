using System;

namespace MomentoDesignPattern
{
    public interface IMemento
    {
        public string GetName();
        public string GetState();
        public DateTime GetDate();
    }
}