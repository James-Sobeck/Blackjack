using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand bhand = new BlackjackHand();
            BlackjackCard cardA = new BlackjackCard(CardFace.A, CardSuit.Diamonds);
            BlackjackCard cardB = new BlackjackCard(CardFace.eight, CardSuit.Hearts);
            bhand.AddCard(cardA);
            bhand.AddCard(cardB);
            List<Card> list = new List<Card>();
            list.Add(cardA);
            list.Add(cardB);
            Assert.AreEqual(19,bhand.Score(list));
            
        }

        [TestMethod()]
        public void AddCardTestB()
        {
            BlackjackHand bhand = new BlackjackHand();
            BlackjackCard cardA = new BlackjackCard(CardFace.A, CardSuit.Diamonds);
            BlackjackCard cardB = new BlackjackCard(CardFace.eight, CardSuit.Hearts);
            bhand.AddCard(cardA);
            bhand.AddCard(cardB);
            List<Card> list = new List<Card>();
            list.Add(cardA);
            list.Add(cardB);
            BlackjackCard cardC = new BlackjackCard(CardFace.ten, CardSuit.Clubs);
            bhand.AddCard(cardC);
            list.Add(cardC);
            Assert.AreEqual(19, bhand.Score(list));
        }
    }
}