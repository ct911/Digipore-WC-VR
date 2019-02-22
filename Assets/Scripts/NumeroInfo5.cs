using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroInfo5 : MonoBehaviour
{
    public int currentTexture; // Asetetaan tekstuuri
    Renderer munRenderer; // Haetaan renderi

    //private int osumat; // Julkistetaan osumat


    // Start is called before the first frame update
    void Start()
    {
        munRenderer = GetComponent<Renderer>();
        //osumat = 8;// Osumien/pisteiden kokonaismäärä alussa
    }


    private void OnTriggerEnter(Collider other)  // Osuminen collideriin

    {
        if (other.gameObject.CompareTag("kasi")) //tagin omistava objekti saa osuessaan toiminnan tapahtumaan
        {
            munRenderer.material.mainTexture = Resources.Load("Ohje5") as Texture;

        }
    }

    private void OnTriggerExit(Collider other)  // Irtoaminen colliderista

    {
        if (other.gameObject.CompareTag("kasi")) //tagin omistava objekti saa irrotessaan toiminnan tapahtumaan
        {
            munRenderer.material.mainTexture = Resources.Load("5") as Texture;

        }
    }
}
