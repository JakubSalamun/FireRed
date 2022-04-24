using System;
using System.IO;
using FireRed.Metody;
using FireRed.Postacie;


namespace FireRed
{
    class Program : Menu
    {
  
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            if (menu.jsonDeserialize())
            {
                Console.WriteLine("Witaj przygodo");

            }
            else
            {
            wczytaniMenuPoczatkowe();
            }
        }

        static void wczytaniMenuPoczatkowe()
        {
            Menu menu = new Menu();
            var plikPrzywitaniaTxt = File.ReadAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\Tekst\przywitanie.txt");
            menu.Print(plikPrzywitaniaTxt);
            menu.protagonistaInfo();
            menu.antagonistaInfo();

           // menu.jsonDeserialize();

            var plikPrzedstawieniePostaci = File.ReadAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\Tekst\przedstawieniePostaci.txt");
            //var podmianaDanychPostaci = plikPrzedstawieniePostaci.Replace("{imiePostaci}", protagonista.nazwaPostaci);           
            //menu.Print(podmianaDanychPostaci);
            //protagonistaInfo();
        }

      
        
    }
}
