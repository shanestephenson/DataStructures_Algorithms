using System;
using System.Collections.Generic;

namespace Arrays_Strings
{
  //Given two strings, write a method to decide if one is a permutation of the other

  //Again check assumptions. Is it case sensitive? Does white space matter?
  //Like is 'God' === 'dog' or 'god' === 'dog   ' ??

  //Key to solving this: if the two strings are not the same size then it won't work. 
  //If you sort the two strings alphabetically and compare and they are the same then they are a permutation of each other. 
  public class Permutations
  {

    public static bool PerformPermutations(string str1, string str2)
    {
      if (str1.Length != str2.Length)
      {
        return false;
      }

      return (Sort(str1).Equals(Sort(str2)));
    }

    private static string Sort(string input)
    {
      char[] characters = input.ToCharArray();
      Array.Sort(characters);
      return new string(characters);
    }
  }
}
