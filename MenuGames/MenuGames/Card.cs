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
        public string Link { get; set; }

        public Card(string ertek, string tipus, string link)
        {
            Ertek = ertek;
            Tipus = tipus;
            Kezben = false;
            Link = link;
        }
        public static List<Card> deck = GetDeck();
        public static List<Card> playerCards = new List<Card>();
        public static List<Card> dealerCards = new List<Card>();

        private static List<Card> GetDeck()
        {

            var deck = new List<Card>();

            for (int i = 0; i < 2; i++)
            {
                #region Pikk
                deck.Add(new Card("2", "Pikk", "bjfiles/cards/P2.png"));
                deck.Add(new Card("3", "Pikk", "bjfiles/cards/P3.png"));
                deck.Add(new Card("4", "Pikk", "bjfiles/cards/P4.png"));
                deck.Add(new Card("5", "Pikk", "bjfiles/cards/P5.png"));
                deck.Add(new Card("6", "Pikk", "bjfiles/cards/P6.png"));
                deck.Add(new Card("7", "Pikk", "bjfiles/cards/P7.png"));
                deck.Add(new Card("8", "Pikk", "bjfiles/cards/P8.png"));
                deck.Add(new Card("9", "Pikk", "bjfiles/cards/P9.png"));
                deck.Add(new Card("10", "Pikk", "bjfiles/cards/P10.png"));
                deck.Add(new Card("10", "Pikk", "bjfiles/cards/PJ.png"));
                deck.Add(new Card("10", "Pikk", "bjfiles/cards/PD.png"));
                deck.Add(new Card("10", "Pikk", "bjfiles/cards/PK.png"));
                deck.Add(new Card("11", "Pikk", "bjfiles/cards/PA.png"));
                #endregion
                #region Kőr
                deck.Add(new Card("2", "Kőr", "bjfiles/cards/Ko2.png"));
                deck.Add(new Card("3", "Kőr", "bjfiles/cards/Ko3.png"));
                deck.Add(new Card("4", "Kőr", "bjfiles/cards/Ko4.png"));
                deck.Add(new Card("5", "Kőr", "bjfiles/cards/Ko5.png"));
                deck.Add(new Card("6", "Kőr", "bjfiles/cards/Ko6.png"));
                deck.Add(new Card("7", "Kőr", "bjfiles/cards/Ko7.png"));
                deck.Add(new Card("8", "Kőr", "bjfiles/cards/Ko8.png"));
                deck.Add(new Card("9", "Kőr", "bjfiles/cards/Ko9.png"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/Ko10.png"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/KoJ.png"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/KoD.png"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/KoK.png"));
                deck.Add(new Card("11", "Kőr", "bjfiles/cards/KoA.png"));
                #endregion
                #region Káro
                deck.Add(new Card("2", "Káró", "bjfiles/cards/Ka2.png"));
                deck.Add(new Card("3", "Káró", "bjfiles/cards/Ka3.png"));
                deck.Add(new Card("4", "Káró", "bjfiles/cards/Ka4.png"));
                deck.Add(new Card("5", "Káró", "bjfiles/cards/Ka5.png"));
                deck.Add(new Card("6", "Káró", "bjfiles/cards/Ka6.png"));
                deck.Add(new Card("7", "Káró", "bjfiles/cards/Ka7.png"));
                deck.Add(new Card("8", "Káró", "bjfiles/cards/Ka8.png"));
                deck.Add(new Card("9", "Káró", "bjfiles/cards/Ka9.png"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/Ka10.png"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/KaJ.png"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/KaD.png"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/KaK.png"));
                deck.Add(new Card("11", "Káró", "bjfiles/cards/KaA.png"));
                #endregion
                #region Treff
                deck.Add(new Card("2", "Treff", "bjfiles/cards/T2.png"));
                deck.Add(new Card("3", "Treff", "bjfiles/cards/T3.png"));
                deck.Add(new Card("4", "Treff", "bjfiles/cards/T4.png"));
                deck.Add(new Card("5", "Treff", "bjfiles/cards/T5.png"));
                deck.Add(new Card("6", "Treff", "bjfiles/cards/T6.png"));
                deck.Add(new Card("7", "Treff", "bjfiles/cards/T7.png"));
                deck.Add(new Card("8", "Treff", "bjfiles/cards/T8.png"));
                deck.Add(new Card("9", "Treff", "bjfiles/cards/T9.png"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/T10.png"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/TJ.png"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/TD.png"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/TK.png"));
                deck.Add(new Card("11", "Treff", "bjfiles/cards/TA.png"));
                #endregion
            }
            return deck;
        }
    }
}