namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("linkedList");
            Console.WriteLine("choose option u want! \n1.CustomLinkedList  \n2.Add in Frist \n3.Append \n4.Add in Middle \n5.Delete first \n6.DeleteLast \n7.Search \n8.Add at specific Position \n9.Delete afer Search \n10.Sorted List");
             int option=Convert.ToInt32((string)Console.ReadLine());    
            switch(option)
            {
                case 1:
                CustomlinkedList1 customlinkedList = new CustomlinkedList1();
                    customlinkedList.AddLast(56);
                    customlinkedList.AddLast(30);
                    customlinkedList.AddLast(70);
                    customlinkedList.Display();
                 break;
                case 2:
                    CustomlinkedList1 customlinkedList1 = new CustomlinkedList1();
                    customlinkedList1.AddFirst(70);
                    customlinkedList1.AddFirst(56);
                    customlinkedList1.AddFirst(30);
                    customlinkedList1.Display();
                   break;
                case 3:
                    CustomlinkedList1 customlinkedList2 = new CustomlinkedList1();
                    customlinkedList2.Append(56);
                    customlinkedList2.Append(30);
                    customlinkedList2.Append(70);
                    break;
                case 4:
                    CustomlinkedList1 customlinkedList3 = new CustomlinkedList1();
                    customlinkedList3.AddFirst(56);
                    customlinkedList3.InsertAfter(56, 30);
                    customlinkedList3.AddLast(70);
                    break;
                case 5:
                    CustomlinkedList1 customlinked = new CustomlinkedList1();
                    customlinked.AddLast(56);
                    customlinked.AddLast(30);
                    customlinked.AddLast(70);
                    customlinked.Display();
                    customlinked.Pop();
                    customlinked.Display();
                  break;
                case 6:
                    CustomlinkedList1 linkedList = new CustomlinkedList1();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.PopLast();
                    linkedList.Display();
                    break;
                case 7:
                    CustomlinkedList1 linkedList1 = new CustomlinkedList1();
                    linkedList1.AddLast(56);
                    linkedList1.AddLast(30);
                    linkedList1.AddLast(70);

                    Node nodeWithTargetValue = linkedList1.Search(30);
                    if (nodeWithTargetValue != null)
                    {
                        Console.WriteLine("Node with value 30 found: ");
                    }
                    else
                    {
                        Console.WriteLine("Node with value 30 not found in the list.");
                    }
                    break;
                case 8:
                    CustomlinkedList1 linkedList2 = new CustomlinkedList1();
                    linkedList2.AddLast(56);
                    linkedList2.AddLast(30);
                    linkedList2.AddLast(70);
                    Node nodeWithKey30 = linkedList2.Search(30);
                    if (nodeWithKey30 != null)
                    {
                        linkedList2.Insert(30, 40);
                        linkedList2.Display();
                    }
                    else
                   {
                        Console.WriteLine("Node with value 30 not found in the list.");
                   }

                    break;
                case 9:
                    CustomlinkedList1 linkedList3 = new CustomlinkedList1();
                    linkedList3.AddLast(56);
                    linkedList3.AddLast(30);
                    linkedList3.AddLast(40);
                    linkedList3.AddLast(70);
                      linkedList3.Display();
                    linkedList3.DeleteNodeWithValue(40);
                    linkedList3.Display();
                    int size = linkedList3.GetSize();
                    Console.WriteLine("Size of LinkedList: " + size);
                    break;
                case 10:
                    SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
                    sortedLinkedList.Add(56);
                    sortedLinkedList.Add(30);
                    sortedLinkedList.Add(40);
                    sortedLinkedList.Add(70);

                    sortedLinkedList.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                 break;
            }
        }
    }
}