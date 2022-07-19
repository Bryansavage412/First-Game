using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smackyScript : MonoBehaviour
{
    public float explosionForce = 50;

    private void OnCollisionEnter(Collision collision)
    {

        print("tag");


        collision.collider.gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, collision.contacts[0].point,7, 6);
    }

}
