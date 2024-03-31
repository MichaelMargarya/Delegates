using System.Collections;

namespace MyArrayList
{
    internal class MyArrayNode<T> : IEnumerable<T>
    {
        private MyArrayNode<T>[] _list;
        public T Value { get; private set; }
        public MyArrayNode<T> Next { get; set; }

        public MyArrayNode(T value)
        {
            this.Value = value;
        }
        public IEnumerator<T> GetEnumerator()
        {
            MyArrayNode<T>[] newobj = _list;
            while(newobj! = null)
            {

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
