using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovisaransascript : MonoBehaviour
{
    public bool kansiAuki;
    public int kulma;
  

    // Start is called before the first frame update
    void Start()
    {
        kulma = 0;
      
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (kansiAuki == true)
        {
            if(kulma < 120)
            {
                transform.Rotate(0, 1, 0);
                kulma++;
            }

        }
        if (kansiAuki == false)
        {
            if (kulma > 0)
            {
                transform.Rotate(0, -1, 0);
                kulma--;
            }

        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "kasi")
        {
            kansiAuki = true;
        }
        /*if(kansiAuki== true && other.gameObject.tag == "kasi")
        {
            kansiAuki = false;
        }
        */
    }
}
