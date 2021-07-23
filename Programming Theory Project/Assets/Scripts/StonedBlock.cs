using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonedBlock : TileBlock
{
    public void Awake()
    {
        Decorate();
    }
    public override void Decorate()
    {
        ShowGrasses(0);
        ToggleStones(true);
    }

    public override string GetName()
    {
        return "Stoned Block";
    }
}
