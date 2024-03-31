using System.Collections;

namespace QueueEx;

internal class Program
{
    static void Main(string[] args)
    {
       MyQueue<int> myq = new MyQueue<int>();
        myq.Enqueue(1);
            
        myq.Enqueue(2);
        myq.Enqueue(3);
        myq.Enqueue(4);
        myq.Enqueue(5);
        myq.Peek();
        Console.WriteLine(myq.Peek());
    }
}