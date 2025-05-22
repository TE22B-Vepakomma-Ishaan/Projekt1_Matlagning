using System;

namespace Projekt1_Matlagning;

// Represents the deck used in the game. 
// When instanse is created, fills deck with full suit of cards.
public class Deck
{
    private List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();
        CreateDeck();
    }

    // Adds every combination of suit and number, to fill out the standard 52 cards in a deck. then adds 8 special cards additionally.
    private void CreateDeck()
    {
        string[] suits = { "Spade", "Club", "Diamond", "Heart" };

        foreach (string suit in suits)
        {
            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Card(suit, i));
            }
        }

        // for (int i = 1; i <= 8; i++)
        // {

        //     cards.Add(new SpecialCard());

        // }

    }

    // Function to shuffle deck into a random order. Takes a card from the deck list and assigns a new order to it with a random position; then swaps the current card, with the card that held that position previously. repeat till deck is fully (un)sorted.
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

    // take the card at the 'top' of the deck, i.e. in position 0. Then removes it from the deck.
    public Card PickCard()
    {
        Card SelectedCard = cards[0];
        cards.RemoveAt(0);
        return SelectedCard;
    }

}
