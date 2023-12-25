// Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку для проверки на палиндром:");
        string inputString = Console.ReadLine();
        bool isPalindrome = CheckIfPalindrome(inputString);

        Console.WriteLine($"Является ли строка \"{inputString}\" палиндромом? {isPalindrome}");
    }

    static bool CheckIfPalindrome(string str)
    {
        str = str.ToLower();
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}