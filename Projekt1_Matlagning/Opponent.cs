using System;

namespace Projekt1_Matlagning;

public class MyOpponent : Player
{
    public void Render(int x)
    {
        System.Console.WriteLine("┌───────────────────────── Opponent's Hand ───────────────────────┐");
        for (int i = 0; i < MyHand.Count; i++)
        {
            Console.Write(" " + Card.CardBack());
        }
        System.Console.WriteLine("\n└─────────────────────────────────────────────────────────────────┘");

    }

    public void PlayCard()
    {

        if (GetCount() > 0)
        {   
            Random random = new();
            int x = random.Next(MyHand.Count);
            Card p = GetCard(x);

            if (p.Num != 0)
            {

                Score += p.Num;
                RemoveCard(x);

                System.Console.WriteLine($"\nOpponent played: {p.CardFront()}");
                System.Console.WriteLine("Press Any Key to start next round.");

            }
            else
            {

            }

        }
    }
}
