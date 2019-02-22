using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pprkaare : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
        if (other.gameObject.tag == "kasi")
        {
            Destroy(gameObject);
        }
    }
}
