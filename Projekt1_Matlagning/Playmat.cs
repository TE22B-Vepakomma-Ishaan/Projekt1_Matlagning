using System;

namespace Projekt1_Matlagning;

// Class represents the game. This class is used to initiate the game and to proceed with the gameplay
public class Playmat
{   
    public void StartGame()
    {


    // Creates an instance of a deck, shuffles it, and hands 10 cards to each player.

        Deck deck = new();
        deck.Shuffle();

        MyPlayer player = new();
        MyOpponent opponent = new();


        for (int i = 0; i < 10; i++)
        {

            player.RecieveCard(deck.PickCard());

            opponent.RecieveCard(deck.PickCard());

        }

        int index = 0;
        bool displayError = false;
        bool run = true;


        // Constantly runs and updates while game is played.

        while (run)
        {
            Console.Clear();
            Render(player, opponent, index);

            // If player inputs a key not used by the game, displays error message. 
            if (displayError)
            {
                System.Console.WriteLine("Not a valid input.");

            }

            ConsoleKey consoleKey = Console.ReadKey(true).Key;

            // Allows player to use arrow keys to sift through their deck, can press enter to play the highlighted card. 
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
    // Renders the visuals for the game. Displays both opponents and players board, as well as the current score. 
    public void Render(Player player, Player opponent, int index)
    {

       
        opponent.Render(index);
        
        System.Console.WriteLine("");
        System.Console.WriteLine($"Your Opponents score is: {opponent.scoreAttribute}");
        System.Console.WriteLine($"Your score is: {player.scoreAttribute}");
        System.Console.WriteLine();

        
        player.Render(index);

    }

}
