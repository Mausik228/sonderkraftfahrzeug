using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public GameObject tp2;
    public void OnTriggerEnter(Collider other)
    {if (other.gameObject.name == "Sphere")
        other.gameObject.transform.position = tp2.transform.position;
    }
}
