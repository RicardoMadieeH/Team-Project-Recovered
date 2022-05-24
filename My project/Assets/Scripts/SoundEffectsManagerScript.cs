using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundEffectsManagerScript : MonoBehaviour{

    public static AudioClip playerHitSound; //po przecinku kolejne nazwy dzwiekow jakie bysmy chcieli dodac
    static AudioSource audioSrc;

    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("DamageTaken");
        //playerHitSound = Resources.Load<AudioClip>("DamageTaken"); // zaladowanie innych dzwiekow w razie potrzeby
                                                                     // plik z dzwiekiem musi byc w folderze Resources !
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "DamageTaken":
                audioSrc.PlayOneShot(playerHitSound);
                break;
        }
    }

}
