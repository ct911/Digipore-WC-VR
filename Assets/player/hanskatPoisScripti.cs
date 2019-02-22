using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanskatPoisScripti : MonoBehaviour
{
    public Color kumiHanska;
    public bool hanskaPois = false;
    AudioSource aani;

    // Start is called before the first frame update
    void Start()
    {
        hanskaPois = false;
        //aani = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "kasi")
        {
            
            if(hanskaPois == false)
            {
                //aani.Play();
                GameObject.Find("kertsihanskaroska").transform.position = other.transform.position;
                Renderer rend = other.GetComponent<Renderer>();
                rend.material.color = kumiHanska;
                Debug.Log("poipois!");
            }
            
            hanskaPois = true;
        }
    }
    
}
