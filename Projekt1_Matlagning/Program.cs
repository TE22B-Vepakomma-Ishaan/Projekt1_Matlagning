
using Projekt1_Matlagning;

Deck deck = new();

for (int i = 0; i < deck.cards.Count; i++)
{
    System.Console.WriteLine($"{deck.cards[i].Suit} + {deck.cards[i].Num}");
}

Console.ReadLine();