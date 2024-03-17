//using LinkListBigProject;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Net.Http.Headers;
//using System.Security.Principal;

//namespace MyStack
//{
//    internal class Stack<T> : IEnumerable<T>
//    {
//        public MyLinkedList<T> mylist { get; private set; }
//        public MyLinkedListNode<T> Top { get; private set; }

//        public void Push(T item)
//        {
//            mylist.Add(item);
//        }
//        public T Pop()
//        {
//            // MyLinkedListNode<T> temp = Top;
//            // mylist.RemoveFirst();
//            //return temp.Value;
//            if (mylist.Count == 0)
//            {
//                throw new InvalidOperationException();
//            }
//            T value = mylist.head.Value;
//            return value;
//        }
//        public T Peek()
//        {
//            T value = Top[0];
//            if (mylist.Count == 0)
//            {
//                throw new InvalidOperationException();
//            }
//            return value;

//        }

//        public IEnumerator<T> GetEnumerator()
//        {
//            MyLinkedListNode<T> newObj = Top;
//            while (newObj != null)
//            {
//                yield return newObj.Value;
//                newObj = newObj.Next;
//            }
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//        public void Print()
//        {
//            while (Top != null)
//            {
//                Console.WriteLine(Top.Value);
//                Top = Top.Next;
//            }
//        }
//        public T this[int index]
//        {
//            get
//            {
//                MyLinkedListNode<T> newobj = Top;
//                int newobjIndex = 0;
//                while (newobj != null)
//                {
//                    if (newobjIndex == index)
//                    {
//                        return newobj.Value;
//                    }
//                    newobjIndex++;
//                    newobj = newobj.Next;
//                }
//                throw new IndexOutOfRangeException();
//            }
//            set
//            {
//                MyLinkedListNode<T> newObj = Top;
//                int newobjIndex = 0;
//                while (newObj != null)
//                {
//                    newObj.Value = value;
//                    return;
//                }
//                newobjIndex++;
//                newObj = newObj.Next;
//            }

//        }

//    }
//    internal class MyStack<T> : IEnumerable<T>
//    {
//        private MyLinkedList<T> myStack = new MyLinkedList<T>();

//        public void Push(T item)
//        {
//            myStack.AddFirst(item);
//        }
//        public T Pop()
//        {
//            T temp = myStack.head.Value;
//            myStack.RemoveFirst();
//            return temp;
//        }
//        public T Peek()
//        {
//            return myStack.head.Value;
//        }
//        public IEnumerator<T> GetEnumerator()
//        {
//            return myStack.GetEnumerator();
//        }
//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return myStack.GetEnumerator();
//        }
//    }
//}
using LinkListBigProject;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
    internal class MyStack<T> : IEnumerable<T>
    {
        private MyLinkedList<T> myStack = new MyLinkedList<T>();

        public void Push(T item)
        {
            myStack.AddFirst(item);
        }

        public T Pop()
        {
            if (myStack.Count == 0)
            {
                throw new InvalidOperationException();
            }
            T temp = myStack.head.Value;
            myStack.RemoveFirst();
            return temp;
        }

        public T Peek()
        {
            if (myStack.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return myStack.head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return myStack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myStack.GetEnumerator();
        }
    }
}

