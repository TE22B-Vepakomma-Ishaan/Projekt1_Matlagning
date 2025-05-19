using System;

namespace Projekt1_Matlagning;

public class SpecialCard : Card
{

    private static Random random = new();

    public int SP { get; private set; } 

    public SpecialCard()
    {
        Suit = "Special";
        Num = 0;
        SP = random.Next(1, 5);
    }

    // public void SpecialEffect(Player player, Player opponent, Deck deck)
    // {
    //     switch (SP)
    //     {


    //     }
    // }

    private void Steal()
    {

    }
}
