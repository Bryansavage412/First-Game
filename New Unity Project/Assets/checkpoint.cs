using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 newPosition = transform.position;
            newPosition.y = newPosition.y + 1;
            other.GetComponent<playermovement>().respawnPosition = newPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
