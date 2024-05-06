using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : MonoBehaviour
{
    //VARIABLE: CURRENT HEALTH
    [SerializeField] private float currentHealth;

    //VARIABLE: LOW HEALTH THRESHHOLD
    [SerializeField] private float lowHealthThreshhold;

    //VARIABLE: SPIN COOLDOWN
    [SerializeField] private float spinCooldown;

    //VARIABLE: HAS AXE
    [SerializeField] private bool hasAxe;

    //VARIABLE: MELEE RANGE
    [SerializeField] private float meleeRange;

    //VARIABLE: DISTANCE TO ENEMY
    [SerializeField] private float distanceToEnemy;

    //VARIABLE: ENEMY POS
    [SerializeField] private Vector3 enemyPosition;

    //VARAIBLE: THROW RANGE
    [SerializeField] private float throwRange;

    //VARIABLE DASH DISTANCE
    [SerializeField] private float dashDistance;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ChooseAction();
        }
    }

    private void ChooseAction()
    {
        //IF 'HEALTH LOW'
        if(currentHealth <= lowHealthThreshhold)
        {
            //PERFORM HEAL ACTION
            Debug.Log("Performed heal action");
            //BREAK/RETURN
            return;
        }

        //IF 'SPIN' OFF COOLDOWN
        if(spinCooldown <= 0 )
        {
            //PERFORM SPIN ACTION
            Debug.Log("Spinning is a good trick, I'll try that!");
            //BREAK/RETURN
            return;
        }

        //IF 'NOT HAVE AXE'
        if(hasAxe == false)
        {
            //GOTO GETAXE/FLEE
            Debug.Log("Got no axe, gotta go get one");
            //BREAK/RETURN
            return;
        }

        //WORK OUT DISTANCE TO ENEMY
        distanceToEnemy = Vector3.Distance(transform.position, enemyPosition);

        //IF IN MELEE RANGE
        if(distanceToEnemy < meleeRange)
        {
            //PERFORM MELEE ATTACK ACTION
            Debug.Log("Hit it with axe");
            //BREAK/RETURN
            return;
        }

        //IF IN THROW RANGE
        if(distanceToEnemy < throwRange)
        {
            //PERFORM THROW AXE ACTION
            Debug.Log("Throw axe at the thing");
            //BREAK/RETURN
            return;
        }

        //PERFORM DASH ACTION
        Debug.Log("Dash towards enemy");
    }

}
