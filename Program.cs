using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter2 {
    class Program {
//        static IEnumerable<string> GetData (string fileName) {
//            var lines = File.ReadLines (fileName);
//            return lines;
//
//        }
//        static string SortData (string ListData) {
//            var lines = File.ReadLines (ListData);
//                //ListData.SortData();
//                //ListData.OrderBy (item => item.Split('.').Last());
//                //ListData.OrderBy OrderBy(x => x.LastName).ThenBy(x => x.MiddleName).ThenBy(x => x.FirstName);
//            return ListData;
//        }

        static void Main (string[] args)
        {

            var a = 2;
            var b = 3;
            
            var calc = new Calc();
            
            var answer = calc.Add(a, b);
            Console.WriteLine(answer);
            var answer = calc.Subtract(a, b);
            Console.WriteLine(answer);
            var answer = calc.Multiply(a, b);
            Console.WriteLine(answer);
            var answer = calc.Divide(a, b);
            Console.WriteLine(answer);
            

//            var listData = GetData ("unsorted-names-list.txt");
//            listData.ToList ().ForEach (x => Console.WriteLine (x));
//    
//              var sortedNames = SortData ("Sorted Names");
//              
//           //   SortValue.ToList ().ForEach (x => Console.WriteLine (x));

        }
    }
}

