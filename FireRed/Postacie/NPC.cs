using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Postacie
{
  public   class NPC
    {
        public string nazwaPostaci { get; set; }
        public Gender gender { get; set; }

        public NPC()
        {

        }

        public NPC(string nazwaPostaci, Gender gender)
        {
            this.nazwaPostaci = nazwaPostaci;
            this.gender = gender;
        }

        public void PrzedstawSię()
        {
            Console.WriteLine("Imie:" + nazwaPostaci);
        }

    }
}
