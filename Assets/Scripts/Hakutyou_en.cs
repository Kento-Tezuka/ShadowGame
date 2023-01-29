using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hakutyou_en : AnimalBase
{
    protected override void Start()
    {
        base.Start();
        hp = 600;
        power = 70;
        attackRate = 60;
        normalY = 0;
        speed = -0.03f;
        isOpponent = true;
        maxAttackNum = 1;
    }


}
