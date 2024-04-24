using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMessageBoards.Utilities
{
    public static class StringExtensions
    {
        public static string RemoveLastOccurrence(this string source, string substring)
        {
            // Find the last index of the substring
            int lastIndex = source.LastIndexOf(substring);

            if (lastIndex == -1)
            {
                // Substring not found, return the original string
                return source;
            }
            else
            {
                // Remove the substring starting from its last occurrence
                return source.Remove(lastIndex, substring.Length);
            }
        }

        public static (string,string) SplitSentenceIntoFirstWordAndRestOfScentence(this string source)
        {
          
            int firstSpaceIndex = source.IndexOf(' ');

            if (firstSpaceIndex != -1) // Check if there is a space
            {
                string firstWord = source.Substring(0, firstSpaceIndex);
                string restOfString = source.Substring(firstSpaceIndex + 1); // +1 to skip the space

                return (firstWord, restOfString);
            }
            else
            {
                throw new Exception($"no space in string provided ${source}");
            }
        }
    }

}
