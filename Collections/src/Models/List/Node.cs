namespace Collections.src.Models.List
{
    public class Node<T>
    {
        private T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }

        public T Show() => Value;
    }
}
