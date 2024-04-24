using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3_proba
{
    internal class BinarySearchCount
    {
        // Метод для оптимизированного поиска числа в отсортированном массиве
        public static int BSC(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid;
            int count = 0;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                // Если число найдено, ищем сколько элементов равны ему
                if (array[mid] == number)
                {
                    count++;
                    // Проверяем элементы слева от найденного
                    int leftIndex = mid - 1;
                    while (leftIndex >= 0 && array[leftIndex] == number)
                    {
                        count++;
                        leftIndex--;
                    }
                    // Проверяем элементы справа от найденного
                    int rightIndex = mid + 1;
                    while (rightIndex < array.Length && array[rightIndex] == number)
                    {
                        count++;
                        rightIndex++;
                    }
                    return count;
                }
                // Если искомое число меньше, идем в левую часть массива
                else if (array[mid] > number)
                {
                    right = mid - 1;
                }
                // Если искомое число больше, идем в правую часть массива
                else
                {
                    left = mid + 1;
                }
            }
            // Если число не найдено
            return count;
        }
    }
}
