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
        public IEnumerable<int> FindPositiveComplements() 
        {
            var result = this.searchable    // List to scan
                            .Distinct()     // Filter out duplicates
                            .Where(a => 
                                this.searchable.Where(b => b == -a) // Look for the complement
                                    .Any() 
                                    && a > 0); // +ve values only
            
            foreach (var item in result)
            {
                System.Console.WriteLine($"Item Found = {item}, Negative Complement Exist? {this.searchable.Any(x => x == -item)}");
            } 
            
            return result;
        }
    }
}