using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avaimenreikascript : MonoBehaviour
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
            sarana.GetComponent<kasippravaus>().Avaus();
        }
        if (avaaja == false)
        {
            sarana.GetComponent<kasippravaus>().Sulkeminen();
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
