using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;

            Console.Write("Ange Temp i Grader i fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperaturen {fahrenheit} F motsvarar {celsius:f1} c.");
                
        }
    }
}
