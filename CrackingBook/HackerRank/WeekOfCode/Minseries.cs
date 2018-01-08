using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.HackerRank.WeekoofCode
{
    public class Minseries
    {
        //min(int, min(int, min(int, int)))
        public void test() {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 2 || n >= 50) {
                Console.WriteLine("Invalid Input");
            }
            var simpleString = ",int";
            for (int i = 0; i < n-1; i++)
            {
                simpleString = simpleString.Replace(",int", ",min(int,int)");
            }
            Console.WriteLine(simpleString.Substring(1));
        }

//        8 4
//3 1 7 5
        public void test2() {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int newCandies = 0;
            int counter = 0;
            int existing = n;
            while (t != 0) {
                if(c[counter] > n)
                {
                    return;
                }
                existing -= c[counter];
                if (existing < 5 && t != 1) {
                    newCandies += n - existing;
                    existing += newCandies;
                }
                counter++;
                t--;
            }
            Console.WriteLine(newCandies);
        }

//        Jeremy and Clara are learning about passwords and created a game to test their "hacking" skills.Jeremy made rules for valid passwords and Clara needs to write a program to generate all possible passwords that meet those rules.Jeremy's rules are these:

//a password consists of exactly lowercase English letters.
//the password is melodious, meaning that consonants can only be next to vowels and vowels can only be next to consonants.Example: bawahaha
//the password cannot contain the letter  (because it's both a consonant and vowel).
//the first letter of the password can be either a vowel or consonant.
        public void test3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
