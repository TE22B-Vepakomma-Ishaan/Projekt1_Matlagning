using System;

namespace Projekt1_Matlagning;

public class Player
{
    protected List<Card> dealtCards = new();
    public int scoreAttribute = 0;

    protected void Render(int index)
    {

    }

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
    protected void PlayCard()
    {   


    }

}
