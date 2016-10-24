using System;
using System.Linq;

namespace Logic
{
    public static class StringHelper
    {
        
        public static string Longest(string str1, string str2)
        {
            string str = Filter(str1, str2);
            return Sort(str);
        }

        public static string CheatSolution(string str1, string str2)
        {
            string str = str1 + str2;
            
            str.OrderBy(c => c);
            string x = String.Concat(str.Distinct().OrderBy(c => c));// 1 line 1 solution

            return x;
        }

        private static string Filter(string str1, string str2)
        {
            string str = str1 + str2;
            char[] strArray = str.ToCharArray();

            char[] resultArray = new char[100];//TODO:

            bool contain = false;
            int j = 0;

            for (int i = 0; i < strArray.Length; i++)
            {
                char symbol = strArray[i];

                foreach (var resultSymbol in resultArray)
                {
                    if (symbol.Equals(resultSymbol))
                    {
                        contain = true;
                        break;
                    }

                }

                if (!contain)
                {
                    resultArray[j++] = symbol;

                }
                contain = false;

            }
            //TODO:
            char[] a = new char[j];

            for (int i = 0; i < j; i++)
            {
                a[i] = resultArray[i];
            }


            return new string(a);
        }

        private static string Sort(string str)
        {
            char[] a = str.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }
    }
}
/*
 
    Для двух строк, включающих только символы от 'a'  до  'z', вернуть конкатенированную отсортированную по алфавиту строку, исключая повторяющиеся символы.
Например.
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
Longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
Longest(a, a) -> "abcdefghijklmnopqrstuvwxyz

     */
