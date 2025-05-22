using System;

namespace Projekt1_Matlagning;

public class MyOpponent : Player
{
    public void Render(int index)
    {
        System.Console.WriteLine("┌───────────────────────── Opponent's Hand ───────────────────────┐");
        for (int i = 0; i < dealtCards.Count; i++)
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
            int randomIndex = random.Next(dealtCards.Count);
            Card playedCard = GetCard(randomIndex);
            scoreAttribute = playedCard.updateScore(scoreAttribute);
        
                RemoveCard(randomIndex);

                System.Console.WriteLine($"\nOpponent played: {playedCard.CardFront()}");
                System.Console.WriteLine("Press Any Key to start next round.");

        }
    }
}
