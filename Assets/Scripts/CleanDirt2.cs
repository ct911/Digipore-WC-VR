using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanDirt2 : MonoBehaviour
{
    public int currentTexture;
    Renderer munRenderer;

    private float osumat;
    bool osuu;


    // Start is called before the first frame update
    void Start()
    {
        munRenderer = GetComponent<Renderer>();
        osumat = 8;
        osuu = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (osuu == true)
        {
            osumat -= Time.deltaTime*2;
        }
        if (osumat < 6)
        {
            munRenderer.material.mainTexture = Resources.Load("Lika2") as Texture;
        }
        if (osumat < 3)
        {
            munRenderer.material.mainTexture = Resources.Load("Lika1") as Texture;
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
