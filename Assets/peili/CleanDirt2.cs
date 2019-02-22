using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanDirt3 : MonoBehaviour
{
    public int currentTexture;
    Renderer munRenderer;

    private int osumat;


    // Start is called before the first frame update
    void Start()
    {
        munRenderer = GetComponent<Renderer>();
        osumat = 8;
    }

    // Update is called once per frame
    void Update()
    {
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
        if (other.gameObject.CompareTag("lattiaLuutu"))
        {
            osumat--;
            
        }
        
    }
}
