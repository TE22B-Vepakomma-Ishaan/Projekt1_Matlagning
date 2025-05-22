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
        SP = random.Next(1, 3);
    }

    // public void SpecialEffect(Player player, Player opponent, Deck deck)
    // {
        // switch (SP)
        // {
        //     case 1:

        //         
        //         break;
        //     case 2:
        //         
        //         break;

        // }
    // }

    public void Deduct()
    {
        
    }
    public void Skip()
    {

    }

}
