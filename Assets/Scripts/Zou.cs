using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zou : AnimalBase
{
    protected override void Start()
    {
        base.Start();
        hp = 1000;
        power = 200;
        attackRate = 120;
        normalY = 0;
        speed = -0.03f;
        isOpponent = false;
        maxAttackNum = 5;
    }


}
