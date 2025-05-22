using System;

namespace Projekt1_Matlagning;

// This class represents a specific card in a deck.
public class Card
{
    protected string suitAttribute;

    protected int numAttribute;

    public Card(string vSuit, int vNum)
    {
        suitAttribute = vSuit;
        numAttribute = vNum;
    }

    public Card()
    {

    }

    // Returns value of any given cards Suit and Number. Every royal gets their designated letter; Every suit gets their unicode symbol. Displays a cards information in a string (front face of a card).

    public string CardFront()
    {

        string numberSymbol = numAttribute switch
        {
            0 => "S",
            1 => "A",
            11 => "J",
            12 => "Q",
            13 => "K",
            _ => numAttribute.ToString()
        };

        string suitSymbol = suitAttribute switch
        {
            "Spade" => "♠",
            "Club" => "♣",
            "Diamond" => "♦",
            "Heart" => "♥",
            "Special" => "🏶",
            _ => "?"
        };

        return $"[{suitSymbol} {numberSymbol}]";
    }

    //Function called to render the 'back' of the card
    public static string CardBack()
    {
        return "[###]";
    }

    public int updateScore(int v_playerScore)
    {
        if (numAttribute != 0)
        {
            return v_playerScore += numAttribute;

        }
        return 0;

    }


}
