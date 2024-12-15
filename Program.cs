using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
/// Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник. 
/// Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип фигуры (к - круг, п - прямоугольник, т - треугольник):");
            char figure = Char.ToLower(Console.ReadKey().KeyChar); // Считываем символ и приводим его к нижнему регистру
            Console.WriteLine(); // Переход на новую строку

            if (figure == 'к')
            {
                // Круг
                Console.WriteLine("Введите радиус круга:");
                double radius = double.Parse(Console.ReadLine());

                double perimeter = 2 * Math.PI * radius;
                double area = Math.PI * radius * radius;

                Console.WriteLine($"Периметр круга: {perimeter:F2}");
                Console.WriteLine($"Площадь круга: {area:F2}");
            }
            else if (figure == 'п')
            {
                // Прямоугольник
                Console.WriteLine("Введите длину и ширину прямоугольника:");
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                double perimeter = 2 * (length + width);
                double area = length * width;

                Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
                Console.WriteLine($"Площадь прямоугольника: {area:F2}");
            }
            else if (figure == 'т')
            {
                // Треугольник
                Console.WriteLine("Введите длины трех сторон треугольника:");
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double side3 = double.Parse(Console.ReadLine());

                double perimeter = side1 + side2 + side3;
                // Для площади используем формулу Герона
                double semiPerimeter = perimeter / 2;
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

                Console.WriteLine($"Периметр треугольника: {perimeter:F2}");
                Console.WriteLine($"Площадь треугольника: {area:F2}");
            }
            else
            {
                Console.WriteLine("Неверный тип фигуры.");
            }


        }

    }
}
