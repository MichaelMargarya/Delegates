﻿using LinkListBigProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWpf
{
    internal class MyQueueEx<T>: IEnumerable<T>
    {
        private MyLinkedList<T> myQueue = new MyLinkedList<T>();
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

