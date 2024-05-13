using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformCombat : MonoBehaviour
{
    public int ammo = 10;

    public int range = 20;

    public int meleeDamage = 15;


    public void PseudoUpdate()
    {
        //do i still see the player?
        DoAnAttack();

        //if not:
            //method calcualtes path to last known position
    }
    
    public void DoAnAttack()
    {

    }

}
