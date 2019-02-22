using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kasipaperi : MonoBehaviour
{
    Rigidbody rb;
    public bool osui = false;
    bool osui1 = false;
    bool osui2 = false;
    bool osui3 = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (osui == true)
        {
            transform.position = GameObject.Find("paperipaikka1").transform.position;
            transform.rotation = GameObject.Find("paperipaikka1").transform.rotation;
        }
        if (osui1 == true)
        {
            transform.position = GameObject.Find("paperipaikka2").transform.position;
            transform.rotation = GameObject.Find("paperipaikka2").transform.rotation;
        }
        if (osui2 == true)
        {
            transform.position = GameObject.Find("paperipaikka12").transform.position;
            transform.rotation = GameObject.Find("paperipaikka12").transform.rotation;
        }
        if (osui3 == true)
        {
            transform.position = GameObject.Find("paperipaikka22").transform.position;
            transform.rotation = GameObject.Find("paperipaikka22").transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "paperipaikka1")
        {
            if (osui == false)
            {
                GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            }
          
            osui = true;
            rb.useGravity = false;
            rb.drag = 100;
            rb.angularDrag = 100;
        }
        if (other.name == "paperipaikka2")
        {
            if (osui1 == false)
            {
                GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            }
            osui1 = true;
            rb.useGravity = false;
            rb.drag = 100;
            rb.angularDrag = 100;
        }
        if (other.name == "paperipaikka12")
        {
            if (osui2 == false)
            {
                GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            }
            osui2 = true;
            rb.useGravity = false;
            rb.drag = 100;
            rb.angularDrag = 100;
        }
        if (other.name == "paperipaikka22")
        {
            if (osui3 == false)
            {
                GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            }
            osui3 = true;
            rb.useGravity = false;
            rb.drag = 100;
            rb.angularDrag = 100;
        }
    }
}
