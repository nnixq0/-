using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{

    static void Main()
    /// Ввод размеров массивов
    {
        Console.Write("Введите размер массива А: ");
        int sizeA = int.Parse(Console.ReadLine());

        Console.Write("Введите размер массива B: ");
        int sizeB = int.Parse(Console.ReadLine());

        /// Создание и заполнение исходных массивов случайными числами

        Random rand = new Random();
        int[] arrayA = new int[sizeA];
        int[] arrayB = new int[sizeB];

        Console.WriteLine("\nМассив A:");
        for (int i = 0; i < sizeA; i++)
        {
            arrayA[i] = rand.Next(-100, 300);
            Console.Write($"{arrayA[i]} ");
        }

        Console.WriteLine("\n\nМассив B:");
        for (int i = 0; i < sizeB; i++)
        {
            arrayB[i] = rand.Next(-100, 300);
            Console.Write($"{arrayB[i]} ");
        }
        /// Создание массива для положительных элементов  

        int[] arrayC = new int[sizeA + sizeB];
        int index = 0;

        /// Копирование положительных элементов

        CopyPositiveElements(arrayA, arrayC, ref index);
        CopyPositiveElements(arrayB, arrayC, ref index);

        /// Удаление лишних элементов из массива C

        Array.Resize(ref arrayC, index);

        Console.WriteLine("\n\nМассив C (только положительные элементы):");
        foreach (int num in arrayC)
        {
            Console.Write($"{num} ");
        }
        /// Проверяем массив на пустоту  
        if (arrayC.Length == 0)
        {
            /// Выводим сообщение, если массив пустой  
            Console.WriteLine("Массив пуст!");
        }
        Console.WriteLine("\nСреднее арифм.массива С");
        Console.Write(array(arrayC));
    }
    static int array(int[] array)   
// среднее арифметическое массива с   
{   
    int sum = 0;   
    for (int i = 0 ; i <= array.Length-1; i++)   
    {   
        sum += array[i];   
    }   
    return sum /= array.Length;   
}

    static void CopyPositiveElements(int[] source, int[] destination, ref int destIndex)
    {
        foreach (int num in source)
        {
            if (num > 0)
            {
                destination[destIndex] = num;
                destIndex++;
            }
        }
    }
}
// ахахаха
