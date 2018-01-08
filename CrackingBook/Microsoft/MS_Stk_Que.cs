using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Microsoft
{
    public class MS_Stk_Que
    {
        string[] braces(string[] values)
        {
            var result = new List<string>();
            foreach (var item in values)
            {
                var stk = new Stack<char>();
                foreach (var character in item)
                {
                    switch (character)
                    {
                        case '}':
                            if (stk.Peek() == '{')
                            {
                                stk.Pop();
                            }
                            break;
                        case ']':
                            if (stk.Peek() == '[')
                            {
                                stk.Pop();
                            }
                            break;
                        case ')':
                            if (stk.Peek() == '(')
                            {
                                stk.Pop();
                            }
                            break;
                        default:
                            stk.Push(character);
                            break;
                    }

                    if (stk.Count == 0)
                    {
                        result.Add("YES");
                    }
                    else
                    {
                        result.Add("NO");
                    }
                }
            }
            return result.ToArray();
        }

        int numberOfPairs(int[] a, long k)
        {
            if (a.Length <= 0)
            {
                return 0;
            }
            var dict = new Dictionary<int, int>();
            var hashSet = new Dictionary<string,int>();
            for (int i = 0; i < a.Length - 1; i++)
            {
                dict.Add(i, a[i]);
            }

            foreach (var item in dict)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (item.Value + a[i] == k)
                    {
                        if (!hashSet.ContainsKey(item.Key + "," + i) && !hashSet.ContainsKey(i + "," + item.Key)
                            && ((a[i] != hashSet[item.Key + "," + i]) || (a[item.Key] != hashSet[item.Key + "," + i])))
                            hashSet.Add(item.Key + "," + i,a[i]);
                    }
                }
            }
            return hashSet.Count();

        }
    }
}
