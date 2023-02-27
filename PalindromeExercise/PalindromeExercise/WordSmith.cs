using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{

    //Create a class named WordSmith in your PalindromeExercise project file.This is where you will eventually create your IsAPalindrome() method
    //In your WordSmith class, you will create a method(IsAPalindrome) that will take a parameter of type string and return a value of type bool.
    //If the given input is a palindrome – return true, else return false. You will finish this method after you write your tests.
    public class WordSmith
    {
       public bool  IsAPalindrome( string anwser) 
       {
            string Backwards = "";

            for (int i = anwser.Length-1; i >= 0; i--)
            {
                Backwards += anwser[i];
            }
            if (anwser == Backwards)
            {
                return true;
            }
            else 
            {
                return false;
            }
       }
    }
}
