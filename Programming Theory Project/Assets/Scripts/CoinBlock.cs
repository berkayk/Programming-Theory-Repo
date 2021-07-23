using System.Collections;
using System.Collections.Generic;
using ExtensionMethods;
using UnityEngine;

public class CoinBlock : TileBlock
{
    public void Awake()
    {
        Decorate();
    }
    public override void Decorate()
    {
        int grassesToShow = 2;
        ShowGrasses(grassesToShow);
        if (grassesToShow > 0)
        {
            ToggleStones(false);
        }
        else
        {
            ToggleStones(Helpers.RandomBool());
        }
        
        ShowCoin(0);
    }

    public override string GetName()
    {
        return "Coin Block";
    }
}
