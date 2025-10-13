//*******************************************************************************************
//* Практическая работа №12                                                                 *
//* Выполнил: Абдуллаев Э.С., группа 2-ИСПд                                                 *
//* Задание: Подсчёт количества вхождений слова в строке                                    *
//*******************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа №12";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Здравствуйте!");
            while (true)
            {
                try
                {
                    Console.Write("Введите строку со словами (через пробел): ");
                    string input = Console.ReadLine();
                    string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' });
                    Console.Write("Введите слово для поиска: ");
                    string searchWord = Console.ReadLine();
                    int count = 0;
                    foreach (string word in words)
                    {
                        if (string.IsNullOrWhiteSpace(word))
                        {
                            throw new Exception("Ошибка: строка не может быть пустой!");
                        }
                        if (word.ToLower() == searchWord.ToLower())
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Слово для поиска: {searchWord}");
                    if (count == 0)
                    {
                        Console.WriteLine("Слово не найдено в строке");
                    }
                    else
                    {
                        Console.WriteLine($"Кол-во вхождений: {count}");
                    }
                }
                catch (FormatException fEx)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка:{fEx.Message}");
                    Console.ResetColor();
                    continue;
                }
                catch (OverflowException oEx)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {oEx.Message}");
                    Console.ResetColor();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    Console.ResetColor();
                    continue;
                }
                Console.BackgroundColor= ConsoleColor.Blue;
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Новый поиск");
                Console.WriteLine("0 - Выйти из программы");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                Console.ResetColor();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Новый поиск...");
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Программа завершена.");
                        Console.ReadKey();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный выбор! Программа будет продолжена.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
