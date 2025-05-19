using System;

namespace Projekt1_Matlagning;

public class Player
{
    public List<Card> MyHand = new();


    public void RecieveCard(Card card)
    {
        MyHand.Add(card);
    }
    public void PlayCard()
    {   


    }

    public void PassTurn()
    {

    }
}
