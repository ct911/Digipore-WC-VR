using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kasipaperi2 : MonoBehaviour
{
    Rigidbody rb2;
    bool osui2 = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (osui2 == true)
        {
            transform.position = GameObject.Find("paperipaikka2").transform.position;
            transform.rotation = GameObject.Find("paperipaikka2").transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "kasipaperilaatikko")
        {
            GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            Debug.Log("tippuuko");
            osui2 = true;
            rb2.useGravity = false;
            rb2.drag = 100;
            rb2.angularDrag = 100;
        }
    }
}
