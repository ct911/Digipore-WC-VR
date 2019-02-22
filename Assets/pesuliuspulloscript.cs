using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesuliuspulloscript : MonoBehaviour
{
    public ParticleSystem ruisku;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x < 100 && transform.eulerAngles.x > 0)
        {
            if (ruisku.isPlaying == false)
            {
                ruisku.Play();
            }
        }
        else
        {
            ruisku.Stop();
        }
        
    }
}
