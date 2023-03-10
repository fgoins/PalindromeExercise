using PalindromeExercise;
using System;
using System.Data.SqlTypes;
using Xunit;

namespace PalindromeExerciseTests
{
    //Make sure the PalindromeExerciseTests project file has PalindromeExercise added as a reference.
    //→ Right click Dependencies in PalindromeExerciseTests to check and add a Project Reference if need
    //

    //Create a class named WordSmith in your PalindromeExercise project file.This is where you will eventually create your IsAPalindrome() method
    //In your WordSmith class, you will create a method(IsAPalindrome) that will take a parameter of type string and return a value of type bool. If the given input is a palindrome – return true, else return false. You will finish this method after you write your tests.
    //Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file

    //In UnitTest1.cs, remove the Fact portion and replace it with:
    public class UnitTest1
    {
        [Theory]
        [InlineData("Palindrome", false)] // ← you will need to put some test data and expected result here.
        [InlineData("money", false)]
        [InlineData("milli", false)]
        [InlineData("kayak", true)]
        [InlineData("bob", true)]

        // For example [InlineData(“racecar”, true)]
        public void IsAPalindromeTest(string anwser, bool expected)
        {
            //Arrange,
            var P = new WordSmith();
            
            //Act,
            var actual = P.IsAPalindrome(anwser);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
