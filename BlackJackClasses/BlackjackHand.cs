using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class BlackjackHand : Hand
    {
        //has score property, override AddCard method to update score, print score to user only if dealers hand hide the first card

        
        /*
        public int Score(List<Card> list)
        { //blackjack score in hand
          //setter is private
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                //add each score
                BlackjackCard tempCard = (BlackjackCard)list[i];
                result += tempCard.Value();
            }
            if (result > 21)
            {
                //handle lower Ace value
                foreach (Card card in list)
                {
                    if (card.GetFace() == CardFace.A)
                    {
                        //if hand has an ace
                        result -= 10; //Ace is now one
                    }
                }
            }
            return result;
        }
        */
        public int Tally(List<Card> list)
        {
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                //add each score
                BlackjackCard tempCard = (BlackjackCard)list[i];
                result += tempCard.Value;
            }
            if (result > 21)
            {
                //handle lower Ace value
                foreach (Card card in list)
                {
                    if (card.GetFace() == CardFace.A)
                    {
                        //if hand has an ace
                        result -= 10; //Ace is now one
                    }
                }
            }
            return this.Score = result;
        }

        public BlackjackHand(bool IsDealer = false) : base()
        {
            if (IsDealer)
            {
                this.IsDealer = true;
            }   


        }
        public bool IsDealer { get; set; }
        
        public int Score { get; set; }
        public override void AddCard(Card card)
        { //update score after calling addCard
            base.AddCard(card);
            Tally(base._cards);
        }
        public override void Print(int x, int y)
        {
            if (!this.IsDealer)
            {
                // Console.WriteLine(this.IsDealer());
                base.Print(x, y);
                Console.Write(" " + Tally(_cards)); // base._cards
            }
            else 
            {
                
                //is dealer
                //this.Score(_cards) = "??";
                base.Print(x, y);
                Console.Write(" ??");
                Console.SetCursorPosition(x + 1, y);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write("         "); //change this to match length
                Console.BackgroundColor = ConsoleColor.Black;

            }
            Console.WriteLine();
        }
    }
}
