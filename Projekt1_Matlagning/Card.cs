using System;

namespace Projekt1_Matlagning;

public class Card
{
    protected string suitAttribute;

    protected int numAttribute;

    public Card(string v_suit, int v_num)
    {
        suitAttribute = v_suit;
        numAttribute = v_num;
    }

    public Card()
    {

    }

    
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
