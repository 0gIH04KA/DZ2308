using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApplication1
{
    public class Program
    {
        static void Main()
        {
            Print();
            Console.ReadKey();
        }


        static void stringСomparison()
            //Сравнить две строки вводимые пользователем
        {
            Console.WriteLine("Введите первую строку:");
            string firstString = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string secondString = Console.ReadLine();

            if (firstString.Length == secondString.Length)
            {
                for (int i = 1; i <= firstString.Length; i++)
                {
                    if (firstString.Substring(i) == secondString.Substring(i))
                    {
                        Console.WriteLine($"{i}-й символ одинаковый");
                    }
                    else
                    {
                        Console.WriteLine("Строки разные");
                        break;
                    }

                }

            }
            else
            {
                Console.WriteLine("Длина срок разная");
            }

        }

        static void Palindrom()
            //Проверить вводимую строку на полиндром 
        {
            string palindromString = Console.ReadLine();
            palindromString = palindromString.ToLower();
            palindromString = palindromString.Replace(" ", "");

            for (int i = 1; i < palindromString.Length; i++)
            {
                if (palindromString[i] != palindromString[palindromString.Length - i - 1])
                {
                    Console.WriteLine("false");
                    break;
                }
                else
                {
                    Console.WriteLine("true");
                }

            }

        }

        static void сheckBracket()
            //Проверка скобок
        {
            Console.WriteLine("Введите символы");
            string myStr = Console.ReadLine();

            char openBracket;
            Stack<char> stack = new Stack<char>();
            foreach (char symbol in myStr)
            {
                switch (symbol)
                {
                    case '(':
                    case '[':
                    case '{':
                    case '<':

                        stack.Push(symbol);
                        break;

                    case ')':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("FALSE");

                        }
                        openBracket = stack.Pop();
                        if (openBracket != '(')
                        {
                            Console.WriteLine("FALSE");

                        }
                        break;

                    case ']':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("FALSE");
                            
                        }
                        openBracket = stack.Pop();
                        if (openBracket != '[')
                        {
                            Console.WriteLine("FALSE");
                            
                        }
                        break;

                    case '}':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("FALSE");

                        }
                        openBracket = stack.Pop();
                        if (openBracket != '{')
                        {
                            Console.WriteLine("FALSE");
                            
                        }
                        break;

                    case '>':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("FALSE");
                           
                        }
                        openBracket = stack.Pop();
                        if (openBracket != '<')
                        {
                            Console.WriteLine("FALSE");
                           
                        }
                        break;

                    default:
                        Console.WriteLine("FALSE");
                        break;
                     
                }

            }

            if (stack.Count == 0)
            {
                string A = "TRUE";
                Console.WriteLine($"{A}");
                
            }

        }

        static void Print()
        {
            Console.WriteLine(@"Первое задание
    Введите две строки для сравнения");
            stringСomparison();
            Console.WriteLine("");

            Console.WriteLine(@"Второе задание
    Проверка строки на палиндром");
            Palindrom();
            Console.WriteLine("");

            Console.WriteLine(@"Третье задание
    Введите комбинацию скобок ");
            сheckBracket();

        }

    }

}
