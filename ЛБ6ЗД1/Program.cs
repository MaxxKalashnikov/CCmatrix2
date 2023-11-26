using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ЛБ6ЗД1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод необходимых переменных
            const int COUNT = 5; // Вводим количество строк и столбцов
            int[,] arr = new int[COUNT, COUNT]; // Инициализируем двумерный массив
            int max1 = 0, max2 = 0; // Значения для максимума и минимума
            Random random = new Random();
            // Заполнение массива случайными числами
            for (int row = 0; row < COUNT; row++) // строки
                for (int col = 0; col < COUNT; col++) // столбцы
                    arr[row, col] = random.Next(51); // от 0 до 51
            // Вывод массива на экран
            for (int row = 0; row < COUNT; row++)
            {
                for (int col = 0; col < COUNT; col++)
                    Console.Write(arr[row, col] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
            // Нахождение max элемента ниже ПОБОЧНОЙ диагонали
            for (int row = 0; row < COUNT; row++) 
            {
                for (int col = COUNT - row; col < COUNT; col++)
                { 
                    if (arr[row, col] > max1) // Условие максимума
                    {
                        max1 = arr[row, col]; // Присвоение значения                       
                    }
                } 
            }
            // Нахождение max элемента выше ПОБОЧНОЙ диагонали
            for (int row = 0; row < COUNT; row++)
            {
                for (int col = 0; col < COUNT - row - 1; col++)
                {
                    if (arr[row, col] > max2) // Условие максимума
                    {
                        max2 = arr[row, col]; // привоение значения
                    }
                }
            }
            // Производим замену элементов
            for (int row = 0; row < COUNT; row++)
            {
                for (int col = 0; col < COUNT; col++)
                {
                    if (arr[row, col] == max1) // Заменяем местами макс1 и макс2
                    {
                        arr[row, col] = max2;;
                    }
                    else
                    {
                        if (arr[row, col] == max2)
                        {
                            arr[row, col] = max1;
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Максимальный элемент ВЫШЕ побочной диагонали : " + max2);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Максимальный элемент НИЖЕ побочной диагонали : " + max1);
            Console.ResetColor();
            Console.WriteLine("Измененная матрица: ");
            // Выводим готовый массив на экран
            for (int row = 0; row < COUNT; row++)
            {
                for (int col = 0; col < COUNT; col++)
                
                    Console.Write(arr[row, col] + "\t");
                    Console.WriteLine();
                
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
