using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using GG.Infrastructure.Utils.Swipe;


public class playerController : MonoBehaviour
{
    [SerializeField] private SwipeListener swipeListener;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float playerSpeed;

    private Vector3 playerDirection = Vector3.zero;


    private void OnEnable()
    {
        swipeListener.OnSwipe.AddListener(OnSwipe);
    }

    private void OnSwipe(string swipe)
    {
        Debug.Log(swipe);

            switch (swipe)
            {
                case "Right":
                    playerDirection = Vector3.right;
                    break;

                case "Left":
                    playerDirection = Vector3.left;
                    break;

                case "Up":
                    playerDirection = Vector3.up;

                    break;

                case "Down":
                    playerDirection = Vector3.down;
                    break;
            }
       


    }

    private void OnDisable()
    {
        swipeListener.OnSwipe.RemoveListener(OnSwipe);
    }

    //Slide WALL/PLAYER
    //public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (canMove)
        //{
            playerTransform.position += (Vector3)playerDirection * playerSpeed * Time.deltaTime;

        //}


    }



    //private void OnCollision(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Wall")
    //    {
    //        canMove = true;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    canMove = false;
    //}
}
