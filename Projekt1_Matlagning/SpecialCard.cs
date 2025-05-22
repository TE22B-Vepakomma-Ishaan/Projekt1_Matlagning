using System;

namespace Projekt1_Matlagning;

public class SpecialCard : Card
{

    private static Random random = new();

    private int spAttribute;

    public SpecialCard()
    {
        suitAttribute = "Special";
        numAttribute = 0;
        spAttribute = random.Next(1, 3);
    }
    public void Deduct()
    {

    }
    public void Skip()
    {

    }

}
