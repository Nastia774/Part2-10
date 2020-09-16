using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Add", 1);
            myList.Add("Add2", 2);
            myList.Add("Add3", 3);
            myList.Add("Add4", 4);
            Console.WriteLine("Количество елементов - " + myList.Element);

            Console.WriteLine(myList.SpecifiedElement(3));

            Console.ReadKey();
        }
    }
}
