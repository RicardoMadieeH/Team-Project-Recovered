using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{

    public GameObject[] hearts; //[0] [1] [2]
    private int life;            //3
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {
            // ON DEAD CODE
            Scene scene = SceneManager.GetActiveScene();
			CharacterController2D.sceneList.Add(scene.name);
			Debug.Log("prev scene was " + scene.name);
            SceneManager.LoadScene("GameOver");
            Debug.Log("We are dead!");

        }
    }

    public void TakeDamage()
    {
        
        if (life >= 1)
        {
            life -= 1; //1-1=0
            Destroy(hearts[life].gameObject); //[0]
            SoundEffectsManagerScript.PlaySound("DamageTaken");
                if (life < 1)
             {
                dead = true;
            }
            
        }
    }
}
