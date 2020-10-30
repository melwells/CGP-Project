using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
   // public Rigidbody2D rb;

    //Script for fireball prefab
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;
    public float force;

    public bool reset;

    //GameManager gameManager;

    public int lives;
    //public GameObject[] spawnPickup;

    // Start is called before the first frame update
    void Start()
    {
        //making force for bounce mechanic
       // rb.AddForce(new Vector2(1f,0.5f) * Time.deltaTime * force);
        //fly up on instantiation
        rb.velocity = transform.up * speed;
        lives = 3;
        reset = false;
        //gameManager = GameObject.FindObjectOfType(typeof(GameManager)) as GameManager;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        //call brick script to access what type of brick was hit
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.DamageTaken(damage);
            //Instantiate(spawnPickup[Random.Range(0, spawnPickup.Length)], this.transform);
        }
        //what did I hit
        Debug.Log(hitInfo.name);
       

        if (hitInfo.gameObject.tag == "BottomWall")
        {
            Destroy(this.gameObject);
        }
    }  

     void OnCollisionEnter2D(Collision2D collision)
    {
      /*  if (collision.gameObject.tag == "BottomWall")
        {
            Debug.Log("Hit Wall");
            lives = lives -1;
            Debug.Log("Lives: " + lives);
        } */

        if (collision.gameObject.tag == "Brick")
        {
            Destroy(collision.gameObject);
        }
        

    } 

    /* void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (GameManager.startGame == true && GameManager.gameStarted == false)
        {
            rb.AddForce(transform.up * .25f);
            GameManager.gameStarted = true;
        }

        if (rb.velocity.x <1 && rb.velocity.x >= 0)
        {
            rb.AddForce(transform.right * -50);
        }

        if (rb.velocity.x > -1 && rb.velocity.x <= 0)
        {
            rb.AddForce(transform.right * 50);
        }

        if (rb.velocity.y <1 && rb.velocity.y >= 0)
        {
            rb.AddForce(transform.up * -50);
        }

        if (rb.velocity.y > -1 && rb.velocity.y <= 0)
        {
            rb.AddForce(transform.up * 50);
        }
    } */
}
