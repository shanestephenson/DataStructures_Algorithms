using System;

/* 
  Write a method to replace all spaces in a string with '%20'. 
  You may assume that the string has sufficient space at the end to hold the additional characters, 
  and that you are given the "true" length of the string. 

  REMEMBER:
  Manipulating a string is much easier if you work on the string backwards. 

  APPROACH:
  Two scan approach.
  In the first scan, count the number of spaces and triple it ('%20') to get the new length of the string.
  In the second scan, done in reverse, edit the string. If we see a space, replace it with %20.
*/

namespace Arrays_Strings
{
  public class URLify
  {
    public static string PerformURLify(char[] str, int trueLength)
    {
      int spaceCount = 0;
      int index = 0;
      int i = 0;

      for (i = 0; i < trueLength; i++)
      {
        if (str[i] == ' ')
        {
          spaceCount++;
        }
      }

      index = trueLength + spaceCount * 2;

      if (trueLength < str.Length) str[trueLength] = '\0';

      for (i = trueLength - 1; i >= 0; i--)
      {
        if (str[i] == ' ')
        {
          str[index - 1] = '0';
          str[index - 2] = '2';
          str[index - 3] = '%';
          index = index - 3;
        }
        else
        {
          str[index - 1] = str[i];
          index--;
        }
      }

      return new string(str);
    }
  }
}
