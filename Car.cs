using System;
using System.Collections.Generic;

/*
La un târg de mașini trebuie înregistrate toate mașinile care au fost vândute (cumpărate).
Pentru fiecare mașină se vor indica: nume vânzător, nume cumpărător, tip mașină (nume
firmă + model, exp.: Firma: Opel, Model: Astra 1.4), an fabricație, culoare, optiuni, data
tranzacție, preț. Pe lângă operațiile de introducere, editare și ștergere, aplicația trebuie să
afișeze următoarele rapoarte:
• cea mai căutată mașină ca și firmă sau ca model, într-o anumită perioadă;
• un grafic al prețului pentru un anumit model, pe o anumită perioadă de timp;
• afișarea tranzacțiilor dintr-o anumită zi.
Observație: la introducerea unei noi tranzacții, se va avertiza printr-un mesaj dacă există o
persoană care cumpără mai multe mașini în aceeași zi sau dacă o persoană vinde mai multe
mașini în aceeași zi.
*/

namespace TemaProiectPIU
{
    internal class Car
    {
        public string NumeVanzator { get; set; }
        public string NumeCumparator { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public string Culoare { get; set; }
        public List<string> Optiuni { get; set; }
        public DateTime DataTranzactie { get; set; }
        public float Pret { get; set; }

        public Car(){}

        public Car(string info)
        {
            string[] splitInfo = info.Split(',');
            Firma = splitInfo[0];
            Model = splitInfo[1];
            AnFabricatie = int.Parse(splitInfo[2]);
            Culoare = splitInfo[3];
            Pret = int.Parse(splitInfo[4]);
            NumeVanzator = splitInfo[5];
            NumeCumparator = splitInfo[6];
            DataTranzactie = DateTime.Parse(splitInfo[7]);
            List<string> opt = new List<string>();
            for (int i = 8; i < splitInfo.Length; i++)
                opt.Add(splitInfo[i]);
            Optiuni = opt;
        }

        public void ShowCar()
        {
            Console.WriteLine($"{"Firma",-20} {Firma,-10}");
            Console.WriteLine($"{"Model",-20} {Model,-10}");
            Console.WriteLine($"{"An Fabricatie",-20} {AnFabricatie,-10}");
            Console.WriteLine($"{"Culoare",-20} {Culoare,-10}");
            Console.WriteLine($"{"Pret",-20} {Pret + " Euro",-10}");
            Console.WriteLine($"{"Nume Vanzator",-20} {NumeVanzator,-10}");
            Console.WriteLine($"{"Nume Cumparator",-20} {NumeCumparator,-10}");
            Console.WriteLine($"{"Data tranzactie",-20} {DataTranzactie.ToString("dd.MMMM.yyyy"),-10}");
            Console.WriteLine($"{"Optiuni",-20}");
            foreach (var optiune in Optiuni)
            {
                Console.Write($"{"",-20} {optiune,-10}\n");
            }
        }

        public string ConvertToString()
        {
            string optiuni = string.Empty;
            for (int i = 0; i < Optiuni.Count; i++)
                optiuni += Optiuni[i] + "\n";
            return "Firma:" + Firma + "\nModel: " + Model + "\nAn Fabricatie: " + AnFabricatie +
                "\nCuloare: " + Culoare + "\nPret: " + Pret + "\nVanzator: " + NumeVanzator +
                "\nCumparator: " + NumeCumparator + "\nOptiuni: " + optiuni +"\n";
        }

        public static Car PriceCompare(Car a, Car b)
        {
            if (a.Pret > b.Pret)
                return a;
            else if (b.Pret > a.Pret)
                return b;
            else
                if (a.AnFabricatie > b.AnFabricatie)
                return a;
            else
                return b;
        }
    }
}