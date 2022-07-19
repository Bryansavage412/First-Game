using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtslarry : MonoBehaviour
{
    public Vector3 startPosition = new Vector3();

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<playermovement>().RespawnPlayer();
        }

    }
}
