using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is at the top of the stack", this.top.Data);
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty, delete not possible");
                return;
            }
            Console.WriteLine("value popped is {0}", this.top.Data);
            this.top = this.top.Next;
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }










}





