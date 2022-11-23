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

    [SerializeField] private bool canMove=true;

    private Vector3 playerDirection = Vector3.zero;


    // -- Direction du joueur SWIPE (up;down;left;right)
    private void OnEnable()
    {
        swipeListener.OnSwipe.AddListener(OnSwipe);
    }

    // up;down;left;right movement
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

    void Update()
    {
        if (canMove == true)
        {
            playerTransform.position += (Vector3)playerDirection * playerSpeed * Time.deltaTime;
        }

    }


    // --- Detection collision (PLAYER/WALL)
    private void OnTriggerEnter(Collider collision)
    {
        // si collision avec tag "Wall" le player ne peut plus bouger
        if (collision.gameObject.CompareTag("Wall"))
        {
            StartCoroutine(Example());
            Debug.Log("player/wall ON");
            //canMove = false;

        }
    }


    // En sortant de la collision, le player peut bouger
    private void OnTriggerExit(Collider collision)
    {
        canMove = false;
        Debug.Log("player/wall OFF");

    }
    IEnumerator Example()
    {
        Debug.Log("time start");
        canMove = true;
        yield return new WaitForSecondsRealtime(0.25f);
        canMove = false;
        Debug.Log("time done");
    }

}
