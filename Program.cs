using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter2
{
    class Program
    {
        static IEnumerable<string> GetData(string fileName)
        {
            var lines = File.ReadLines(fileName);
            return lines;
            
        }
        
        static void Main(string[] args)
        {

            var listData = GetData("unsorted-names-list.txt");
            listData.ToList().ForEach(x => Console.WriteLine(x));

        }

        

//        static string SortData(string ListData)
//        {
//            
//        }
    }
    
    
}
