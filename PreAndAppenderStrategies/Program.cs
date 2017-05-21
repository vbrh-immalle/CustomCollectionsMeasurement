using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndAppenderStrategies
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new System.Collections.Stack();

            stack.Push("last in");
            stack.Push(3);
            stack.Push("first out");
            stack.Push("LIFO");

            Console.WriteLine(stack.Peek()); // we only peek, we don't pop
            Console.WriteLine(stack.Count); // all are still in
            Console.WriteLine(stack.Pop()); // we take out "LIFO"
            Console.WriteLine(stack.Pop()); // we take out "first out"
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count); // stack is empty

            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch(InvalidOperationException e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.GetType());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Data: "); Console.ResetColor();
                Console.WriteLine(e.Data);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("HelpLink: ");Console.ResetColor();
                Console.WriteLine(e.HelpLink);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("HResult: ");Console.ResetColor();
                Console.WriteLine(e.HResult);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Message: ");Console.ResetColor();
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Source: ");Console.ResetColor();
                Console.WriteLine(e.Source);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("StackTrace: ");Console.ResetColor();
                Console.WriteLine(e.StackTrace);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("TargetSite: ");Console.ResetColor();
                Console.WriteLine(e.TargetSite);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("ToString: ");Console.ResetColor();
                Console.WriteLine(e.ToString());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("END " + e.GetType());
            }

        }
    }
}
