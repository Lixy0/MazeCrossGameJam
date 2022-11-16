using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class interactionWallScript : MonoBehaviour
{
    // Interaction WIN/PLAYER
    public bool isInRange;
    public UnityEvent interactAction;

    // Stop moving WALL/PLAYER
    public bool interactWall = false;
    public bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        // If in range
        if (isInRange)
        {
            interactAction.Invoke(); // Event
        }

    }


    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Wall"))
        {
            isInRange = true;
            Debug.Log("range player wall OK");
            canMove();
        }

    }

    void canMove()
    {
        if (interactWall)
        {
            moving = false;
        }
        else
        {
            moving = true;

        }

    }

}
