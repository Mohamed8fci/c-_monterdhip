using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("mohamed is best");
           
           while (true)
           {
               Console.WriteLine("Enter grade or q to quite");
               var input = Console.ReadLine();

               if(input == "q"){
                   break;
               }
               var grade = double.Parse(input);
               book.AddGrade(grade);
           }
            var state = book.GetStatistics();
            
            Console.WriteLine($"lowest value is{state.Low}");
            Console.WriteLine($"high value{state.High}");
            Console.WriteLine($"my average{state.Average:N1}");
           
         
        }
    }
}
