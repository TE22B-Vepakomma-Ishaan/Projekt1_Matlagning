using System;

namespace Projekt1_Matlagning;

public class MyPlayer : Player
{
    public void Render(int index)
    {

        System.Console.WriteLine("┌────────────────────────── Your Hand ────────────────────────────┐");

        for (int i = 0; i < dealtCards.Count; i++)
        {
            string cardFace = dealtCards[i].CardFront();
            if (i == index)
            {
                System.Console.Write($"{" "}^{cardFace}^ ");

            }
            else
            {
                System.Console.Write(" " + cardFace);
            }
        }
        System.Console.WriteLine("\n└─────────────────────────────────────────────────────────────────┘");
        System.Console.WriteLine("Use ◄ ► to move. Press Enter to play. Esc to quit.");
        System.Console.WriteLine();

        // Card SPCard = dealtCards[index];

        // if (SPCard is SpecialCard specialCard)
        // {
        //     string Desc = specialCard.SP switch
        //     {
        //         1 => "Steal a random card from your opponent.",
        //         2 => "Shows top three cards in the deck; can select 1.",
        //         _ => "?"
        //     };

        //     Console.WriteLine($" -- Special Card Effect: {Desc} --");
        // }

    }

    public void PlayCard(int index)
    {
        if (GetCount() > 0)
        {
            Card playedCard = GetCard(index);
            scoreAttribute = playedCard.updateScore(scoreAttribute);
                RemoveCard(index);

                System.Console.WriteLine($"\nYou played: {playedCard.CardFront()}");
                System.Console.WriteLine("Press Any Key to end turn.");
            
        }
    }

}
