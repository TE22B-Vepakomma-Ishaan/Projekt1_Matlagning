using System;

namespace Projekt1_Matlagning;

public class Deck
{
    public List<Card> cards { get; private set; }

    public Deck()
    {
        cards = new List<Card>();
        CreateDeck();
    }

    private void CreateDeck()
    {
        string[] suits = {"Spade", "Club", "Diamond", "Heart" };

        foreach (string suit in suits)
        {
            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Card { Suit = suit, Num = i });
            }
        }
        for (int i = 1; i <= 8; i++)
        {

            cards.Add(new SpecialCard());

        }

    }

    public void Shuffle()
    {
        Random random = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int x = random.Next(n + 1);
            (cards[x], cards[n]) = (cards[n], cards[x]);
        }
    }


}
