using System;

namespace Arrays_Strings
{
  public class IsUnique
  {
    //Implement an algorithm to determine if a string has all unique characters. 
    //What if you cannot use additional data structures.

    //One solution is to create an array of boolean values, where the flag at index i
    //indicates whether character i in the alphabet is contained in the string.
    //the decond time you see this character you can immediately return false

    //Time complexity is O(n) but could argue that it is O(1) 
    //because the for loop will never iterate through more than 128 characters
    //Space complexity is O(1)

    //If the string is greater than 128 then there must be two characters that are the same

    public static bool PerformIsUnique(string str)
    {
      if (str.Length > 128)
      {
        return false;
      }

      bool[] char_set = new bool[128];

      for (int i = 0; i < str.Length; i++)
      {
        int val = str[i]; //This is the ASCII int value of that string char

        if (char_set[val])
        {
          return false;
        }
        char_set[val] = true;
      }

      return true;
    }
  }
}
