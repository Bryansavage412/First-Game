using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public GameObject firstPerson;
    public GameObject thirdPerson;


    public int moveSpeed = 1;
    public bool isGrounded = false;
    public float jumpForce = 7f;
    public float rotateSpeed = 5;
    public Vector3 respawnPosition;
    private void Start()
    {
        Cursor.visible = false;
        respawnPosition= transform.position;
        ToggleThird();
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
        if (isGrounded)
        {
            if (Input.GetAxis("Jump") > 0)
            {
                Debug.Log("Jumped: " + Time.time);
                isGrounded = false;
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            }
        }
    }

    public void RespawnPlayer()
    {
        transform.position = respawnPosition;
    }
    
    public void ToggleFirst()
    {
        firstPerson.SetActive(true);
        thirdPerson.SetActive(false);
    }

    public void ToggleThird()
    {
        thirdPerson.SetActive(true);
        firstPerson.SetActive(false);
    }
    
} //end of script
