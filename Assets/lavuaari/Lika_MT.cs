using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lika_MT : MonoBehaviour
{


    Renderer myRenderer;

    private float osumat;
    bool osuu;


    // Start is called before the first frame update
    void Start()


    {
      
        myRenderer = GetComponent<Renderer>();
        osumat = 9;
        osuu = false;


    }

    // Update is called once per frame
    void Update()
    {
        if(osuu== true)
        {
            osumat -= Time.deltaTime * 2;
        }
        if (osumat < 6)
        {
            myRenderer.material.mainTexture = Resources.Load("lika_2_MT") as Texture;
        }
        if (osumat < 3)
        {
            myRenderer.material.mainTexture = Resources.Load("lika_1_MT") as Texture;
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

