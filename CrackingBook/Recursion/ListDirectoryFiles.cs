using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Recursion
{
    class ListDirectoryFiles
    {
        //static void Main(string[] args)
        //{
        //    var path = Environment.CurrentDirectory.Replace(@"bin\Debug", "");
        //    var count = 0;

        //    ListCount(path, ref count);

        //    Console.WriteLine("Stack added to understand how program Stack execution work");
        //    while (stack.Count > 0) {
        //        Console.WriteLine(stack.Pop());
        //    }
        //}
        public static Stack<string> stack = new Stack<string>();

        static void ListCount(string path, ref int count)
        {

            var dire = new System.IO.DirectoryInfo(path);
            var excludeFilters = new string[] { "utils" };
            foreach (var item in dire.GetDirectories())
            {
                stack.Push(item.Name);
                ListCount(item.FullName, ref count);
            }
            foreach (var item in dire.GetFiles("*.cs"))
            {
                count++;
                Console.WriteLine(count + " : " + item.Directory.Name + " - " + item.Name);
            }

        }
    }
}
