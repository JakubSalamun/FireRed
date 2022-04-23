using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Postacie
{
   public class Antagonista :NPC
    {
        public void przedstawSie()
        {
            Console.WriteLine("metoda z Antagonista");
            Console.WriteLine("Mam na imie " + nazwaPostaci);
        }
    }
}
