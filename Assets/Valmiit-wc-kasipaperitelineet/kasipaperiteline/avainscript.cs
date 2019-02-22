using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avainscript : MonoBehaviour
{
    private Vector3 asento;
    Rigidbody rb3;
    private bool osui = false;
    private bool osui1 = false;
    private bool osui2 = false;
    private bool osui3 = false;
    // Start is called before the first frame update
    void Start()
    {
        rb3 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (osui == true)
        {
            asento = new Vector3(transform.position.x, GameObject.Find("reika").transform.position.y, GameObject.Find("reika").transform.position.z);
            transform.position = asento;
            transform.rotation = GameObject.Find("reika").transform.rotation;
        }
        if (osui1 == true)
        {
            asento = new Vector3(transform.position.x, GameObject.Find("reika1").transform.position.y, GameObject.Find("reika1").transform.position.z);
            transform.position = asento;
            transform.rotation = GameObject.Find("reika1").transform.rotation;

        }
        if (osui2 == true)
        {
            asento = new Vector3(transform.position.x, GameObject.Find("reika2").transform.position.y, GameObject.Find("reika2").transform.position.z);
            transform.position = asento;
            transform.rotation = GameObject.Find("reika2").transform.rotation;
        }
        if (osui3 == true)
        {
            asento = new Vector3(transform.position.x, GameObject.Find("reika3").transform.position.y, GameObject.Find("reika3").transform.position.z);
            transform.position = asento;
            transform.rotation = GameObject.Find("reika3").transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "reika")
        {
            
            osui = true;
            rb3.useGravity = false;
            rb3.drag = 100;
            rb3.angularDrag = 100;
        }
        if (other.name == "reika1")
        {
            
            osui1 = true;
            rb3.useGravity = false;
            rb3.drag = 100;
            rb3.angularDrag = 100;
        }
        if (other.name == "reika2")
        {

            osui2 = true;
            rb3.useGravity = false;
            rb3.drag = 100;
            rb3.angularDrag = 100;
        }
        if (other.name == "reika3")
        {

            osui3 = true;
            rb3.useGravity = false;
            rb3.drag = 100;
            rb3.angularDrag = 100;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "reika")
        {
            
            osui = false;
            rb3.useGravity = true;
            rb3.drag = 0;
            rb3.angularDrag = 0;
        }
        if (other.name == "reika1")
        {
            
            osui1 = false;
            rb3.useGravity = true;
            rb3.drag = 0;
            rb3.angularDrag = 0;
        }
        if (other.name == "reika2")
        {

            osui2 = false;
            rb3.useGravity = true;
            rb3.drag = 0;
            rb3.angularDrag = 0;
        }
        if (other.name == "reika3")
        {

            osui3 = false;
            rb3.useGravity = true;
            rb3.drag = 0;
            rb3.angularDrag = 0;
        }
    }
}
