using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            Attack();
        }
    }

    void Attack(){
       //Detecting enemies, playing attack animation, damaging enemies
        animator.SetTrigger("Attack");
    }
}

