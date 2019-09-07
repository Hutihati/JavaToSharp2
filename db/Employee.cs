using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToSharp2.db
{
    public class Employee : IPerson
    {
        public Employee(string e)
        {
            NameString = e;
        }

        public string NameString { get; set; } = "Bent";

        public List<string> FavouriteWordList { get; set; } = new List<string>();

        public void AddFavouriteWord(string newWord)
        {
            FavouriteWordList.Add(newWord);
        }

        // Commented code does the same as uncommented
        public void PrintAllWords()
        {
            FavouriteWordList.ForEach(x => Console.WriteLine(x));
            
            //foreach (var word in FavouriteWordList)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
