using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitune : AnimalBase
{
    protected override void Start()
    {
        base.Start();
        hp = 100;
        power = 20;
        attackRate = 60;
        normalY = 0;
        speed = -0.1f;
        isOpponent = false;
        maxAttackNum = 1;
        characost = 2;
    }


}
