using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stack
    {
        LinkedList linkedlist;
        public Stack()
        {
            linkedlist = new LinkedList();
        }
        public void Push(Node node)
        {
            linkedlist.AddNode(node);
        }
        public void DisplayStack()
        {
            linkedlist.StackDisplay();
        }
    }
}
