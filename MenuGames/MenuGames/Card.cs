using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGames
{
    class Card
    {
         public string Ertek { get; set; }
        public string Tipus { get; set; }
        public bool Kezben { get; set; }
        public string Link { get; set; }

        public Card(string tipus, string ertek, string link)
        {
            Ertek = ertek;
            Tipus = tipus;
            Kezben = false;
            Link = link;
        }
}
