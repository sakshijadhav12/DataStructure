namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("linkedList");
            Console.WriteLine("choose option u want! \n1.CustomLinkedList  \n2.Add in Frist \n3.Append \n4.Add in Middle \n5.Delete first");
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

                        
                default:
                    Console.WriteLine("Invalid Option");
                 break;
            }
        }
    }
}