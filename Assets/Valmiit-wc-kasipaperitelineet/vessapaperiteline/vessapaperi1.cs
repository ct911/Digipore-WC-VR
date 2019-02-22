using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vessapaperi1 : MonoBehaviour
{
    Rigidbody rb4;
    bool osui4 = false;
    // Start is called before the first frame update
    void Start()
    {
        rb4 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (osui4 == true)
        {
            transform.position = GameObject.Find("wcpaperipaikka1").transform.position;
            transform.rotation = GameObject.Find("wcpaperipaikka1").transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "vessapaperilaatikko")
        {
            if (osui4 == false)
            {
                GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            }
            osui4 = true;
            rb4.useGravity = false;
            rb4.drag = 100;
            rb4.angularDrag = 100;
        }
    }
}
