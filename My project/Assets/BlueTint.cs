using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlueTint : MonoBehaviour
{
    [SerializeField] public float alpha = 0.5f;

    

    void Start(){

        Color tmp = GetComponent<SpriteRenderer>().color;
        tmp.a = alpha;
    }
     
}
