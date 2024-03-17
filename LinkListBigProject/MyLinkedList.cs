using System.Collections;
namespace LinkListBigProject
{
    public class MyLinkedList<T> : ICollection<T>
    {
        public MyLinkedListNode<T> head { get; private set; }
        public MyLinkedListNode<T> tail { get; private set; }
        #region ICollection
        public int Count { get; private set; }
        public bool IsReadOnly { get => false; }

        public void Add(T item)
        {
            AddFirst(item);
            AddLast(item);
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            MyLinkedListNode<T> current = head;
            while(current!= null )
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region Add
        public void AddFirst(T item)
        {
            AddFirst(new MyLinkedListNode<T>(item));
        }
        private void AddFirst(MyLinkedListNode<T> node)
        {
            MyLinkedListNode<T> temp = head;
            head = node;
            head.Next = temp;
            Count++;
            if (Count == 1)
            {
                tail = head;
            }
        }
        public void AddLast(T item)
        {
            AddLast(new MyLinkedListNode<T>(item));
        }
        private void AddLast(MyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
                Count++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Print(MyLinkedListNode<int> ints)
        {
            while (ints != null)
            {
                Console.WriteLine(ints.Value);
                ints = ints.Next;
            }
        }
        //static MyLinkedListNode<T> Metohd(MyLinkedList<T> obj)
        //{
        //    foreach(var c in obj)
        //    {
        //        if(c > 2)
        //        {

        //        }
        //    }
        //}
        #endregion
        #region Remove
        public void RemoveFirst()
        {
            if(Count != 0)
            {
                head = head.Next;
                Count--;
                if (Count == 0) tail = null;
            }
        }
        public void RemoveLast()
        {
            if(Count != 0)
            {
                if(Count == 1)
                {
                    head = null;
                    tail = null;

                }
                else
                {
                    MyLinkedListNode<T> current = head;
                    while(current.Next != tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    tail = current;
                }
                Count--;
            }
        }

        #endregion
    }
}

