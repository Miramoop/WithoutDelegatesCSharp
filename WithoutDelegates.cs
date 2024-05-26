//CSCI 436 - Assignment #5 - Delegates (function pointers)		       	          
// Miranda Morris		      										       
// 5/4/2024

// Write a C# program that demonstrates the passing a method into another method as a parameter without delegates.

using System;
using System.Collections.Generic;

namespace WithoutDelegateExample
{
    public class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            List<Students> students = new List<Students>()
                {
                    new Students {Name = "Abby", Age = 25},
                    new Students {Name = "Bobby", Age = 15},
                    new Students {Name = "Carly", Age = 19},
                    new Students {Name = "Danny", Age = 30},
                    new Students {Name = "Edward", Age = 45},
                    new Students {Name = "Favian", Age = 13},
                    new Students {Name = "Gabby", Age = 18}
                };

            GetStudentsListForMiddleSchool(students, "Middle School");
            GetStudentsListForHighSchool(students, "High School");
            GetStudentsListForUniversity(students, "University");

            Console.ReadLine();
        }

        public static bool CheckEligibleForMiddleSchool(Students s)
        {
            return s.Age >= 12 && s.Age <= 13;
        }

        public static bool CheckEligibleForHighSchool(Students s)
        {
            return s.Age >= 14 && s.Age > 17;
        }

        public static bool CheckEligibleForUniversity(Students s)
        {
            return s.Age >= 18;
        }


        public static void GetStudentsListForMiddleSchool(List<Students> students, string schoolname)
        {
            foreach (var item in students)
            {
                if (CheckEligibleForMiddleSchool(item))
                {
                    Console.WriteLine("{0} is eligible for {1}", item.Name, schoolname);
                }
            }
        }

        public static void GetStudentsListForHighSchool(List<Students> students, string schoolname)
        {
            foreach (var item in students)
            {
                if (CheckEligibleForHighSchool(item))
                {
                    Console.WriteLine("{0} is eligible for {1}", item.Name, schoolname);
                }
            }
        }

        public static void GetStudentsListForUniversity(List<Students> students, string schoolname)
        {
            foreach (var item in students)
            {
                if (CheckEligibleForUniversity(item))
                {
                    Console.WriteLine("{0} is eligible for {1}", item.Name, schoolname);
                }
            }
        }

    }
}
