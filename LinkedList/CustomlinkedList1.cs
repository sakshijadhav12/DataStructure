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
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine("{0} is inserted in the last Node", newNode.data);
        }

        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;

        }
        public void AddFirst(int Data)
        {
            Node newNode = new Node(Data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} is inserted in the frist Node", newNode.data);
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void InsertAfter(int targetValue, int newData)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == targetValue)
                {
                    Node newNode = new Node(newData);
                    newNode.next = temp.next;
                    temp.next = newNode;
                    Console.WriteLine("{0} is inserted after {1}", newData, targetValue);
                    break;
                }
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("{0} not found in the list", targetValue);
            }
        }
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty. Nothing to delete.");

            }
            else
                Console.WriteLine("Deleting the first element: {0}", head.data);
            head = head.next;

        }
        public void PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty. Nothing to delete.");
                return;
            }

            if (head.next == null)
            {
                // If there is only one element in the linked list
                Console.WriteLine("Deleting the last element: {0}", head.data);
                head = null;
                return;
            }

            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            Console.WriteLine("Deleting the last element: {0}", temp.next.data);
            temp.next = null;
        }
        public Node Search(int targetValue)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == targetValue)
                {
                    return temp;
                }
                temp = temp.next;
            }

            return null;

        }
        public void Insert(int targetValue, int newData)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == targetValue)
                {
                    Node newNode = new Node(newData);
                    newNode.next = temp.next;
                    temp.next = newNode;
                    Console.WriteLine("{0} is inserted after {1}", newData, targetValue);
                    break;
                }
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("{0} not found in the list", targetValue);
            }
        }


        public void Display()
        {
            Node temp = head;
            Console.Write("Linked List: ");
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }

        public void DeleteNodeWithValue(int targetValue)
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty. Nothing to delete.");
                return;
            }

            if (head.data == targetValue)
            {
                Console.WriteLine("Deleting the node with value {0}", head.data);
                head = head.next;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                if (temp.next.data == targetValue)
                {
                    Console.WriteLine("Deleting the node with value {0}", temp.next.data);
                    temp.next = temp.next.next;
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("Node with value {0} not found in the list.", targetValue);
        }

        public int GetSize()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

    }
       
}
    


