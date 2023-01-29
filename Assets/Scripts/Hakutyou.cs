using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hakutyou : AnimalBase
{
    protected override void Start()
    {
        base.Start();
        hp = 600;
        power = 70;
        attackRate = 60;
        normalY = 0;
        speed = -0.03f;
        isOpponent = false;
        maxAttackNum = 1;
    }


}
