using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<int> myList = new MyList<int>();
            int index = 2;

            for (int i = 0; i < 5; i++)
                myList.Add(i);

            myList.Remove();

            foreach (var item in myList)
                Console.WriteLine(item);

            var x = myList.GetItem(index);
            Console.WriteLine($"item N:{index} ==> {x}");

            Console.ReadKey();
        }
    }
}
