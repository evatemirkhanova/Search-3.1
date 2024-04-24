using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3_proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];

            Random random = new Random();

            // Заполняем массив случайными числами и сразу сортируем его
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            
            // Создаем объект класса InsertionSort
            InsertionSort sorter = new InsertionSort();

            // Сортируем массив с использованием сортировки вставками
            sorter.Ins_Sort(array);

            // Можем вывести отстортированный массив, если захотим:
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", array));

            Console.WriteLine("Введите число X для поиска в массиве: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Вызываем метод для поиска числа в массиве
            int count = BinarySearchCount.BSC(array, number);

            Console.WriteLine("Сколько элементов равны X? - " + count);
        }
    }
}
