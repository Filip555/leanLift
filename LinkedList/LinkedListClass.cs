using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListClass
    {
        public LinkedList<string> list { get; set; } = new LinkedList<string>();
        LinkedListNode<string> firstElementWithoutPriorytet;
        public List<string> listWithErrors { get; set; } = new List<string>();
        public void SaveElementToLinkedList(string priorytet)
        {
            if (priorytet.Substring(0, 1) == "P")
            {
                if (list.Count == 0) firstElementWithoutPriorytet = null;
                if (firstElementWithoutPriorytet!=null)
                {
                    list.AddBefore(firstElementWithoutPriorytet, priorytet);
                }
                else
                {
                    list.AddFirst(priorytet);
                }
            }
            else
            {
                list.AddLast(priorytet);
                firstElementWithoutPriorytet = list.First;
            }
        }
        public void SendComunicate()
        {
            if (list.Count > 0)
            {
                var firstElement = list.First.Value;
                var returnString = LeanLift(firstElement);
                if(returnString.Substring(3,2)== "99")
                {
                    var errorAtString = list.First.Value;
                    listWithErrors.Add(errorAtString);
                }
                list.RemoveFirst();
                SendComunicate();
            }
        }
        public string LeanLift(string firstElement)
        {
            firstElement.Remove(0, 2);
            Thread.Sleep(1000);
            return "EA-99";
        }
    }
}
