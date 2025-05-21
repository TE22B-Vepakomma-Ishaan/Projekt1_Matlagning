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
        SP = random.Next(1, 4);
    }

    public void SpecialEffect(Player player, Player opponent, Deck deck)
    {
        // switch (SP)
        // {
        //     case 1:

                
        //         Steal();
        //         break;
        //     case 2:
        //         SelectThree();
        //         break;
        //     case 3:
        //         Swap();
        //         break;

        // }
    }

    private void Steal(Player player, Player opponent)
    {
        if (opponent.MyHand.Count == 0) return;
        else
        {
            int x = random.Next(opponent.MyHand.Count);
            Card card = opponent.MyHand[x];
            player.MyHand.Add(card);
            opponent.MyHand.RemoveAt(x);
            
            System.Console.WriteLine($"{card.CardFront()} was stolen.");
        }

    }

    private void SelectThree(Player player, Deck deck)
    {   

        System.Console.WriteLine($"{deck.cards[0].CardFront()}");
    }

    private void Swap()
    {

    }
}
