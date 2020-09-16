using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_10.add
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            Console.WriteLine(myClass.FacrotyMethod(4));
            MyClass<string> myClass1 = new MyClass<string>();
            Console.WriteLine(myClass1.FacrotyMethod("asd"));

            Console.ReadKey();
        }
    }
}
