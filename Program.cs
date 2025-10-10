//*******************************************************************************************
// *Практическая работа №10                                                                  *
//* Выполнил: Абдуллаев Э.С., группа 2-ИСПд                                                 *
//* Задание:  массив = 10 найти кол-во и сумму элементов, значения которых кратны М         *
//*******************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            Console.Write("Введите слова: ");
            string[] word = Convert.ToString(Console.ReadLine()).Split(',');
            int count = 0;
            while (true)
            {
                try
                {
                    if (word.Length == 0)
                    {
                       Console.WriteLine("Ошибка, слова не введено");
                        continue;
                    }
                    foreach (string text in word)
                    {
                        if ()
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Введите слово поиска: ");
                    string search = Convert.ToString(Console.ReadLine());
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
                Console.WriteLine($"Слово: {word}");
                Console.WriteLine($"Встречается: {count}");
                Console.ReadKey();
            }
        }
    }
}
