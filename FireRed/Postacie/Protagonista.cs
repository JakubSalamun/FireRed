using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Postacie
{
   public class Protagonista : NPC
    {
        public void przedstawSie()
        {     
            Console.WriteLine("metoda z Protagonista");
            Console.WriteLine("Mam na imie "+ nazwaPostaci + " ,jestem "+ (gender==Gender.Male ? "Chłopcem ":"Dziewczynką"));
        }
        

    }
}
