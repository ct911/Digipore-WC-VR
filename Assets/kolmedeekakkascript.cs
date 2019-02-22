using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolmedeekakkascript : MonoBehaviour
{
    private float osumaPisteet;
    private float scalex;
    private float scaley;
    private float scalez;
    Renderer munRendaaja;
    Color vari;
    bool osuu;

    void Start()
    {
        osumaPisteet = 1;
        munRendaaja = GetComponent<Renderer>();
        vari = munRendaaja.material.color;
        scalex = transform.localScale.x;
        scaley = transform.localScale.y;
        scalez = transform.localScale.z;
        vari.a = 1f;
        osuu = false;
    }

    void Update()
    {
        if (osuu== true)
        {
            osumaPisteet += Time.deltaTime;
            scalex = scalez + osumaPisteet * 0.1f;
            scaley = scalez + osumaPisteet * 0.1f;
            scalez = scalez - osumaPisteet * 0.01f;
            vari.a -= 0.04f;

        }

        munRendaaja.material.color = vari;
        transform.localScale = new Vector3(scalex, scaley, scalez);
        if(osumaPisteet > 3)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "kakkaLuutu")
        {
            osuu = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "kakkaLuutu")
        {
            osuu =false;
        }
    }
}

