using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bajs1Sp : MonoBehaviour
{
    public int currentTexture;
    Renderer munRendaaja;

    private float osumat;
    bool osuu;

    // Start is called before the first frame update
    void Start()
    {
        munRendaaja = GetComponent<Renderer>();
        osumat = 6;
        osuu = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (osuu == true)
        {
            osumat -= Time.deltaTime * 2;
        }
       if (osumat < 4)
        {
            munRendaaja.material.mainTexture = Resources.Load("bajs2") as Texture;
        }
        if (osumat < 3)
        {
            munRendaaja.material.mainTexture = Resources.Load("bajs1") as Texture;
        }
        if (osumat < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("luutu"))
        {
            osuu = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("luutu"))
        {
            osuu = false;
        }
    }
}
