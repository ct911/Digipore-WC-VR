using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harjaus : MonoBehaviour
{
    AudioSource aani;
    bool harjaaminen = false;

    //Start is called before the first frame update
    private void Start()
    {
        aani = GetComponent<AudioSource>();
 }

    // Update is called once per frame

    void Update()
    {

    }
    
    private void OnTriggerEnter(Collider other)
        
    {
       
        
           
            if(aani.isPlaying == false)
            {
                aani.Play();
            harjaaminen = true;
            }
        

    }
    private void OnTriggerExit(Collider other)
    {
        if (aani.isPlaying == false)
        {
            aani.Play();
        }
    }

}

