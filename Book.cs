using System.Collections.Generic;
using System;

namespace GradeBook
{
   public class Book{
        public Book(string name){
            grades = new List<double>();
            Name = name;
        }


        public void AddLetterGrade(char letter){

            switch (letter)
            {
                case 'A':
                AddGrade(90);
                break;

                case 'B':
                AddGrade(80);
                break;

                case 'C':
                AddGrade(70);
                break;

                default:
                AddGrade(0);
                break;

            }
        }
        public void AddGrade(double grade){
            if(grade<=100 && grade>=0){

                grades.Add(grade);
            }else{
                Console.WriteLine("invalid value");
            }
        }

        public staticties GetStatistics(){

            var result = new staticties();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

        
        
        for(var index = 0;index<grades.Count;index++)
         {

             result.Low = Math.Min(grades[index],result.Low);
             result.High = Math.Max(grades[index],result.High);
             result.Average +=grades[index];
         }

         result.Average /= grades.Count;
           

           return result;

        }
        private List <double> grades;
        public string Name;
    }
}