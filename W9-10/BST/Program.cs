using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {

        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var sourceLocation = (currentDirectory+ @"\sources\database.txt");

            //Console.WriteLine(@"{0}\sources\database.txt", Directory.GetCurrentDirectory());
            //Console.WriteLine(sourceLocation);


            string text = File.ReadAllText(@"C:\Users\Student\Documents\repos\BST\BST\bin\Debug\source\database.txt");
            Console.WriteLine("{0}", text);

            string[] lines = File.ReadAllLines(@"C:\Users\Student\Documents\repos\BST\BST\bin\Debug\source\database.txt");
            foreach (var l in lines)
            {
                Console.WriteLine("\n" + l);
            }


            Console.ReadKey();
        }
        class BST
        {
            //insertion

        }
    }
}
