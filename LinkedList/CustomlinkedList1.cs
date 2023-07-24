using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class CustomlinkedList1
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode =new Node(data);
            if(head==null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted in the last Node", newNode.data);
            }
            else
            {
                Node LastNode = GetLastNode();
                Console.WriteLine("{0} is inserted in the last Node", newNode.data);
            }
        }
        public Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;

        }
    }
}
