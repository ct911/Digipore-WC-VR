using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istuinsaranascript : MonoBehaviour
{
    public Transform kahva;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(kahva);
       


    }
}
