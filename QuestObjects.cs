using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGUtil
{
    public class QuestObjects
    {
        public enum Antagonists
        {
            Humanoid = 1,
            Natural_Beast = 2,
            Unnatural_Monster = 3,
            Undead = 4,
        }

        public enum Quantities
        {
            One = 1,
            Two = 2,
            Three = 3,
            Handful = 4,
            Group = 5,
            Band = 6,
            Pack = 7,
            Horde = 8,
            Army = 9,
        }

        public static string GetDisplayForQuantityOfAntagonists(Antagonists a, Quantities q)
        {
            string result;
            switch(q)
            {
                case Quantities.One:
                    result = "a ";
                    break;
                case Quantities.Two:
                    result = "two ";
                    break;
                case Quantities.Three:
                    result = "three ";
                    break;
                case Quantities.Handful:
                    result = "a handful of ";
                    break;
                case Quantities.Group:
                    result = "a group of ";
                    break;
                case Quantities.Band:
                    result = "a band of ";
                    break;
                case Quantities.Pack:
                    result = "a pack of ";
                    break;
                case Quantities.Horde:
                    result = "a horde of ";
                    break;
                case Quantities.Army:
                    result = "an army of  ";
                    break;
                default:
                    result = "some ";
                    break;
            }

            switch(a)
            {
                case Antagonists.Humanoid:
                    result += "humanoid";
                    if(q != Quantities.One)
                    {
                        result += "s";
                    }
                    break;
                case Antagonists.Natural_Beast:
                    result += "beast";
                    if (q != Quantities.One)
                    {
                        result += "s";
                    }
                    break;
                case Antagonists.Unnatural_Monster:
                    result += "monster";
                    if (q != Quantities.One)
                    {
                        result += "s";
                    }
                    break;
                case Antagonists.Undead:
                    if (q == Quantities.One)
                    {
                        result = "an ";
                    }
                    result += "undead";
                    break;
                default:
                    result += "bad guy";
                    if (q != Quantities.One)
                    {
                        result += "s";
                    }
                    break;
            }

            return result;
        }

        public enum Conflicts
        {
            Military = 1,
            Mystery = 2,
            Political = 3,
            Economical = 4,
            Natural = 5,
            Religious = 6,
            Social = 7
        }
    }
}
