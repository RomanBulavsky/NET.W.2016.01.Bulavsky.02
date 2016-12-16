using System;
using System.Collections;
using System.Linq;

namespace Logic
{
    public static class BitMixer
    {
        public static int Insertion(int numberA, int numberB, int i, int j)
        {
            IndexValidation(i, j);
            uint unsignedNumberA = (uint)numberA;   
            uint mask = ((uint)(((long)1 << j - i + 1) - 1));
            mask <<= i;//1111 0000 0000
            mask = uint.MaxValue - mask;// 1111 0000 1111 1111
            uint reverseMask = uint.MaxValue - mask;// 0000 1111 0000 0000
            unsignedNumberA &= mask;
            uint  insertationBits= ((uint)numberB) & reverseMask;
            unsignedNumberA += insertationBits;
            return (int)unsignedNumberA;
        }

        //custom "BitArray"
        public static int InsertionByChars(int numberA, int numberB, int i, int j)
        {
            IndexValidation(i, j);
            char[] baseArray = new char[32];
            baseArray = Enumerable.Repeat('0', 32).ToArray(); // 0{32}

            string strA = Convert.ToString(numberA, 2);
            char[] charA = new char[32];
            baseArray.CopyTo(charA, 0);
            strA.ToCharArray().CopyTo(charA, 32 - strA.Length);

            string strB = Convert.ToString(numberB, 2);
            char[] charB = new char[32];
            baseArray.CopyTo(charB, 0);
            strB.ToCharArray().CopyTo(charB, 32 - strB.Length);

            int k = sizeof(double) * 4 - 1 - i; //Bad practice magic numbers
            int z = 31 - j;

            for (; k >= z; k--)
                charA[k] = charB[k];

            return Convert.ToInt32(new string(charA), 2);
        }

        public static int InsertionByBitArray(int numberA, int numberB, int i, int j)
        {
            IndexValidation(i, j);
            var bitsA = new BitArray(BitConverter.GetBytes(numberA));
            var bitsB = new BitArray(BitConverter.GetBytes(numberB));

            for (; i <= j; i++)
                bitsA[i] = bitsB[i];

            var arr = new int[1];
            bitsA.CopyTo(arr, 0);
            return arr[0];
        }

        private static void IndexValidation(int i, int j)
        {
            if (i < sizeof(double) * 4 && i > j)
                throw new ArgumentException();
        }
    }
}

#region Conditions

/*
    Даны два целых знаковых четырехбайтовых числа и две позиции битов i и j (i<j).
    Реализовать алгоритм вставки одного числа в другое так, чтобы второе число 
    занимало позицию с бита j по бит i (биты нумеруются справа налево).
Например.

      *             j
            4-3-2-1-0
            0 1 0 0 0 -> 1st :8
            0 1 1 1 1 -> 2nd :15
            0 1 0 0 1 -> :9

Insertion(8,15,0,0) ->9
Insertion(0, 15, 30, 30) ->1073741824<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< 
Insertion(0, 15, 0, 30) -> 15
Insertion(15, -15, 0{4!!!!}, 4) -> 31 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
Insertion(15, int.MaxValue, 3, 5)->63

     */

#endregion