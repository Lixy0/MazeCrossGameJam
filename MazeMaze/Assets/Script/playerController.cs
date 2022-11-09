using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerController : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;

    public bool canMove = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            // player input
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            // move player
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }
    }


    private void OnCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            canMove = true;
        }
    }

    private void OnCollisionExit(Collision2D collision)
    {
        canMove = false;
    }
}
