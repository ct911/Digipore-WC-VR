using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wcppravaus : MonoBehaviour
{
    float asentox;

    public void WcAvaus()
    {
        asentox = transform.localRotation.eulerAngles.x;
        if (asentox < 90)
        {
            transform.Rotate(1f, 0, 0);
        }
    }

    public void WcSulkeminen()
    {
        asentox = transform.localRotation.eulerAngles.x;
        if (asentox > 1)
        {
            transform.Rotate(-1f, 0, 0);
        }
    } 
}


