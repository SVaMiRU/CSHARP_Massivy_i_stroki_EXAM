// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;

class Program
{
    static void Main()
    {
        // Задание двумерного массива символов
        char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };

        // Создание строки из символов массива
        string str = "";
        for (int i = 0; i < charArray.GetLength(0); i++)
        {
            for (int j = 0; j < charArray.GetLength(1); j++)
            {
                str += charArray[i, j];
            }
        }

        // Вывод результата
        Console.WriteLine(str); // Выведет "abcd"
    }
}