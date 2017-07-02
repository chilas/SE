namespace SE.DataStructures.DoublyLinkeList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T Value)
        {
            this.Value = Value;
        }

        public T Value { get; set; }
        public LinkedListNode<T> Next { get; internal set; }
        public LinkedListNode<T> Previous { get; internal set; }
    }
}