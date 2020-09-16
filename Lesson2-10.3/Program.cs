using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("книга", "book");
            dictionary.Add("ручка", "pen");
            dictionary.Add("солнце", "sun");
            dictionary.Add("яблоко", "apple");
            dictionary.Add("стол", "table");

            Console.WriteLine($"количество пар : {dictionary.KeyValue}");

            Console.WriteLine(dictionary.ByIndex(2));

            Console.ReadKey();
        }
    }
}
