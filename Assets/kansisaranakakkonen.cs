using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kansisaranakakkonen : MonoBehaviour
{
    public bool kansiAuki;
    Vector3 alku;
    Vector3 kulma;
    Rigidbody rb;
    float alkuY;
    float alkuZ;

    // Start is called before the first frame update
    void Start()
    {
        alkuY = transform.eulerAngles.y;
        alkuZ = transform.eulerAngles.z;
        alku = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = alku;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, alkuY, alkuZ);
        if (transform.eulerAngles.x > 200 && transform.eulerAngles.x < 270)
        {
            transform.Rotate(1, 0, 0);
        }
        if (transform.eulerAngles.x > 1 && transform.eulerAngles.x < 200)
        {
            transform.Rotate(-1, 0, 0);
        }

        if (transform.eulerAngles.x < -10)
        {
            kansiAuki = true;
        }
        else
        {
            kansiAuki = false; 
        }
    }
}
