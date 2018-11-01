using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGUtil
{
    public class Roller
    {
        static Random myRand = new Random();

        public static int Roll(int Count, int Sides)
        {
            return Roll(Count, Sides, true);
        }
        public static int Roll(int Count, int Sides, bool show)
        {
            int result = 0;
            for (int i = 0; i < Count; i++)
            {
                int d = (myRand.Next(Sides) + 1);

                if (Count > 1)
                {
                    if (show)
                    {
                        Form1.CurrentForm.Output($"D{Sides} ({i + 1}): {d}");
                    }

                    Thread.Sleep(50);
                }

                result += d;
            }

            if (show)
            {
                Form1.CurrentForm.Output($"{Count}D{Sides}: {result}");
            }
            return result;
        }

        public static int RollAbility()
        {
            return RollAbility(true);
        }
        public static int RollAbility(bool show)
        {
            int[] rolls = new int[4];
            rolls[0] = Roll(1, 6, false);
            rolls[1] = Roll(1, 6, false);
            rolls[2] = Roll(1, 6, false);
            rolls[3] = Roll(1, 6, false);

            string display = $"{rolls[0]}, {rolls[1]}, {rolls[2]}, {rolls[3]}: ";

            Array.Sort(rolls);

            int total = 0;
            for (int i = rolls.Count() - 1; i > 0; i--)
            {
                total += rolls[i];
            }

            display += total;

            if (show)
            {
                Form1.CurrentForm.Output(display);
            }

            return total;
        }

        public static int RandomEnum(Type t)
        {
            Array vals = Enum.GetValues(t);
            int r = Roll(1, vals.Length, false);
            return (int)vals.GetValue(r - 1);
        }

        public static string RandomEnumName(Type t)
        {
            Array vals = Enum.GetValues(t);
            int r = Roll(1, vals.Length, false);
            return vals.GetValue(r - 1).ToString();
        }
    }
}
