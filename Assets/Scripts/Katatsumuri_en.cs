using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katatsumuri_en : AnimalBase
{

    protected override void Start()
    {
        base.Start();
        hp = 120;
        power = 30;
        attackRate = 60;
        normalY = 0;
        speed = 0.02f;
        isOpponent = true;
        maxAttackNum = 1;

    }

    /*
    public override void Attack()
    {
        base.Attack();
        //スローニスル
    }
    */
}
