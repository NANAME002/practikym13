using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = Input("day= ");
            Console.WriteLine($"{GetMonth(day)}");
            Console.ReadLine();
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static string GetMonth(int day)
        {
            switch (day)
            {
                case 1: return "Зима";
                case 2: return "Зима";
                case 3: return "Весна";
                case 4: return "Весна ";
                case 5: return "Весна ";
                case 6: return "Лето ";
                case 7: return "Лето";
                case 8: return "Лето";
                case 9: return "Осень ";
                case 10: return "Осень ";
                case 11: return "Осень";
                case 12: return "Зима";
                default: return "Ошибка";
            }
        }
        
    }
}
