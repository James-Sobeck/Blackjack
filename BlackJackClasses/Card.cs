using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public enum CardSuit
    {
        Spades, Hearts, Clubs, Diamonds
    }
    public enum CardFace
    {
        A, two, three, four, five, six, seven, eight, nine, ten, J, Q, K
    }

    public class Card
    {
        CardFace face;
        CardSuit suit;

        public char Symbol { get; }
        public Card(CardFace Face, CardSuit Suit)  //Stack overflow exception
        {
           
            face = Face;
            suit = Suit;
            switch (suit)
            {
                case CardSuit.Clubs:
                    Symbol = '♣';
                    break;
                case CardSuit.Spades:
                    Symbol = '♠';
                    break;
                case CardSuit.Diamonds:
                    Symbol = '♦';
                    break;
                case CardSuit.Hearts:
                    Symbol = '♥';
                    break;
            }
        }
        


        public CardFace GetFace()
        {
            return face;
        }
        private CardFace SetFace(CardFace Face)
        {
            return face = Face;
        }
        public CardSuit GetSuit()
        {
            return suit;
        }
        private CardSuit SetSuit(CardSuit Suit)
        {
            return suit = Suit;
        }
        public void printCard(int x, int y)
        { 
            
            //print one console at x and y postion 
            //generic how do I get Card card to equal to obj being called 
            //Card card = new Card("Spades", "K");
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write( " "+ this.face + " "); //maybe delete .this
            Console.Write(this.Symbol+ " ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    
}
