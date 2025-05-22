using System;

namespace Projekt1_Matlagning;

public class Playmat
{
    public static void StartGame()
    {


        Deck deck = new();
        deck.Shuffle();

        MyPlayer player = new();
        MyOpponent opponent = new();


        for (int i = 0; i < 10; i++)
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
                    if (x < player.GetCount() - 1)
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
                    player.PlayCard(x);
                    
                    Console.ReadKey();
                    opponent.PlayCard();
                    Console.ReadKey();
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

        MyOpponent myO = (MyOpponent)opponent;
        myO.Render(x);
        System.Console.WriteLine("");
        System.Console.WriteLine($"Your Opponents score is: {opponent.Score}");
        System.Console.WriteLine($"Your score is: {player.Score}");
        System.Console.WriteLine();

        MyPlayer myP = (MyPlayer)player;
        myP.Render(x);
    }
}
