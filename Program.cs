using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
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
            switch(day)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "март";
                case 4: return "апрель";
                case 5: return "май ";
                case 6: return "июнь ";
                case 7: return "июль";
                case 8: return "август";
                case 9: return "сентябрь ";
                case 10: return "октябрь ";
                case 11: return "ноябрь";
                case 12: return "декабрь";
                default: return "Ошибка";
            }
            
        }
    }
}
