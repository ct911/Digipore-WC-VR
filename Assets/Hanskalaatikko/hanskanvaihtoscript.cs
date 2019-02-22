using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanskanvaihtoscript : MonoBehaviour
{
    public Color kertanKaytto;
    AudioSource aani;
    private void Start()
    {
        aani = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "kasi")
        {
  
            aani.Play();
            GameObject.Find("LeftHand").GetComponent<hanskatPoisScripti>().hanskaPois = false;

            Renderer rend = other.GetComponent<Renderer>();
            rend.material.color = kertanKaytto;
        }  
    }
    
}
