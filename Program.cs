using System;
using System.Collections.Generic;

namespace salary
{
    class Program
    {
        static void Main()
        {
            // Generating the list with the name of the emplojees
            List<string> emploojeesList = new List<string>(new string[]{ "Name1 Last1", "Name2 Last2", "Name3 Last3" });
            
            // Generating the list with the original salaries
            List<double> OriginalSalaryList = new List<double>(new double[]{ 2500.0, 3500.0, 4500.0 });

            // Defining a new list to store the new salaries
            List<double> NewSalaryList = new List<double>();
                        
            // Generating the new salary multiplying the orininal one by 1.1 (adding 10%)
            foreach(double salary in OriginalSalaryList){
                NewSalaryList.Add((salary*1.1));
            }

            // Calculating the number of elements in the emplojees list
            int records=emploojeesList.Count;

            // Looping and getting the data from the three lists with the same index
            for(int index=0; index<records; index++){
                Console.Write("Name of the emplojee: "+emploojeesList[index]+"     ");
                Console.Write("Original Salary: "+OriginalSalaryList[index]+"     ");
                Console.WriteLine("New Salary: "+NewSalaryList[1]);
            }
        }
    }
}


