using System;

namespace Projekt1_Matlagning;

public class MyPlayer : Player
{
    public void Render(int x)
    {

        System.Console.WriteLine("┌────────────────────────── Your Hand ────────────────────────────┐");

        for (int i = 0; i < MyHand.Count; i++)
        {
            string z = MyHand[i].CardFront();
            if (i == x)
            {
                System.Console.Write($"{" "}^{z}^ ");

            }
            else
            {
                System.Console.Write(" " + z);
            }
        }
        System.Console.WriteLine("\n└─────────────────────────────────────────────────────────────────┘");
        System.Console.WriteLine("Use ◄ ► to move. Press Enter to play. Esc to quit.");
        System.Console.WriteLine();

        Card SPCard = MyHand[x];

        if (SPCard is SpecialCard specialCard)
        {
            string Desc = specialCard.SP switch
            {
                1 => "Steal a random card from your opponent.",
                2 => "Shows top three cards in the deck; can select 1.",
                _ => "?"
            };

            Console.WriteLine($" -- Special Card Effect: {Desc} --");
        }

    }

    public void PlayCard(int x)
    {
        if (GetCount() > 0)
        {
            Card p = GetCard(x);
            if (p.Num != 0)
            {   
                Score += p.Num;
                RemoveCard(x);

                System.Console.WriteLine($"\nYou played: {p.CardFront()}");
                System.Console.WriteLine("Press Any Key to end turn.");
            }
            else
            {

            }
        }
    }

}
