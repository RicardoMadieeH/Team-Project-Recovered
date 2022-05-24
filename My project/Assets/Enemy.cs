using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {   
        animator.SetBool("isDead", false);
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage){
        //taking damage
        currentHealth -= damage;

        //playing hit animation

        //enemy dies
        if(currentHealth <= 0){
            Die();
        }

    }

    void Die(){
        Debug.Log("Enemy dies");

        //Die animation
        animator.SetBool("isDead", true);

        //Disable enemy
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + 0.5f);

    }
    
}
