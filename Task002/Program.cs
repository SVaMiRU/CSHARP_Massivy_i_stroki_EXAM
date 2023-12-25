// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main()
    {
        string originalString = "Hello World";
        string lowerCaseString = originalString.ToLower();

        Console.WriteLine(lowerCaseString); // Выведет "hello world"
    }
}