using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sign = Input("признак транспортного средства= ");
            Console.WriteLine($"{Sign(sign)}");
            Console.ReadLine();
        }
        static string Input(string message)
        {
            Console.WriteLine(message); 
            return Console.ReadLine();
        }
        static string Sign(string sign)
        {
            switch(sign)
            {
                case "a":return "490,5 км/ч";
                case "в":return "170 км/ч";
                case "м": return "613 км/ч";
                case "с": return "7 274 км/ч.";
                case "п": return "202.7 км/ч";
                default: return "Ошибка";
            }
        }
    }
}
