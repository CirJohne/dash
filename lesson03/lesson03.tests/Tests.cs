using System;
using Shouldly;
using Xunit;

namespace lesson03.tests
{
    public class Tests
    {

        [Fact]
        public void RotateArray()
        {
            var rotator = new Rotator();
            rotator.Rotate(new int[] {1,2,3,4}).ShouldBe(new int[] {2,3,4,1});
            rotator.Rotate(new int[] {4,5,6,7}).ShouldBe(new int[] {5,6,7,4});
        }
       
        [Fact]
        public void SmallestPartOfArrays()
        {
            var finder = new Finder();
            var firstArr = new int[]{5,33,1,8,3,2};
            var secondArr = new int[]{23,5454,2,3,745};
            var thirdArr = new int[]{45,76,4,878,3};
            var result = new int[]{1,2,3};
            finder.Smallest(firstArr, secondArr, thirdArr).ShouldBe(result);
        }

        [Fact]
        public void IsPalindrome()
        {
            var palindrome = new Palindrome();
            palindrome.IsPalindrome("hejsan").ShouldBe(false);
            palindrome.IsPalindrome("anna").ShouldBe(true);
            palindrome.IsPalindrome("Madam I'm Adam").ShouldBe(true);
        }

        [Fact]
        public void SortArrayOfObjects()
        {
            
            var sorter = new Sorter();
            var stefan = new TeamMember("Stefan","Champagne", 39);
            var johne = new TeamMember("Johne", "Whisky Sour", 39);
            var daria = new TeamMember("Daria", "Shots", 28);
            var niklas = new TeamMember("Niklas", "Beer", 41);
            var ulrika = new TeamMember("Ulrika", "Red Wine", 38);
            var soleman = new TeamMember("Soleman", "Sangria", 35);


            var arr = new TeamMember[] {stefan, johne};
            sorter.SortArrayOfObjectsByAge(arr).ShouldBe(new TeamMember[]{johne, stefan });
        }
    }
}
