using System;
using System.Collections;
using System.Collections.Generic;

    class DiceRoll
    {
        static void Main(string[] args)
        {
            //diceRolls(3);
            diceRolls(3, 10);
        }        

        static void diceRolls(int dice, int faceTotal = 0)
        {

            diceRollsHelper(dice, new List<int>(), faceTotal);
        }

        static void diceRollsHelper(int dice, List<int> chosen, int faceTotal = 0)
        {
            if (dice == 0)
            {

                var output = "";
                var sum = 0;
                foreach (var item in chosen)
                {
                    output += item;
                    sum += item;
                }
                if (faceTotal > 0)
                {
                    if (sum == faceTotal)
                        Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine(output);
                }

            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    chosen.Add(i);
                    diceRollsHelper(dice - 1, chosen, faceTotal);
                    chosen.Remove(i);
                }
            }

        }


    }


