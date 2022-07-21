using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpstartballs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<Rigidbody>().AddExplosionForce(700, transform.position, 700, 100);
        }
    }
}
