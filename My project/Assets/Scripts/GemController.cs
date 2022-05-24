using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    //How many gems were picked up
    public static int totalGems = 0;

    void OnTriggerEnter2D(Collider2D collision){
        //Destroy gem if collected by player
        if(collision.CompareTag("Player")){
            totalGems++;
            Debug.Log("You have " + GemController.totalGems + " gems.");
            Destroy(gameObject);
        }
    }
    
}
