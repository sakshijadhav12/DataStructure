using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node1 
    {
        public int Data { get; set; }
        public Node1 Next { get; set; }

        public Node1(int data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class LinkedListStack
    {
        private Node1 top; 

        public LinkedListStack()
        {
            this.top = null;
        }

        internal void Push(int value)
        {
            Node1 node = new Node1(value); 
            if (this.top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
         public void Display()
        {
            Node1 temp = this.top;
            while(temp!= null)
            {
                Console.WriteLine(temp.Data  + "");
                temp = temp.Next;
            }
        }
    }



}

