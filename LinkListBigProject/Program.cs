using LinkListBigProject;
using System.Linq;
using System.Net.Security;

namespace LinkListBigProject;
internal class Program
{
    static void Main(string[] args)
    {
        MyLinkedList<int> ints = new MyLinkedList<int>();
        ints.AddFirst(10);
        ints.AddLast(76);
       // Print(ints.head);
        ints.AddLast(106);
        ints.AddLast(12561562);
        ints.RemoveLast();
        Print(ints.head);
       
        
    }
    //public static void Print(MyLinkedListNode<int> ints)
    //{
    //    {
    //        while (ints.Next != null)
    //        {          
    //            Console.WriteLine(ints.Value);
    //            ints = ints.Next;
    //            if(ints.Next == null)
    //            {
    //                foreach (int i in ints)
    //                {
    //                    Console.WriteLine(ints.Value);
    //                }
    //            }
    //        }
    //    }
    //}
    public static void Print(MyLinkedListNode<int> ints)
    {
        while (ints != null)
        {
            Console.WriteLine(ints.Value);
            ints = ints.Next;
        }
    }

}