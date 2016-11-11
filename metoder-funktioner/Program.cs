using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_funktioner
{
    class Program
    {
        public static void CelsiusTillFarenheit(double Celsius)
        {
            Console.WriteLine((Celsius/5.0)*9+32);
        }
        static void Main(string[] args)
        {
            //Övning 1
            Console.WriteLine("Mata in antal grader i Celsius så omvandlar programmet det till Farenheit");
            double Celsius = double.Parse(Console.ReadLine());
            CelsiusTillFarenheit(Celsius);
        }
    }
}
