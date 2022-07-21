using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpReset : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<playermovement>().isGrounded = true;

    }
}
