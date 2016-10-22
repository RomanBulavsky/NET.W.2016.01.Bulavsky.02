using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class StringHelper
    {
        public static string Filter(string str)
        {
            char[] strArray = str.ToCharArray();

            char[] resultArray = new char[25];//TODO:

            bool contain = false;
            int j = 0;

            for(int i = 0; i < strArray.Length; i++)
            {
                char symbol = strArray[i];

                foreach(var resultSymbol in resultArray)
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
                contain =  false;

            }
            //TODO:
            char[] a = new char[j];
            
            for(int i = 0; i < j; i++)
            {
                a[i] = resultArray[i];
            }
            

            return new string(a);
        }

        public static string Solute(string str)//TODO:
        {
            
            str.OrderBy(c => c);
            string x = String.Concat(str.Distinct().OrderBy(c => c));// 1 line 1 solution
            

            return x;
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
