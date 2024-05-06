using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
        if (gameManager != null)
        {
            gameManager.ScoreUp();
        }
    }

    public void OnDestroy()
    {

        Debug.Log("Self-destructive: " + name);

    }
    private bool isDestroyed = false;

    /*void Update()
    {
        // Check if there is a touch on the screen
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first touch (assuming single touch)

            // Check if the touch phase is "Began" and the touch hits this GameObject
            if (touch.phase == TouchPhase.Began && !isDestroyed)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // Perform a raycast to detect if the touch hits this GameObject
                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                {
                    // Call the method to increase score in GameManager
                    GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();

                    // Destroy this GameObject
                    Destroy(gameObject);

                    // Set a flag to prevent multiple destructions with subsequent taps
                    isDestroyed = true;
                }
            }
        }
    }*/
}
