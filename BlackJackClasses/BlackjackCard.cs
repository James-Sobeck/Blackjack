using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class BlackjackCard : Card
    {

        //the purpose of this class is to get the value of the card 

        public BlackjackCard(CardFace face, CardSuit suit) : base(face, suit) //ERROR HERE THE CONSTRUCTOR IS MESSED UP, card is ok but bcard is null
        {
            //call the card constructor and find value of it
            //Card card = new Card(face, suit); //idk if this is needed
            // BlackjackCard bcard = (BlackjackCard)card;    //ERROR HERE CANNOT CAST
            //BlackjackCard bcard = Factory.CreateBlackjackCard(face, suit);
            //int value = Value(bcard);  //not sure about this part
            
            CardFace s = this.GetFace();
            switch (s)
            {
                case CardFace.ten:
                case CardFace.J:
                case CardFace.Q:
                case CardFace.K:
                     Value = 10;
                    break;
                case CardFace.A:
                     Value = 11;
                    break;
                default:
                     Value = (int)s + 1;
                    break;
            }

        }
        public int Value { get; set; }
        
    }
}
