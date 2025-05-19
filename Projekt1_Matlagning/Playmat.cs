using System;

namespace Projekt1_Matlagning;

public class Playmat
{
    public static void StartGame()
    {


        Deck deck = new();
        deck.Shuffle();

        Player player = new();
        Player opponent = new();

        for (int i = 0; i < 3; i++)
        {

            player.RecieveCard(deck.cards[0]);
            deck.cards.RemoveAt(0);

            opponent.RecieveCard(deck.cards[0]);
            deck.cards.RemoveAt(0);
        }

        int x = 0;
        bool run = true;

        Playmat playmat = new();

        while (run)
        {
            Console.Clear();
            playmat.Render(player, opponent, x);

            ConsoleKey consoleKey = Console.ReadKey(true).Key;

            switch (consoleKey)
            {
                case ConsoleKey.RightArrow:
                    if (x < player.MyHand.Count - 1)
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (x > 0)
                    {
                        x--;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (player.MyHand.Count > 0)
                    {
                        Card p = player.MyHand[x];
                        player.MyHand.RemoveAt(x);

                        System.Console.WriteLine($"\nYou played: {p.CardFront}");


                    }
                    break;
                case ConsoleKey.Escape:
                    run = false;
                    break;
            }

        }

        Console.ReadLine();
    }

    public void Render(Player player, Player opponent, int x)
    {
        System.Console.WriteLine("┌───────────────────────── Opponent's Hand ───────────────────────┐");
        foreach (var _ in opponent.MyHand.Take(2))
        {
            Console.Write(Card.CardBack() + " ");
        }
        foreach (var c in opponent.MyHand.Skip(2).Take(3))
        {
            Console.Write(c.CardFront() + " ");
        }
        System.Console.WriteLine("\n└─────────────────────────────────────────────────────────────────┘");


        System.Console.WriteLine("");


        System.Console.WriteLine("┌────────────────────────── Your Hand ────────────────────────────┐");

        for (int i = 0; i < player.MyHand.Count; i++)
        {
            string z = player.MyHand[i].CardFront();
            if (i == x)
            {
                System.Console.WriteLine($"^{z}^ ");
            }
            else
            {
                System.Console.WriteLine(z);
            }
        }
        System.Console.WriteLine("\n└─────────────────────────────────────────────────────────────────┘");
        System.Console.WriteLine("Use ◄ ► to move. Press Enter to play. Esc to quit.");
    }
}
