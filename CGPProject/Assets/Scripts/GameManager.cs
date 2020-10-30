using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Fireball initialFireball;
    public Fireball prefabFb; 

    public PlayerController player;

    public GameObject playerGameObject; 

    public static bool startGame;
    public static bool gameStarted;

    public int count;

    int lives;


    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        InitializeFB();
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 playerPos = player.gameObject.transform.position;
       Vector3 fbPos = new Vector3 (playerPos.x, playerPos.y + 0.25f, 0);

       if (Input.GetMouseButtonDown(0))
       {
           startGame = true;
       }

       if (!startGame)
       {
           initialFireball.transform.position = fbPos;
       }

       Restart();
       Win();
       Lose();
    }

    void Restart()
    {
        if (startGame == true && initialFireball == null)
        {
            startGame = false;
            lives = lives - 1;
            Debug.Log("Lives: " + lives);

            if (lives > 0)
            {
              InitializeFB();
            }
        }
    }

    void Lose()
    {
        if (lives <= 0)
        {
            //Lose Screen
            Debug.Log("Dead");
            Destroy(playerGameObject.gameObject);
        }
    }

    void Win()
    {
        GameObject[] bricks;
        bricks = GameObject.FindGameObjectsWithTag("Brick");
        count = bricks.Length;
        Debug.Log("Count: " + count);
        if (count <= 0)
        {
            //Move to Next Scene
            Debug.Log("Win");
        }
    }

    public void InitializeFB()
    {
        Vector3 playerPos = player.gameObject.transform.position;
        Vector3 fbPos = new Vector3 (playerPos.x, playerPos.y + 0.25f, 0);
        initialFireball = Instantiate(prefabFb, fbPos, Quaternion.identity);
    }
}
