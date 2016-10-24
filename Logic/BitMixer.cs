using System;
using System.Collections;
using System.Linq;

namespace Logic
{
    public static class BitMixer
    {
        public static int InsertationByChars(int a, int b, int i, int j)
        {
            char[] baseArray = new char[32];
            baseArray = Enumerable.Repeat('0', 32).ToArray();// 0{32}

            string strA = Convert.ToString(a, 2);
            char[] charA = new char[32];
            baseArray.CopyTo(charA, 0);

            strA.ToCharArray().CopyTo(charA, 32 - strA.Length);




            string strB = Convert.ToString(b, 2);
            char[] charB = new char[32];
            baseArray.CopyTo(charB, 0);


            strB.ToCharArray().CopyTo(charB, 32 - strB.Length);


            int k = 31 - i;
            int z = 31 - j;

            for (; k >= z; k--)
            {
                charA[k] = charB[k];
            }


            return Convert.ToInt32(new string(charA), 2);

        }
        public static int InsertationByBitArray(int a, int b, int i, int j)
        {

            byte[] arra = BitConverter.GetBytes(a);
            byte[] arrb = BitConverter.GetBytes(b);
            var bitsA = new BitArray(arra);
            var bitsB = new BitArray(arrb);


            int k = i;
            int z = j;

            for (; k <= z; k++)
            {
                bitsA[k] = bitsB[k];
            }


            int[] arr = new int[1];
            bitsA.CopyTo(arr, 0);
            a = arr[0];
            return a;
           

        }
    }
}
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
Insertion(15, -15, 0, 4) -> 31 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
Insertion(15, int.MaxValue, 3, 5)->63

     */
