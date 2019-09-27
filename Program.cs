using System;
using System.Collections.Generic;

namespace search_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var searchable = new List<int>(); 
            for (int i = 0; i < 100000000; i++)
            {
                searchable.Add(rnd.Next(-10000,10000));
            }

            var searcher = new LINQSearcher(searchable);
            var result = searcher.FindPositiveComplements();
        }
    }
}
