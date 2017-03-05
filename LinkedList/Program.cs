using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LinkedListClass linkedList = new LinkedListClass();
            linkedList.SaveElementToLinkedList("G000");
            linkedList.SaveElementToLinkedList("G001");
            linkedList.SaveElementToLinkedList("P/G002");
            linkedList.SaveElementToLinkedList("G003");
            linkedList.SaveElementToLinkedList("G004");
            linkedList.SendComunicate();
            Console.WriteLine(linkedList.list.Count);
            Console.ReadKey();
        }

    }
}
