using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kertakayttopyyhescript : MonoBehaviour
{
  


    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
        
       

    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "eriteLika")
        {
            gameObject.tag = "roska";
        }
    }
}
  

