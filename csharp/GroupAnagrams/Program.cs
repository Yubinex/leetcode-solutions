using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        Console.Write("[");
        foreach (List<string> strArr in sol.GroupAnagrams(strs))
        {
            Console.Write("[");
            foreach (string str in strArr)
            {
                Console.Write($"{str},");
            }
            Console.Write("],");
        }
        Console.Write("]");
    }
}

/*
Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]


Example 2:

Input: strs = [""]
Output: [[""]]


Example 3:

Input: strs = ["a"]
Output: [["a"]]
*/
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sortedStr = new string(chars);
            if (!anagramGroups.ContainsKey(sortedStr))
            {
                anagramGroups[sortedStr] = new List<string>();
            }
            anagramGroups[sortedStr].Add(str);
        }

        return new List<IList<string>>(anagramGroups.Values);
    }
}
