using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okami_en : AnimalBase
{   
    protected override void Start()
    {
        base.Start();
        hp = 200;
        power = 80;
        attackRate = 60;
        normalY = 0;
        speed = -0.1f;
        isOpponent = true;
        maxAttackNum = 1;
    }

    
        
   
    
}
