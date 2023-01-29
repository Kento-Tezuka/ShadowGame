using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitune_en : AnimalBase
{
    protected override void Start()
    {
        base.Start();
        hp = 100;
        power = 20;
        attackRate = 60;
        normalY = 0;
        speed = -0.1f;
        isOpponent = true;
        maxAttackNum = 1;
        characost = 2;
    }


}
