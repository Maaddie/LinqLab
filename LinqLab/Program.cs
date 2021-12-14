using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine("The numbers are: ");

            foreach(int n in nums)
            {
                Console.WriteLine(n);
            }

            //Minimum Value
            int result = nums.Min();
            Console.WriteLine("Minimum Value: {0}", result);

            Console.WriteLine();

            //Maximum Value
            int result1 = nums.Max();
            Console.WriteLine("Maximum Value: {0}", result1);

            Console.WriteLine();

            //Find the Maximum value less than 10000
            var numbers = from n in nums
                         where n < 10000
                         select n;
            Console.WriteLine("Numbers less than 10000: ");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            //Find all the values between 10 and 100
            Console.WriteLine("Values between 10 and 100: ");
            int[] numsInRange = nums.Where(x => 10 <= x && x <= 100).ToArray();
            foreach(int num in numsInRange)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            //Find all the values between 100000 and 999999
            Console.WriteLine("Values between 100000 and 999999: ");
            int[] numsInRange2 = nums.Where(x => 100000 <= x && x <= 999999).ToArray();
            foreach (int num in numsInRange2)
            {
                Console.WriteLine(num);
            }

            //Count all the even numbers
            Console.WriteLine();
            Console.WriteLine("Count all the even numbers in the list: ");
            int[] evenNums = nums.Where(n => n % 2 == 0).ToArray();

            foreach(int even in evenNums)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine();

            //Find all students age 21 and over
            Console.WriteLine("All students of 21 and over are: ");
            List<Student> studentsDrinkingAge = students.Where(s => s.Age >= 21).ToList();
            foreach(Student s in studentsDrinkingAge)
            {
                Console.WriteLine(s.Name);
            }

            //Find the oldest Student
            Console.WriteLine();
            int oldestAge = students.Max(s => s.Age);
            List<Student> oldestStudent = students.Where(s => s.Age == oldestAge).ToList();
            foreach(Student s in oldestStudent)
            {
                Console.WriteLine("Age of oldest student is: " + s.Age);
            }

            //Find the youngest Student
            Console.WriteLine();
            int youngestAge = students.Min(s => s.Age);
            List<Student> youngestStudent = students.Where(s => s.Age == youngestAge).ToList();
            foreach (Student s in youngestStudent)
            {
                Console.WriteLine("Age of youngest student is: " + s.Age);
            }

            //Find the oldest student under the age of 25
            Console.WriteLine();
            int oldestStu = students.Max(s => s.Age);
            List<Student> studentsUnder25 = students.Where(s => s.Age < 25).ToList();
            int oldestStudentUnder25 = studentsUnder25.Max(s => s.Age); //made subset of bigger set(List) and then checked for max age within the subset.

            Console.WriteLine("Oldest student under 25 is: " + oldestStudentUnder25);

            //Find all students over 21 with even ages
            Console.WriteLine();
           
            List<Student> evenAgesOver21 = students.Where(s => s.Age >21 && s.Age % 2 == 0).ToList();
            foreach(Student s in evenAgesOver21)
            {
                Console.WriteLine("Students age even and over 21 is " + s.Age);
            }

            //Find all teenage students (13-19 inclusive)
            Console.WriteLine();
            List<Student> teenageStudents = students.Where(s => 13 <= s.Age && s.Age <= 19).ToList();
            Console.WriteLine("All teenage students between 13 and 19 are: ");
            foreach(Student s in teenageStudents)
            {
                Console.WriteLine(s.Age);
            }

            //Find all students whose names starts with a vowel
            Console.WriteLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            List<Student> startsWithVowel = students.Where(s => s.Name.ToLower().StartsWith('a') || s.Name.ToLower().StartsWith('e') || s.Name.ToLower().StartsWith('i') || s.Name.ToLower().StartsWith('o') || s.Name.ToLower().StartsWith('u')).ToList();
            Console.WriteLine("Students whose names start with a vowel are: ");
            foreach(Student s in startsWithVowel)
            {
                Console.WriteLine(s.Name);
            }
        
        }
    }
}
