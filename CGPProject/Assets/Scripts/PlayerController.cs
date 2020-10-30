using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //script for player controller
   // public float speed;  
    private Rigidbody2D rb;    
    public Camera mainCamera; 
    public float leftmax;
    public float rightmax;

    void Start()
    {
        //storing rigidbody
        rb = GetComponent<Rigidbody2D> ();
        mainCamera = FindObjectOfType<Camera>();
    }

    void FixedUpdate()
    {
        /* //Keyboard input
        //take input for movement
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        //move player in direction of input
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        //how fast player will move
        rb.AddForce (movement * speed); */

        Movement();
        
    }

    void Movement()
    {
        //Mouse Input
        float maxMovement = Mathf.Clamp (Input.mousePosition.x, leftmax, rightmax);
        //float worldXPos = mainCamera.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, 0, 0)).x;
        float worldXPos = mainCamera.ScreenToWorldPoint(new Vector3 (maxMovement, 0, 0)).x;
        this.transform.position = new Vector3 (worldXPos, -10, 0);
    }
}
