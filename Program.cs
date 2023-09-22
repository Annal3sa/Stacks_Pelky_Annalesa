using System;
using System.Collections.Generic;


namespace Stacks_Pelky_Annalesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a Card array with Card objects with appropriate values
            Card[] myCardsArray = new Card[]
            {
                new Card('Ace', "Spades"),
                new Card('Jack', "Clubs"),
                new Card('Queen', "Diamonds"),
                new Card('Queen', "Hearts"),
                new Card('10', "Hearts"),
                new Card('2', "Diamonds"),
                new Card('6', "Spades"),
                new Card('9', "Clubs"),
                new Card('Ace', "Diamonds"),
            };

            //Create a Card stack and push the cards you made to it, call it startingDeck
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            //Print to console, "Cards in the deck:"
            Console.WriteLine("Cards in Deck:");

            //Loop through the stack and print on a new line for each card, "The <Number> of <Suit>!".
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            //Print to console the number of cards in the stack.
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            //Create a new Card list, called myHand.
            List<Card> myHand = new List<Card>();

            //Add 3 different Cards to myHand. Add 3 different Cards to myHand.

            Print to console, "Got any 8's?"

            Print to console, "Got any 8's?"
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            Console.WriteLine("Got any 8's?");
            if(startingDeck.Count > 0)
            {
                myHands.Add(startingDeck.Pop());
            }
            //Print to console the number of cards in the stack.
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            //Place one of the cards in your hand, on the stack.
            startingDeck.Push(myHand[0]);
            //Delete the card you placed from your hand
            myHand.RemoveAt(0);

            //Print to console, "Cards in the deck:"
            Console.WriteLine("Cards in Deck:");
            //Loop through the stack and print on a new line for each card, "The <Number> of <Suit>!".
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}