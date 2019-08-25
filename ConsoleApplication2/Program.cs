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
            Console.WriteLine("Введите символы");
            string Str = Console.ReadLine();
            Check(Str);
            Console.ReadKey();
        }

        static bool Check(string Str)
        {
            char openBracket;
            Stack<char> stack = new Stack<char>();
            foreach (char symbol in Str)
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
                            return false;
                        }
                        openBracket = stack.Pop();
                        if (openBracket != '(')
                        {
                            Console.WriteLine("FALSE");
                            return false;
                        }
                        break;

                    case ']':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("FALSE");
                            return false;
                        }
                        openBracket = stack.Pop();
                        if (openBracket != '[')
                        {
                            Console.WriteLine("FALSE");
                            return false;
                        }
                        break;

                    case '}':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("FALSE");
                            return false;
                        }
                        openBracket = stack.Pop();
                        if (openBracket != '{')
                        {
                            Console.WriteLine("FALSE");
                            return false;
                        }
                        break;

                    case '>':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("FALSE");
                            return false;
                        }
                        openBracket = stack.Pop();
                        if (openBracket != '<')
                        {
                            Console.WriteLine("FALSE");
                            return false;
                        }
                        break;
                    default:
                        Console.WriteLine("FALSE");
                        return false;

                }

            }

            if (stack.Count == 0)
            {
                string A = "TRUE";
                Console.WriteLine($"{A}");
                return true;
            }

            else
            {
                string B = "FALSE";
                Console.WriteLine($"{B}");
                return false;
            }

        }

    }

}
