using System.Collections;

namespace LinkListBigProject
{
    public class MyLinkedListNode<T> : IEnumerable<T>
    {
        private MyLinkedListNode<T>[] _list;
        public T Value { get; set; }
        public MyLinkedListNode<T> Next { get; set; }

        public MyLinkedListNode(T value)
        {
            this.Value = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            MyLinkedListNode<T> newObj = this;
            while (newObj != null)
            {
                yield return newObj.Value;
                newObj = newObj.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public T this[int index]
        {
            get
            {
                MyLinkedListNode<T> newobj = this;
                int newobjIndex = 0;
                while (newobj != null)
                {
                    if(newobjIndex == index)
                    {
                        return newobj.Value;
                    }
                    newobjIndex++;
                    newobj = newobj.Next;
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                MyLinkedListNode<T> newObj = this;
                int newobjIndex = 0;    
                while (newObj != null)
                {
                    newObj.Value = value;
                    return;
                }
                newobjIndex++;
                newObj = newObj.Next;
            }
        
        }

    }

}
