using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string subject = Input("предмет= ");
            Console.WriteLine($"{GetSubject(subject)}");
            Console.ReadLine();
        }
        static string Input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        static string GetSubject(string subject)
        {
            switch(subject)
            {
                case "ф": return "физика";
                case "м": return "математика";
                case "и": return "история";
                case "г": return "география";
                default:return "Ошибка";
            }
        }
    }
}
