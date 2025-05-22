using System;

namespace Projekt1_Matlagning;

// Represents player object. is parent class for different types of players
public class Player
{
    protected List<Card> dealtCards = new();
    public int scoreAttribute = 0;

    public int GetCount()
    {
        return dealtCards.Count;
    }

    public Card GetCard(int index)
    {
        return dealtCards[index];
    }

    public void RemoveCard(int index)
    {
        dealtCards.RemoveAt(index);
    }

    public void RecieveCard(Card card)
    {
        dealtCards.Add(card);
    }

    // ------Shell for Child to inherit -----
    public virtual void Render(int index)
    {

    }
    protected void PlayCard()
    {


    }
    // -------------------------------------
}
