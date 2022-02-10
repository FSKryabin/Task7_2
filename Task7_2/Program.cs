using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту ребра куба: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Высота ребра куба = {0}\n", h);
            double s = 6 * (h * h);
            double v = h * h * h;
            Console.Write("Площадь куба = {0} , объем куба = {1}", s, v);
            Console.ReadLine();
        }
    }
}
