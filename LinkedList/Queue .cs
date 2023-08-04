using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
 {
      
        internal class Queue
        {
            private Node front;
            private Node rear;

            public Queue()
            {
                front = null;
                rear = null;
            }

            public void Enqueue(int data)
            {
                Node newNode = new Node(data);
                if (rear == null)
                {
                    front = newNode;
                    rear = newNode;
                }
                else
                {
                    rear.Next = newNode;
                    rear = newNode;
                }
                Console.WriteLine("{0} enqueued to the Queue", data);
            }
        internal class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        public int Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }

            int data = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }


        public void Display()
            {
                Node current = front;
                Console.WriteLine("Queue elements in the specified order:");
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }

     }
       
   



