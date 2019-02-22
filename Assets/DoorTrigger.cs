using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    [SerializeField]
    GameObject door;

    void OnTriggerEnter(Collider col)
    {
        door.transform.position += new Vector3(0, 4, 0);
    }


}
