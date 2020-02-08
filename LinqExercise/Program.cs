using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */
            var numbers = new List<int>
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            
            //Print the Sum and Average of numbers
            
            Console.WriteLine(numbers.Sum());


            

            Console.WriteLine(numbers.Average());




            //Order numbers in ascending order and decsending order. Print each to console.
            IEnumerable<int> orderNums =
               numbers.OrderByDescending(number => number);

            foreach (var number in orderNums)
            {
                Console.WriteLine(number); //descending
            }

            IEnumerable<int> orderNums2 =
               numbers.OrderBy(number => number);

            foreach (var number in orderNums2)
            {
                Console.WriteLine(number); //ascending
            }


            //Print to the console only the numbers greater than 6
            IEnumerable<int> largerSix =
                 numbers.OrderByDescending(number => number > 6).Take(3);

            foreach (var number in largerSix)
            {
                Console.WriteLine(number);
            }



            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            IEnumerable<int> onlyFour =
               numbers.OrderBy(number => number).Take(4);

            foreach (var number in onlyFour)
            {
                Console.WriteLine(number);
            }

            //Change the value at index 4 to your age, then print the numbers in decsending order
            var newNumbers = new List<int>
            {1, 2, 3, 4, 35, 6, 7, 8, 9, 0 }; //I know there's a better way of changing the [4].

            IEnumerable<int> ageCount =
                 newNumbers.OrderByDescending(number => number);

            foreach (var number in ageCount)
            {
                Console.WriteLine(number);
            }




            // List of employees ***Do not remove this***
            var employees = CreateEmployees();



            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.


            


            var FirstNames = employees.Where(names =>
                employees.Any(name => names.FirstName.StartsWith("S") || names.FirstName.StartsWith("C")));

            foreach (var person in FirstNames)

            {
                Console.WriteLine(person.FullName);
            }

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.

            var NameAge = employees.Where(ageName => employees.Any(ageNames => ageName.Age > 26));
            foreach (var item in NameAge)
            {
                Console.WriteLine(item.Age + " " + item.FullName );
            }
            
            
           
            

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35

            //Omitted- Need to study this one
            

            //Add an employee to the end of the list without using employees.Add()
            string[] employeeList = { "Matt Storey", "Corey McDonald", "Danny Torrence", "Becca Smith" };
            //employeeList.Append("Drew Gaylor");

             Console.WriteLine(string.Join(", ",employeeList.Append("Drew Gaylor")));
            
           
            
           
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
            
            
            
            
            
