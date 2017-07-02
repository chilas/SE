using System;
using System.Collections;
using System.Collections.Generic;

namespace SE.DataStructures.LinkeList
{
    public class LinkeList<T> : System.Collections.Generic.ICollection<T>
    {
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;

        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }

            Count++;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (previous.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                }
                else
                {
                    _head = _head.Next;
                    if (_head == null)
                    {
                        _tail = _head;
                    }
                }
            }
            Count--;
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}