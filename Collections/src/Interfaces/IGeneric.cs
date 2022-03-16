using System;namespace Collections.src.Interfaces
{
    internal interface IGeneric<T>
    {
        public void Add(T value);
        public void Clear();
        public bool Contains(T value);
        public bool Remove(T value);
        public int Count();
        public void ShowAll();
        public T GetByIndex(int index);
    }
}
