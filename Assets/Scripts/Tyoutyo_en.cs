using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyoutyo_en : AnimalBase
{
    protected override void Start()
    {
        base.Start();
        hp = 200;
        power = 30;
        attackRate = 60;
        normalY = 0;
        speed = -0.04f;
        isOpponent = true;
        maxAttackNum = 1;
    }


}
