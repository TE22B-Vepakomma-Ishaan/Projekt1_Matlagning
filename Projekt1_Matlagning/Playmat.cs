using System;

namespace Projekt1_Matlagning;

public class Playmat
{
    public void StartGame()
    {


        Deck deck = new();
        deck.Shuffle();

        MyPlayer player = new();
        MyOpponent opponent = new();


        for (int i = 0; i < 2; i++)
        {

            player.RecieveCard(deck.PickCard());

            opponent.RecieveCard(deck.PickCard());

        }

        int index = 0;
        bool displayError = false;
        bool run = true;


        

        while (run)
        {
            Console.Clear();
            Render(player, opponent, index);

            if (displayError)
                    {
                        System.Console.WriteLine("Not a valid input.");
                        
                    }

            ConsoleKey consoleKey = Console.ReadKey(true).Key;

            switch (consoleKey)
            {
                case ConsoleKey.RightArrow:
                    displayError = false;
                    if (index < player.GetCount() - 1)
                    {
                        index++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    displayError = false;
                    if (index > 0)
                    {

                        index--;
                    }
                    break;
                case ConsoleKey.Enter:
                    displayError = false;
                    player.PlayCard(index);

                    Console.ReadKey();
                    opponent.PlayCard();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    displayError = false;
                    run = false;
                    break;
                default:
                    displayError = true;

                    break;
            }

        }

        Console.ReadLine();
    }

    public void Render(Player player, Player opponent, int index)
    {

        MyOpponent myO = (MyOpponent)opponent;
        myO.Render(index);
        System.Console.WriteLine("");
        System.Console.WriteLine($"Your Opponents score is: {opponent.scoreAttribute}");
        System.Console.WriteLine($"Your score is: {player.scoreAttribute}");
        System.Console.WriteLine();

        MyPlayer myP = (MyPlayer)player;
        myP.Render(index);

    }
    
}
