using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class BitMixer
    {
        public static int Insertation(int a,int b, int i, int j)
        {
            byte[] arra = BitConverter.GetBytes(a);
            byte[] arrb = BitConverter.GetBytes(b);
            var bitsA = new BitArray(arra);
            var bitsB = new BitArray(arrb);

            for(int k = i; k <= j; k++)
            {
                bitsA[k] = bitsB[k];   
            }

            int[] arr = new int[1];
            bitsA.CopyTo(arr, 0);
            a = arr[0];
            return a;
            //return (int)bitsA;
            /*
             * j   i
             4-3-2-1-0
             0 1 0 0 0 -> 1st :8
             0 1 1 1 1 -> 2nd :15
             0 1 0 0 1 -> :9
             
             */
        }

    }
}
/*
 
    Даны два целых знаковых четырехбайтовых числа и две позиции битов i и j (i<j).
    Реализовать алгоритм вставки одного числа в другое так, чтобы второе число 
    занимало позицию с бита j по бит i (биты нумеруются справа налево).
Например.
Insertion(8,15,0,0) ->9
Insertion(0, 15, 30, 30) ->1073741824
Insertion(0, 15, 0, 30) -> 15
Insertion(15, -15, 0, 4) -> 31
Insertion(15, int.MaxValue, 3, 5)->63

     */
