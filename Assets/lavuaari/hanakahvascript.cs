using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanakahvascript : MonoBehaviour
{
    Vector3 alku;
    Vector3 kulma;
    Rigidbody rb;
    GameObject vesi;
    ParticleSystem vesiPartikkelit;
    float alkuY;
    float alkuZ;
    public GameObject vesisysteemi;
    AudioSource aani;
   


    public bool hanaAuki;
    // Start is called before the first frame update
    void Start()
    {
        alkuY = transform.eulerAngles.y;
        alkuZ = transform.eulerAngles.z;
        alku = transform.position;
        aani = GetComponent<AudioSource>();
        
        vesiPartikkelit = vesisysteemi.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = alku;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, alkuY, alkuZ);
        if(transform.eulerAngles.x < 70)
        {
            transform.Rotate(1, 0, 0);
        }


        if (transform.eulerAngles.x < 85)
        {
            hanaAuki = true;
            if(aani.isPlaying == false)
            {
                aani.Play();
            }
            
            vesiPartikkelit.Play();
         
        }
        else
        {
            vesiPartikkelit.Stop();
            hanaAuki = false;
            aani.Stop();
        }
    }
}
