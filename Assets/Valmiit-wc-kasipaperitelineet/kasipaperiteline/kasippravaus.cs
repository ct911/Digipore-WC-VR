using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kasippravaus : MonoBehaviour
{
    
    private void Start()
    {
        
    }
    float asentoy;

    public void Avaus()
    {
        
        asentoy = transform.localRotation.eulerAngles.y;
        if (asentoy < 100)
        {
            transform.Rotate(0, 1f, 0);
        }
    }

    public void Sulkeminen()
    {
        asentoy = transform.localRotation.eulerAngles.y;
        if (asentoy > 1)
        {
            transform.Rotate(0, -1f, 0);
        }
    } 
}


