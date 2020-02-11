using System;

namespace lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Rotator
    {
        public int[] Rotate(int[] arr)
        {
            return arr;
        }
    }

    public class Finder
    {
        public int[] Smallest(int[] arr1, int[] arr2, int[] arr3)
        {
            return arr1;
        }
    }

    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            return true;
        }
    }

    public class Sorter
    {
        public TeamMember[] SortArrayOfObjectsByAge(TeamMember[] arr)
        {
            return arr;
        }
    }
    public class TeamMember
    {
        string name {get; set;}
        string drink {get; set;}
        int age {get; set;}

        public TeamMember(string name, string drink, int age)
        {
            this.name = name;
            this.drink = drink;
            this.age = age;
        }
    }
  
}
 



