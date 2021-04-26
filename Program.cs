using System;

namespace TemaProiectPIU
{
    internal class Program
    {
        private static void Main()
        {
            Car masinaT1 = new Car("Opel,Astra 1.4,2009,albastru,3000,Machiaveli Jo,Romeo Sane,26.04.2021," +
                "ABS,Geamuri electrice,Clima,Senzori parcare");
            masinaT1.ShowCar();
            Car masinaT2 = new Car("Audi,A4 1.9TDI,2010,Negru,5000,Maveli Ko,Rom Eo,23.02.2021," +
                "ABS,Geamuri electrice,Clima,Senzori parcare,Trapa");

            Console.Write(masinaT1.ConvertToString());

            Car comparare = new Car();
            comparare = Car.PriceCompare(masinaT1, masinaT2);
            Console.WriteLine("\n--------------------");
            Console.WriteLine("\n" + comparare.ConvertToString());

            Console.ReadKey();
        }
    }
}