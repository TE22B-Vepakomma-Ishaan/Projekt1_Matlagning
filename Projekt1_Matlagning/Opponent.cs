using System;

namespace Projekt1_Matlagning;

// Represents the opponents (computer) side of the gameplay.
public class MyOpponent : Player
{   
    // Renders the opponents hand, cards are hidden and only show the back though.
    public override void Render(int index)
    {
        System.Console.WriteLine("┌───────────────────────── Opponent's Hand ───────────────────────┐");
        for (int i = 0; i < dealtCards.Count; i++)
        {
            Console.Write(" " + Card.CardBack());
        }
        System.Console.WriteLine("\n└─────────────────────────────────────────────────────────────────┘");

    }
    // Checks if the opponent has a card in their hand. Then randomly selects a card from their list. Updates the score.
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
