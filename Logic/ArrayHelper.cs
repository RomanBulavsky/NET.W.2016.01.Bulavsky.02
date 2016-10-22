using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class ArrayHelper
    {
        public static int FindCentralIndex(int[] array)
        {
            if (array == null) return -1;

            
            for (int i = 0; i < array.Length; i++)
            {

                int leftSum = 0;
                int rightSum = 0;
                int index = i;

                for (int j = 0; j < array.Length; j++)
                {

                    if (index == 0 || index == (array.Length - 1)) break;

                    if (j < index )
                    {
                        leftSum += array[j];
                    }
                    else if (j > index)
                    {
                        rightSum += array[j];
                    }

                }

                if(leftSum == rightSum && (index != 0 && index != (array.Length - 1)))
                {
                    return index;
                }

            }

            return -1;
        }
    }
}
/*
 Дан массив целых чисел. Найти в массиве и вернуть такой индекс n, для которого сумма элементов слева 
 от него равно сумме элементов справа. Если такого индекса нет вернуть null (-1).
Например.
•	Для массива {1,2,3,4,3,2,1} функция вернет индекс 3, поскольку на 3-й
 позиции массива, суммы слева от индекса ({1,2,3}) и справа от индекса ({3,2, 1})
  равны 6.
•	Для массива {1,100,50, -51,1,1} функция вернет индекс 1, поскольку на 1-й 
позиции массива, суммы слева от индекса ({1}) и справа от индекса ({50, -51,1,1 }) 
равны 1.
Входные данные: Целочисленный массив длины 0 <length <1000. Числа в массиве могут быть любым целыми положительными или отрицательными.
Выходные данные: Наименьший индекс, для которого сторона слева равна стороне справа. Если такого индекса не существует вернуть -1(null).

     */
