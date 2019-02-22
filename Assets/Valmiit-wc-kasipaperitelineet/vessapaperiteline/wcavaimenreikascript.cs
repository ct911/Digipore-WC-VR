using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wcavaimenreikascript : MonoBehaviour
{
    public GameObject sarana;
    AudioSource aani;
    bool avaaja = false;
    
    void Start()
    {
        aani = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (avaaja == true)
        {
            sarana.GetComponent<wcppravaus>().WcAvaus();
        }
        if (avaaja == false)
        {
            sarana.GetComponent<wcppravaus>().WcSulkeminen();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "avain")
        {
            aani.Play();
            avaaja = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "avain")
        {
            aani.Play();
            avaaja = false;
        }
    }
}
