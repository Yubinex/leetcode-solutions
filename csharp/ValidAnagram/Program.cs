using System;
using System.Linq;
using System.Collections.Generic;

namespace ValidAnagram;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine($"Expected: True -> Actual {sol.IsAnagram("anagram", "nagaram")}");
        Console.WriteLine($"Expected: False -> Actual {sol.IsAnagram("rat", "car")}");
    }
}

/*
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true


Example 2:

Input: s = "rat", t = "car"
Output: false
*/
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> frequenciesS = new Dictionary<char, int>();
        Dictionary<char, int> frequenciesT = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (frequenciesS.ContainsKey(c)) { frequenciesS[c]++; }
            frequenciesS[c] = 1;
        }
        foreach (char c in t)
        {
            if (frequenciesT.ContainsKey(c)) { frequenciesT[c]++; }
            frequenciesT[c] = 1;
        }

        return frequenciesS.Count == frequenciesT.Count && frequenciesS.All(
            kv => frequenciesT.ContainsKey(kv.Key) && frequenciesT[kv.Key] == kv.Value);
    }
}
