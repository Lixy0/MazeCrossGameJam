using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class interactionScript : MonoBehaviour
{
    // Interaction WIN/PLAYER
    public bool isInRange;
    public UnityEvent interactAction;

    // New Scene/Next Level
    public bool interactLoadLevel =false;
    public int iLevelToLoad;
    public string sLevelToLoad;



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

        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("range player OK");
            LoadScene();
        }

    }

    void LoadScene()
    {
        if (interactLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);

        }

    }


}
