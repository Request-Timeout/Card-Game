using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] deck = { "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades", "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Spades", "Queen of Spades","King of Spades","Ace of Hearts","Two of Hearts","Three of Hearts","Four of Hearts","Five of Hearts","Six of Hearts","Seven of Hearts","Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Diamonds", "Two of Diamonds", "Three of Diamond,", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds" };

            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("---");
            TopCard(deck);
            Console.WriteLine("---");
            BottomCard(deck);
            Console.WriteLine("---");
            CutDeck(deck);
            Console.WriteLine("---");
            CutDeckShow(deck);
            Console.WriteLine("---");
            deck = Shuffle(deck);
            Console.WriteLine("---");
            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }
        }

        static void TopCard(string[] deck)
        {
            Console.WriteLine($"{deck[0]}");
        }

        static void BottomCard(string[] deck)
        {
            Console.WriteLine($"{deck.Last()}");
        }

        static string[] CutDeck(string[] deck)
        {
            string[] firstArray = deck.Take(deck.Length / 2).ToArray();
            string[] secondArray = deck.Skip(deck.Length / 2).ToArray();
            var list = new List<string>();
            list.AddRange(secondArray);
            list.AddRange(firstArray);
            string[] cutArray = list.ToArray();

            return cutArray;
        }

        static string[] CutDeckShow(string[] deck)
        {
            string[] firstArray = deck.Take(deck.Length / 2).ToArray();
            string[] secondArray = deck.Skip(deck.Length / 2).ToArray();
            Console.WriteLine($"{secondArray[0]}");
            var list = new List<string>();
            list.AddRange(secondArray);
            list.AddRange(firstArray);
            string[] cutArray = list.ToArray();

            return cutArray;
        }

        static string[] Shuffle(string[] deck)
        {
            Random random = new Random();
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = random.Next(n + 1);
                string temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
            return deck;
        }
    }
}
