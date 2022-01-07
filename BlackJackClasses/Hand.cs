using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class Hand
    {
        protected List<Card> _cards;
        public Hand()
        {
            _cards = new List<Card>();
        }

        public virtual void AddCard(Card card)
        {
            this._cards.Add(card);
        }
        public virtual void Print(int x, int y)
        {
            foreach (Card card in _cards)
            {
                card.printCard(x, y);
                x += 10; //here I might need to get len of line then add to that
            }
        }
    }
}
