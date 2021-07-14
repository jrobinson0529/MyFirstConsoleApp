using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            // get data from a user

            Console.WriteLine("Please enter your name...");
            name = Console.ReadLine();
            // This will not work because static types
            //name = 7;
           
            // 32 bit signed number
            int age = 27;

            // 64 bit signed number
            long bigNumber = 115;

            // 16 bit signed number
            short smallerNumbers = 10_000;

            double accountBalance = 0.57d;
            double accountBalanceNew = 0.57d;
            Console.WriteLine($"{name} is {age} years old. {bigNumber + smallerNumbers}");
            Console.WriteLine($"{name} has {accountBalance + accountBalanceNew}$");

            // var is a shorthand for the real type
            // type inference
            var myStuff = 5 * 5;
            // this still won't work
            // myStuff = "";

            var isTeaching = true;
            isTeaching = !isTeaching;

            var today = new DateTime(2019,5,12);
            Console.WriteLine(today);
            //arrays are not much fun in c#
            //var students = new string[5];
            Console.WriteLine(myStuff);

            // instance/ instantiation
            //list of string
            var students = new List<string>();

            students.Add("Hunter");
            students.Add(name);
            students.Add("Jimbo");

            students.Remove("Jimbo");

            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            // more idiomatic
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // if blocks are identical but no triple equality "=" for set "==" for equality
            if (isTeaching)
            {
                Console.WriteLine($"{name} is teaching.");
            } else
            {
                Console.WriteLine($"{name} is not teaching");
            }
        }

    }
}