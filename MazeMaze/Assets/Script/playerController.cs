using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;

    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            // player input
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

        if (canMove == true)
        {
            // move player
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }

    }


    private void OnCollision(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            canMove = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        canMove = false;
    }
}
