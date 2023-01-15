using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Program
{
    public class SearchTheWordFromWordList
    {
        string[] Arr = { "Praveen", "Kumar", "Prabha", "Raju", "John", "Nikhil", "Grisham", "Yahn" };
        public void List()
        {
            Console.WriteLine("Before Sorting List of word :");
            Console.Write("[ ");
            foreach (string str in Arr)
            {

                Console.Write(str + ", ");

            }
            Console.WriteLine("]");
            Console.WriteLine();
            Array.Sort(Arr);
            Console.WriteLine("\nAfter sorting List of word :");
            Console.Write("[ ");
            foreach (string str in Arr)
            {

                Console.Write(str + " ");

            }
            Console.WriteLine("]");
            Console.WriteLine();
        }
        public void Searching(string W)
        {
            int c = 0;
            foreach (string str in Arr)
            {
                if (W == str)
                {
                    Console.WriteLine("\nWord Found  " + W + "==" + str);

                    c = 1;
                }

            }
            if (c == 0)
            {
                Console.WriteLine("\nWord Not Found");
            }


        }
    }

    class Algorithm
    {
        static void Main(string[] args)
        {
            string W = "Prabha";
            SearchTheWordFromWordList lh = new SearchTheWordFromWordList();
            lh.List();
            lh.Searching(W);
        }
    }
}