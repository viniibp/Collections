using Collections.src.Interfaces;

namespace Collections.src.Models.List
{
    class Lista<T> : IGeneric<T>
    {
        private Node<T> Head, Tail;
        public Lista() => Head = Tail = null;

        public void Add(T value)
        {
            Node<T> node = new(value);

            if (Tail == null)
            {
                Tail = node;
                Head = node;
            }
            else
            {
                Head.Next = node;
                Head = node;
            }
        }

        public void Clear()
        {
            Head = Tail = null;
        }

        public bool Contains(T value)
        {
            var aux = Tail;
            while (aux != null)
            {
                if(aux.Show().Equals(value)) return true;
                aux = aux.Next;
            }
            return false;
        }

        public int Count()
        {
            var aux = Tail;
            var count = 0;
            while (aux != null)
            {
                aux = aux.Next;
                count++;
            }
            return count;
        }

        public bool Remove(T value)
        {
            var aux = Tail;
            while (aux != null)
            {
                if (aux.Next.Show().Equals(value)){
                    aux.Next = aux.Next.Next;
                    return true;
                }
                aux = aux.Next;
            }
            return false;
        }

        public void ShowAll()
        {
            var aux = Tail;
            var toPrint = "[";
            while (aux != null)
            {
                toPrint += aux.Show() + (aux.Next != null ? ", " : null);
                aux = aux.Next;
            }
            toPrint += "]";
            Console.WriteLine(toPrint);
        }

        public T GetByIndex(int index)
        {
            var aux = Tail;
            var count = 0;
            while (aux != null)
            {
                if (count == index) break;
                aux = aux.Next;
                count++;
            }
            return aux.Show();
        }
    }
}
