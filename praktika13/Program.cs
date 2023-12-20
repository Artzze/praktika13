using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "alphabet.txt"; // Укажите здесь путь к вашему файлу с алфавитом

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int symbolCode;
                while ((symbolCode = reader.Read()) != -1) // Считывание файла посимвольно
                {
                    char symbol = (char)symbolCode;
                    if ((symbol >= 'A' && symbol <= 'Z') || (symbol >= 'a' && symbol <= 'z'))
                    {
                        Console.WriteLine($"Символ: {symbol}, Код: {symbolCode}");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла ошибка при чтении файла: {e.Message}");
        }
    }
}
