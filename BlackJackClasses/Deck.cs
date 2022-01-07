using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class Deck
    {
        //TYPE error of string value and string face. 
        List<Card> _cards = new List<Card>();
        public Deck()
        {
            /*
            foreach (var value in Enum.GetValues(typeof(CardSuit)))
            {
                //for each suit
                foreach (var face in Enum.GetValues(typeof(CardFace)))
                {
                    //each face 
                    _cards.Add(Factory.CreateBlackjackCard(nameof(face), nameof(value))); //changed from just create card
                }
            }*/
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _cards.Add(Factory.CreateBlackjackCard((CardFace)i, (CardSuit)j));
                }
            }

        }
        
        public Card Deal()
        {
            //return a card from list of cards. recreate the deck if _cards is empty 
            Random rnd = new Random();
            if (_cards.Count.Equals(0))
            {
                Deck newDeck = new Deck();
                this._cards = newDeck._cards;
            }
            int r = rnd.Next(_cards.Count); //random index
            Card dealtCard = _cards[r];
            _cards.RemoveAt(r);
            return dealtCard;
        }
        public void Shuffle()
        {
            //reorder the cards, switch indexs
            Random rng = new Random();
            int n = _cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card hold = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = hold;
            }
        }
    }
}
