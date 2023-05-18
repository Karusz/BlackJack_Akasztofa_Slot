using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGames
{
    class Card
    {
        public string Tipus { get; set; }
        public string Ertek { get; set; }
        public bool Kezben { get; set; }

        public Card(string tipus, string ertek)
        {
            Tipus = tipus;
            Ertek = ertek;
            Kezben = false;
        }
    }
}
