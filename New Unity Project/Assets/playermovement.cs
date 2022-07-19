using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public int moveSpeed = 1;
    bool isGrounded = false;
    public float jumpForce = 7f;
    public float rotateSpeed = 5;
    public Vector3 respawnPosition;
    private void Start()
    {
        Cursor.visible = false;
        respawnPosition= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void FixedUpdate()
    {
        if(GetComponent<Rigidbody>().velocity.y == 0)
        {
            isGrounded = true;
        }

        if (isGrounded)
        {

            if (Input.GetAxis("Jump") > 0)
            {
                isGrounded = false;
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            }
        }
    }

    public void RespawnPlayer()
    {
        transform.position = respawnPosition;
    }
    
    
} //end of script
