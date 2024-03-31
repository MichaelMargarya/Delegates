using LinkListBigProject;
using System.Collections;

namespace MyQueueWPF
{
    internal class MyQueue<T> : IEnumerable<T>
    {
       public int Count { get; private set; }
        MyLinkedList<T> myQueue = new MyLinkedList<T>();
        public void Enqueue(T item)
        {
            myQueue.AddFirst(item);
        }
        public T Dequeue()
        {
            T temp = myQueue.tail.Value;
            myQueue.RemoveFirst();
            return temp;

        }
        public T Peek()
        {
            return myQueue.tail.Value;
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
