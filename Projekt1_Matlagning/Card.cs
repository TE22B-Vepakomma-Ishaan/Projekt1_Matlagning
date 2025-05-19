using System;

namespace Projekt1_Matlagning;

public class Card
{
    public string Suit { get; set; }

    public int Num { get; set; }

    public void CardRender()
    {

        string x = Num switch
        {   
            0 => "S",
            1 => "A",
            11 => "J",
            12 => "Q",
            13 => "K",
            _ => Num.ToString()
        };

        string z = Suit switch
        {
            "Spade" => "♠",
            "Club" => "♣",
            "Diamond" => "♦",
            "Heart" => "♥",
            "Special" => "🏶",
            
        };
     
    }
}
