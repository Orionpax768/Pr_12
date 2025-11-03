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
        static void ProcessWordSearch(string input, string searchWord)
        {
            try
            {
                int count = 0;
                string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' });
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Ошибка: строка не может быть пустой!");
                }

                if (string.IsNullOrWhiteSpace(searchWord))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Ошибка: слово для поиска не может быть пустым!");
                }
                foreach (string word in words)
                {
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка:{fEx.Message}");
                Console.ResetColor();
            }
            catch (OverflowException oEx)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {oEx.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ResetColor();
            }
        }

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
                    Console.Write("Введите слово для поиска: ");
                    string searchWord = Console.ReadLine();
                    ProcessWordSearch(input, searchWord);
                }
                catch (FormatException fEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка:{fEx.Message}");
                    Console.ResetColor();
                }
                catch (OverflowException oEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {oEx.Message}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Новый поиск");
                Console.WriteLine("0 - Выйти из программы");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
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
