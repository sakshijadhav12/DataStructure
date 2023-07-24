namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("linkedList");
            Console.WriteLine("choose option u want! \n1.CustomLinkedList \n 2.Add in Frist");
             int option=Convert.ToInt32((string)Console.ReadLine());    
            switch(option)
            {
                case 1:
                CustomlinkedList1 customlinkedList = new CustomlinkedList1();
                    customlinkedList.AddLast(56);
                    customlinkedList.AddLast(30);
                    customlinkedList.AddLast(70);
                // break;
                //case 2:
                    CustomlinkedList1 customlinkedList1 = new CustomlinkedList1();
                    customlinkedList1.AddFirst(70);
                    customlinkedList1.AddFirst(56);
                    customlinkedList1.AddFirst(30);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                 break;
            }
        }
    }
}