using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pprkaare2 : MonoBehaviour
{
    public GameObject kaare;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kasi")
        {
            GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste +=2;
            Destroy(gameObject);
        }
    }
}
