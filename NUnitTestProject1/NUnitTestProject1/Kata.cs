using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1
{
    public class Kata
    {
        public int CalculDigitZero(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == '|' && Tab2[1] == ' ' && Tab2[2] == '|' &&
                Tab3[0] == '|' && Tab3[1] == '_' && Tab3[2] == '|')
            {
                return 0;
            }
            return -1;
        }
        public int CalculDigitUn(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == ' ' && Tab1[2] == ' ' &&
                Tab2[0] == ' ' && Tab2[1] == ' ' && Tab2[2] == '|' &&
                Tab3[0] == ' ' && Tab3[1] == ' ' && Tab3[2] == '|')
            {
                return 1;
            }
            return -1;
        }
        public int CalculDigitDeux(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == ' ' && Tab2[1] == '_' && Tab2[2] == '|' &&
                Tab3[0] == '|' && Tab3[1] == '_' && Tab3[2] == ' ')
            {
                return 2;
            }
            return -1;
        }
        public int CalculDigitTrois(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == ' ' && Tab2[1] == '_' && Tab2[2] == '|' &&
                Tab3[0] == ' ' && Tab3[1] == '_' && Tab3[2] == '|')
            {
                return 3;
            }
            return -1;
        }
        public int CalculDigitQuatre(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == ' ' && Tab1[2] == ' ' &&
                Tab2[0] == '|' && Tab2[1] == '_' && Tab2[2] == '|' &&
                Tab3[0] == ' ' && Tab3[1] == ' ' && Tab3[2] == '|')
            {
                return 4;
            }
            return -1;
        }
        public int CalculDigitCinq(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == '|' && Tab2[1] == '_' && Tab2[2] == ' ' &&
                Tab3[0] == ' ' && Tab3[1] == '_' && Tab3[2] == '|')
            {
                return 5;
            }
            return -1;
        }
        public int CalculDigitSix(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == '|' && Tab2[1] == '_' && Tab2[2] == ' ' &&
                Tab3[0] == '|' && Tab3[1] == '_' && Tab3[2] == '|')
            {
                return 6;
            }
            return -1;
        }
        public int CalculDigitSept(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == ' ' && Tab2[1] == ' ' && Tab2[2] == '|' &&
                Tab3[0] == ' ' && Tab3[1] == ' ' && Tab3[2] == '|')
            {
                return 7;
            }
            return -1;
        }
        public int CalculDigitHuit(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == '|' && Tab2[1] == '_' && Tab2[2] == '|' &&
                Tab3[0] == '|' && Tab3[1] == '_' && Tab3[2] == '|')
            {
                return 8;
            }
            return -1;
        }
        public int CalculDigitNeuf(List<char> Tab1, List<char> Tab2, List<char> Tab3)
        {
            if (Tab1[0] == ' ' && Tab1[1] == '_' && Tab1[2] == ' ' &&
                Tab2[0] == '|' && Tab2[1] == '_' && Tab2[2] == '|' &&
                Tab3[0] == ' ' && Tab3[1] == '_' && Tab3[2] == '|')
            {
                return 9;
            }
            return -1;
        }

        public string DigitEgal(List<char> tab1, List<char> tab2, List<char> tab3)
        {
            string digit = string.Empty;

            if (CalculDigitZero(tab1, tab2, tab3) != -1)
                return CalculDigitZero(tab1, tab2, tab3).ToString();

            if (CalculDigitUn(tab1, tab2, tab3) != -1)
                return CalculDigitUn(tab1, tab2, tab3).ToString();

            if (CalculDigitDeux(tab1, tab2, tab3) != -1)
                return CalculDigitDeux(tab1, tab2, tab3).ToString();

            if (CalculDigitTrois(tab1, tab2, tab3) != -1)
                return CalculDigitTrois(tab1, tab2, tab3).ToString();

            if (CalculDigitQuatre(tab1, tab2, tab3) != -1)
                return CalculDigitQuatre(tab1, tab2, tab3).ToString();

            if (CalculDigitCinq(tab1, tab2, tab3) != -1)
                return CalculDigitCinq(tab1, tab2, tab3).ToString();

            if (CalculDigitSix(tab1, tab2, tab3) != -1)
                return CalculDigitSix(tab1, tab2, tab3).ToString();

            if (CalculDigitSept(tab1, tab2, tab3) != -1)
                return CalculDigitSept(tab1, tab2, tab3).ToString();

            if (CalculDigitHuit(tab1, tab2, tab3) != -1)
                return CalculDigitHuit(tab1, tab2, tab3).ToString();

            if (CalculDigitNeuf(tab1, tab2, tab3) != -1)
                return CalculDigitNeuf(tab1, tab2, tab3).ToString();

            return digit;
        }

        public string GenerateNumCompte(string ligne1, string ligne2, string ligne3)
        {
            List<char> List1 = ligne1.ToList();
            List<char> List2 = ligne2.ToList();
            List<char> List3 = ligne3.ToList();
            string NumCompte = string.Empty;

            int i = 0;
            while (i <= List1.LongCount() - 4 && i <= List2.LongCount() - 4 && i <= List3.LongCount() - 4)
            {
                NumCompte += DigitEgal(new List<char> { List1[i], List1[i + 1], List1[i + 2] },
                                       new List<char> { List2[i], List2[i + 1], List2[i + 2] },
                                       new List<char> { List3[i], List3[i + 1], List3[i + 2] });
                i = i + 4;
            }

            return NumCompte;
        }
    }
}
