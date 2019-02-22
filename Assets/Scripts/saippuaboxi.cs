using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saippuaboxi : MonoBehaviour
{
    public bool aukee = false;
    public GameObject loota;
    
    // Start is called before the first frame update
    void Start()
    {
        loota.GetComponent<saippuapaikka1script>();
    }

    // Update is called once per frame
    void Update()
    {
         if(loota.GetComponent<saippuapaikka1script>().paikalla == true)
         {
             aukee = false;
         }
         if(aukee == true && transform.eulerAngles.z < 100)
         {
             transform.Rotate(0, 0, 1);
         }
         if(aukee == false && transform.eulerAngles.z > 1)
         {
             transform.Rotate(0, 0, -1);
         }
     }
     private void OnTriggerEnter(Collider other)
     {
         if(other.tag == "kasi")
         {
             aukee = true;
         }
         
    }

}
