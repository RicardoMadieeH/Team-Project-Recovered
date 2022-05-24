using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HeartSystem : MonoBehaviour
{

    public GameObject[] hearts; //[0] [1] [2]
    private int life;            //3
    private bool dead;
    AudioSource audioData;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {
            // SET DEAD CODE
            Debug.Log("We are dead!");
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d; //1-1=0
            Destroy(hearts[life].gameObject); //[0]
            audioData = GetComponent<AudioSource>();
            audioData.Play();
            if (life < 1)
            {
                dead = true;
            }
        }
        
    }
}
