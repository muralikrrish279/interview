using System;
using System.Collections;
using System.Collections.Generic;

class Anagrams
{
    // static void Main(string[] args)
    // {
    //     CollectAnagrams(new string[] { "aac", "bde", "caa", "dbe", "aca", "ebd", "edb", "ssss", "Murali", "almiur" });
    // }

    static void CollectAnagrams(string[] words)
    {
        var dict = new Dictionary<string, List<string>>();
        if (words.Length == 0)
        {
            Console.WriteLine("");
        }

        foreach (var item in words)
        {
            var arr = item.ToCharArray();
            Array.Sort(arr);
            var key = String.Join("", arr);
            if (dict.ContainsKey(key))
            {
                dict[key].Add(item);
            }
            else
            {
                dict.Add(key, new List<string>() { item });
            }
        }

        foreach (var item in dict)
        {
            foreach (var list in dict[item.Key])
            {
                Console.WriteLine(list);
            }
        }
    }



}


