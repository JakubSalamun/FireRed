using FireRed.Postacie;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Metody
{
  public class Menu
    {
        public void Print(string text)
        {
            int speed = 1;
            foreach (var item in text)
            {
                Console.Write(item);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
        public void antagonistaInfo()
        {
            Antagonista antagonista = new Antagonista();

            Console.WriteLine("Miał on na imię: ");
            Console.WriteLine("1-Bary");
            Console.WriteLine("2-Gary");
            Console.WriteLine("3-Lary");
            Console.WriteLine("4-nazwij przeciwnika");
            string imiePostaci = Console.ReadLine();

            switch (imiePostaci)
            {
                case "1":
                    antagonista.nazwaPostaci = "Bary";
                    antagonista.gender = Gender.Male;
                    break;
                case "2":
                    antagonista.nazwaPostaci = "Bary";
                    antagonista.gender = Gender.Male;
                    break;
                case "3":
                    antagonista.nazwaPostaci = "Bary";
                    antagonista.gender = Gender.Male;
                    break;
                case "4":
                    Console.WriteLine("Podaj nazwe:");
                    string imiePostaciAnta = Console.ReadLine();
                    antagonista.nazwaPostaci = imiePostaciAnta;
                    antagonista.gender = Gender.Male;
                    break;

                 default:
                    Console.WriteLine("Podaj nazwe:");
                    string imiePostaciAntaDefault = Console.ReadLine();
                    antagonista.nazwaPostaci = imiePostaciAntaDefault;
                    antagonista.gender = Gender.Male;
                    break;
            }
            antagonista.przedstawSie();

            //Zapisanie do pliku Json
            string antagonistaSerialized= JsonConvert.SerializeObject(antagonista);
            File.WriteAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\JSON\antagonistaSerialized.json", antagonistaSerialized);


        }
        public void protagonistaInfo()
        {
            Console.Write("Przedstaw się: ");
            string imiePostaci = Console.ReadLine();
            Console.WriteLine("Jestem:");
            Console.WriteLine("Chłopcem wpisz 1");
            Console.WriteLine("Dziewczynka wpisz 2");
            string gender = Console.ReadLine();

            Protagonista protagonista = new Protagonista();
            protagonista.nazwaPostaci = imiePostaci;
            protagonista.gender = (Gender)Enum.Parse(typeof(Gender), gender);
            protagonista.przedstawSie();

            //Zapisanie do pliku Json
            string protagonistaSerialized = JsonConvert.SerializeObject(protagonista);
            File.WriteAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\JSON\protagonistaSerialized.json", protagonistaSerialized);

        }

        //Pobranie danych do pliku Json, 
        public void jsonDeserialize()
        {
            string wczytanieJSON = File.ReadAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\JSON\protagonistaSerialized.json");
            Protagonista protagonista = JsonConvert.DeserializeObject<Protagonista>(wczytanieJSON);
            protagonista.przedstawSie();
            //Console.WriteLine(protagonista.nazwaPostaci);
            //Console.WriteLine(protagonista.gender);
        }
    }
}
