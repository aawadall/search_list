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
            for (int i = 0; i < 1000; i++)
            {
                searchable.Add(rnd.Next(-10,10));
            }

            var searcher = new LINQSearcher(searchable);
            var result = searcher.FindPositiveComplements();
        }
    }
}
