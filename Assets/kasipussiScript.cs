﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kasipussiScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "roska")
        {
            Destroy(other.gameObject);
        }
    }
}
