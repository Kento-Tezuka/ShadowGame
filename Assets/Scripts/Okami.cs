using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okami : AnimalBase
{   
    protected override void Start()
    {
        base.Start();
        hp = 200;
        power = 80;
        attackRate = 60;
        normalY = 0;
        speed = -0.1f;
        isOpponent = false;
        maxAttackNum = 1;
    }

    
        
   
    
}
