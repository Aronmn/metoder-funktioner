using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_funktioner
{
    class Program
    {
            static void CelsiusTillFarenheit(double Celsius)
        {
            Console.WriteLine((Celsius/5.0)*9+32);
        }

            static double RaknaArea(double Radie)
        {
            return(Math.PI*Radie*Radie);
        }

            static double RaknaOmkrets(double Radie)
        {
            return(Radie * 2) * Math.PI;
        }


        static void Main(string[] args)
        {
            //Övning 1

            Console.WriteLine("Mata in antal grader i Celsius så omvandlar programmet det till Farenheit");
            double Celsius = double.Parse(Console.ReadLine());
            CelsiusTillFarenheit(Celsius);

            //Övning 2

            Console.WriteLine("Mata in cirkelns radie:");
            double Radie = double.Parse(Console.ReadLine());
            Console.WriteLine("Arean på cirkeln är:");
            Math.Round(RaknaArea(Radie),2);
            Console.WriteLine(RaknaArea(Radie));

            Console.Write("Omkresten är:");
            Math.Round (RaknaOmkrets(Radie),2);
            Console.WriteLine(RaknaOmkrets(Radie));

        }
    }
}
