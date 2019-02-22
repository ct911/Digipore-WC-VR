using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroInfo32 : MonoBehaviour
{
    public int currentTexture; // Asetetaan tekstuuri
    Renderer munRenderer; // Haetaan renderi
    Texture numero3;

    //private int osumat; // Julkistetaan osumat


    // Start is called before the first frame update
    void Start()
    {
        munRenderer = GetComponent<Renderer>();
        numero3 = munRenderer.material.mainTexture;
        //osumat = 8;// Osumien/pisteiden kokonaismäärä alussa
    }


    private void OnTriggerEnter(Collider other)  // Osuminen collideriin

    {
        if (other.gameObject.CompareTag("kasi")) //tagin omistava objekti saa osuessaan toiminnan tapahtumaan
        {
            munRenderer.material.mainTexture = Resources.Load("Ohje32") as Texture;
            Debug.Log("Ohje32");
        }
    }

    private void OnTriggerExit(Collider other)  // Irtoaminen colliderista

    {
        if (other.gameObject.CompareTag("kasi")) //tagin omistava objekti saa irrotessaan toiminnan tapahtumaan
        {
            munRenderer.material.mainTexture = numero3;

        }
    }
}
