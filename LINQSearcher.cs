using System.Collections.Generic;
using System.Linq;

namespace search_list
{
    public class LINQSearcher
    {
        private List<int> searchable;

        /// <summary>
        /// LINQSearcher constructor, takes a searchable list
        /// </summary>
        /// <param name="searchable"></param>
        public LINQSearcher(List<int> searchable)
        {
            this.searchable = searchable;
        }

        /// <summary>
        /// Searches for unique positive complements to negative elements in searchable 
        /// </summary>
        /// <returns>unique list of positive numbers from searchable</returns>
        public List<int> FindPositiveComplements() 
        {
            var result = this.searchable.Where(e => e < 0);
            foreach (var item in result)
            {
                System.Console.WriteLine($"{item}");
            } 
            return (List<int>)result;
        }
    }
}