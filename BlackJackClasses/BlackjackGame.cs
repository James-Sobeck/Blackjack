using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class BlackjackGame
    {
        BlackjackHand _dealer;
        BlackjackHand _player;
        Deck _deck;

        public BlackjackGame(BlackjackHand dealer, BlackjackHand player, Deck deck)
        {
            _dealer = dealer;
            _player = player;
            _deck = deck;
        }

        public void PlayRound()
        {
            BlackjackHand dealer = new BlackjackHand();
            BlackjackHand player = new BlackjackHand();
            Deck deck = new Deck();
            _dealer.IsDealer = true;

            DealinitalCards();
            if (_player.Score.Equals(21) || _dealer.Score.Equals(21))
            {
                DeclareWinner();
            }
            else
            {
            PlayersTurn();
            DealersTurn();
            DeclareWinner();
            }
            
        }
        public void DealinitalCards()
        {
            //player then dealer
            _player.AddCard(_deck.Deal());
            _deck.Shuffle();
            
            _dealer.AddCard(_deck.Deal());
            _deck.Shuffle();
            
            _player.AddCard(_deck.Deal());
            _deck.Shuffle();
            DrawTable();
            _dealer.AddCard(_deck.Deal());
            DrawTable();
        }
        public void PlayersTurn()
        {
            while(_player.Score < 21)
            {
                Console.WriteLine("Would you like to hit or stand?");
                string answer = Console.ReadLine();
                if (answer.Contains("hit"))
                {
                    _player.AddCard(_deck.Deal());
                    _deck.Shuffle();
                    
                    break;
                }
                else
                {
                    break;
                }
            }
            DrawTable();
        }
        public void DealersTurn()
        {
            //add in show all cards
            _dealer.IsDealer = false;
            DrawTable();
            while (_dealer.Score < 17)
            {
               
                _dealer.AddCard(_deck.Deal());
                _deck.Shuffle();
                if(_dealer.Score > 17)
                {
                    break;
                }
            }
            DrawTable();
        }
        public void DeclareWinner()
        {
            int p = _player.Score;
            int de = _dealer.Score;
            if (de > 21)
            {
                Console.WriteLine("Player Won!!!");
                
            }
            else if (p > 21)
            {
                Console.WriteLine("Dealer Won!!!");
                
            } 
            else if (p.Equals(de))
            {
                Console.WriteLine("Tie");
            } 
            else if (p > de)
            {
                //isdealer is false to show dealer's hand if won on first round
                _dealer.IsDealer = false;
                DrawTable();
                Console.WriteLine("Player Won!!!");
            }
            else
            {
                //isdealer is false to show dealer's hand if won on first round
                _dealer.IsDealer = false;
                DrawTable();
                Console.WriteLine("Dealer Won!!!");
            }
        }
        public void DrawTable()
        {
            Console.Clear();
            // make it look nice 
            Console.WriteLine();
            Console.SetCursorPosition(0, 1);
            Console.Write("Player's Hand:   ");
            _player.Print(20, 1);
            Console.Write("Dealer's Hand:   ");
            _dealer.Print(20, 2);

        }
    }
}
