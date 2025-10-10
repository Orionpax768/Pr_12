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

static string slovo(string[] text)
{
    string[] text = {" ", " ", " ", " ", " ", " "};
    return text 
}
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
            Console.Write("Введите слова:");
            slovo();
            string world = Convert.ToString(Console.ReadLine());
            int count = 0;
            while (true)
            {
                try
                {
                    if (world == " ")
                    {
                        break;
                    }
                    foreach (text in world)
                    {
                        count++;
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
                Console.WriteLine($"Слово: {world}");
                Console.WriteLine($"Встречается: {count}");
                Console.ReadKey();
            }
        }
    }
}

