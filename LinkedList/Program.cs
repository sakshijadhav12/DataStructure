namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("linkedList");
            Console.WriteLine("choose option u want! \n1.CustomLinkedList  \n2.Add in Frist \n3.Append");
             int option=Convert.ToInt32((string)Console.ReadLine());    
            switch(option)
            {
                case 1:
                CustomlinkedList1 customlinkedList = new CustomlinkedList1();
                    customlinkedList.AddLast(56);
                    customlinkedList.AddLast(30);
                    customlinkedList.AddLast(70);
                 break;
                case 2:
                    CustomlinkedList1 customlinkedList1 = new CustomlinkedList1();
                    customlinkedList1.AddFirst(70);
                    customlinkedList1.AddFirst(56);
                    customlinkedList1.AddFirst(30);
                   break;
                case 3:
                    CustomlinkedList1 customlinkedList2 = new CustomlinkedList1();
                    customlinkedList2.Append(56);
                    customlinkedList2.Append(30);
                    customlinkedList2.Append(70);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                 break;
            }
        }
    }
}