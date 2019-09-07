using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaToSharp2.db;

namespace JavaToSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee("Hans Hansen");
            em1.AddFavouriteWord("Git");
            em1.AddFavouriteWord("Gut");
            em1.AddFavouriteWord("Got");

            Console.WriteLine("The fav words of " + em1.NameString + ":");
            em1.PrintAllWords();

     

            Console.WriteLine("Test for git use2");
            Console.ReadLine();
        }
    }
}
