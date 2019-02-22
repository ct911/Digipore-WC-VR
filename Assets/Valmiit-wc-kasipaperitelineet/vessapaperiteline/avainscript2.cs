using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avainscript2 : MonoBehaviour
{
    private Vector3 asento;
    Rigidbody rb3;
    private bool osui3 = false;
    // Start is called before the first frame update
    void Start()
    {
        rb3 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (osui3 == true)
        {
            asento = new Vector3(transform.position.x, GameObject.Find("reika1").transform.position.y, GameObject.Find("reika1").transform.position.z);
            transform.position = asento;
            transform.rotation = GameObject.Find("reika1").transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "reika1")
        {
            Debug.Log("tippuuko");
            osui3 = true;
            rb3.useGravity = false;
            rb3.drag = 100;
            rb3.angularDrag = 100;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "reika1")
        {
            Debug.Log("tippuuko");
            osui3 = false;
            rb3.useGravity = true;
            rb3.drag = 0;
            rb3.angularDrag = 0;
        }
    }
}
