using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oviscript : MonoBehaviour
{
    public Transform sarana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, sarana.eulerAngles.y, transform.eulerAngles.z);  
    }
}
