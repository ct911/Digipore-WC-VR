using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saippuapaikka1script : MonoBehaviour
{
    public bool paikalla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "saippualaatikko")
            {
            paikalla = true;
        }
    }
}
