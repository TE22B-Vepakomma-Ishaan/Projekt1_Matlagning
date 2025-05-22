using System;

namespace Projekt1_Matlagning;

public class Player
{
    protected List<Card> MyHand = new();
    public int Score = 0;

    protected void Render(int x)
    {

    }

    public int GetCount()
    {
        return MyHand.Count;
    }

    public Card GetCard(int x)
    {
        return MyHand[x];
    }

    public void RemoveCard(int x)
    {
        MyHand.RemoveAt(x);
    }

    public void RecieveCard(Card card)
    {
        MyHand.Add(card);
    }
    protected void PlayCard()
    {   


    }

    public void PassTurn()
    {

    }
}
