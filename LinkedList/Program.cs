
using LinkedList.Model;

class Program
{
    static void Main()
    {
        var list = new MyLinkedList<int>();
        
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        foreach (var item in list)
            Console.WriteLine(item);

        list.Delete(3);

        Console.WriteLine("-------------------");
        
        foreach (var item in list)
            Console.WriteLine(item);
        
        list.InsertAfter(2, 15);
        
        Console.WriteLine("-------------------");
        
        foreach (var item in list)
            Console.WriteLine(item);
        
        Console.ReadLine();
    }
}