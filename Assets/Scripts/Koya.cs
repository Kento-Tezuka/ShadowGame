using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koya : AnimalBase
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        hp = 2000;
        power = 0;
        attackRate = 60;
        normalY = 0;
        speed = 0f;
        isOpponent = false;
        maxAttackNum = 1;
    }

    
}
