// // Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку из слов, разделенных пробелами:");
        string inputString = Console.ReadLine();
        string reversedString = ReverseWords(inputString);

        Console.WriteLine($"Результат: {reversedString}");
    }

    static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}