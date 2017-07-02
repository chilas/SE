namespace SE.DataStructures.LinkeList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T Value)
        {
            this.Value = Value;
        }

        public T Value { get; set; }
        public LinkedListNode<T> Next { get; internal set; }
    }
}